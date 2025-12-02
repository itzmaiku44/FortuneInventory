using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public class SaleLedger
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        public class OrderRecord
        {
            public int OrderId { get; set; }
            public int CashierId { get; set; }
            public string? CashierName { get; set; }
            public DateTime Date { get; set; }
            public int ProductId { get; set; }
            public string? ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }

        /// <summary>
        /// Records an order to the database
        /// </summary>
        public bool RecordOrder(int cashierId, DateTime date, int productId, int quantity, decimal totalPrice)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    INSERT INTO dbo.order_t (cashierID, date, productID, quantity, totalPrice)
                    VALUES (@cashierID, @date, @productID, @quantity, @totalPrice);";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cashierID", cashierId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@productID", productId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to record order: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Records multiple order items (for a single transaction)
        /// </summary>
        public bool RecordOrderItems(int cashierId, DateTime date, List<CartItem> items)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                foreach (var item in items)
                {
                    string sql = @"
                        INSERT INTO dbo.order_t (cashierID, date, productID, quantity, totalPrice)
                        VALUES (@cashierID, @date, @productID, @quantity, @totalPrice);";

                    using var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cashierID", cashierId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@productID", item.ProductId);
                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@totalPrice", item.TotalPrice);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to record order items: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Gets all orders from the database
        /// </summary>
        public List<OrderRecord> GetAllOrders()
        {
            var orders = new List<OrderRecord>();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT o.orderID,
                           o.cashierID,
                           u.firstName + ' ' + u.lastName AS cashierName,
                           o.date,
                           o.productID,
                           p.productName,
                           o.quantity,
                           o.totalPrice
                    FROM dbo.order_t o
                    LEFT JOIN dbo.users_t u ON o.cashierID = u.userID
                    LEFT JOIN dbo.products_t p ON o.productID = p.productID
                    ORDER BY o.date DESC, o.orderID DESC;";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new OrderRecord
                    {
                        OrderId = reader["orderID"] is int oid ? oid : Convert.ToInt32(reader["orderID"]),
                        CashierId = reader["cashierID"] is int cid ? cid : Convert.ToInt32(reader["cashierID"]),
                        CashierName = reader["cashierName"]?.ToString(),
                        Date = reader["date"] is DateTime dt ? dt : Convert.ToDateTime(reader["date"]),
                        ProductId = reader["productID"] is int pid ? pid : Convert.ToInt32(reader["productID"]),
                        ProductName = reader["productName"]?.ToString(),
                        Quantity = reader["quantity"] is int q ? q : Convert.ToInt32(reader["quantity"]),
                        TotalPrice = reader["totalPrice"] is decimal tp ? tp : Convert.ToDecimal(reader["totalPrice"])
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get orders: {ex.Message}");
            }

            return orders;
        }

        /// <summary>
        /// Gets orders filtered by date range
        /// </summary>
        public List<OrderRecord> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            var orders = new List<OrderRecord>();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT o.orderID,
                           o.cashierID,
                           u.firstName + ' ' + u.lastName AS cashierName,
                           o.date,
                           o.productID,
                           p.productName,
                           o.quantity,
                           o.totalPrice
                    FROM dbo.order_t o
                    LEFT JOIN dbo.users_t u ON o.cashierID = u.userID
                    LEFT JOIN dbo.products_t p ON o.productID = p.productID
                    WHERE o.date >= @startDate AND o.date <= @endDate
                    ORDER BY o.date DESC, o.orderID DESC;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new OrderRecord
                    {
                        OrderId = reader["orderID"] is int oid ? oid : Convert.ToInt32(reader["orderID"]),
                        CashierId = reader["cashierID"] is int cid ? cid : Convert.ToInt32(reader["cashierID"]),
                        CashierName = reader["cashierName"]?.ToString(),
                        Date = reader["date"] is DateTime dt ? dt : Convert.ToDateTime(reader["date"]),
                        ProductId = reader["productID"] is int pid ? pid : Convert.ToInt32(reader["productID"]),
                        ProductName = reader["productName"]?.ToString(),
                        Quantity = reader["quantity"] is int q ? q : Convert.ToInt32(reader["quantity"]),
                        TotalPrice = reader["totalPrice"] is decimal tp ? tp : Convert.ToDecimal(reader["totalPrice"])
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get orders by date range: {ex.Message}");
            }

            return orders;
        }

        /// <summary>
        /// Gets total sales amount for a date range
        /// </summary>
        public decimal GetTotalSales(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT SUM(totalPrice) FROM dbo.order_t";
                var parameters = new List<SqlParameter>();

                if (startDate.HasValue && endDate.HasValue)
                {
                    sql += " WHERE date >= @startDate AND date <= @endDate";
                    parameters.Add(new SqlParameter("@startDate", startDate.Value));
                    parameters.Add(new SqlParameter("@endDate", endDate.Value));
                }

                using var cmd = new SqlCommand(sql, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                object result = cmd.ExecuteScalar();
                return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get total sales: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Gets total sales amount for a specific cashier/user (optional date range)
        /// </summary>
        public decimal GetTotalSalesForUser(int cashierId, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT SUM(totalPrice) FROM dbo.order_t WHERE cashierID = @cashierID";
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@cashierID", cashierId)
                };

                if (startDate.HasValue && endDate.HasValue)
                {
                    sql += " AND date >= @startDate AND date <= @endDate";
                    parameters.Add(new SqlParameter("@startDate", startDate.Value));
                    parameters.Add(new SqlParameter("@endDate", endDate.Value));
                }

                using var cmd = new SqlCommand(sql, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                object result = cmd.ExecuteScalar();
                return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get total sales for user: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Gets count of orders for a date range
        /// </summary>
        public int GetOrderCount(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT COUNT(DISTINCT orderID) FROM dbo.order_t";
                var parameters = new List<SqlParameter>();

                if (startDate.HasValue && endDate.HasValue)
                {
                    sql += " WHERE date >= @startDate AND date <= @endDate";
                    parameters.Add(new SqlParameter("@startDate", startDate.Value));
                    parameters.Add(new SqlParameter("@endDate", endDate.Value));
                }

                using var cmd = new SqlCommand(sql, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                object result = cmd.ExecuteScalar();
                return result != DBNull.Value && result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get order count: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Gets count of orders for a specific cashier/user (optional date range)
        /// </summary>
        public int GetOrderCountForUser(int cashierId, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT COUNT(DISTINCT orderID) FROM dbo.order_t WHERE cashierID = @cashierID";
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@cashierID", cashierId)
                };

                if (startDate.HasValue && endDate.HasValue)
                {
                    sql += " AND date >= @startDate AND date <= @endDate";
                    parameters.Add(new SqlParameter("@startDate", startDate.Value));
                    parameters.Add(new SqlParameter("@endDate", endDate.Value));
                }

                using var cmd = new SqlCommand(sql, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                object result = cmd.ExecuteScalar();
                return result != DBNull.Value && result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get order count for user: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Gets popular products based on order quantities
        /// </summary>
        public List<PopularProduct> GetPopularProducts(int topCount = 10)
        {
            var products = new List<PopularProduct>();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT TOP (@topCount)
                           p.productID,
                           p.productName,
                           SUM(o.quantity) AS totalQuantitySold,
                           SUM(o.totalPrice) AS totalSales
                    FROM dbo.order_t o
                    INNER JOIN dbo.products_t p ON o.productID = p.productID
                    GROUP BY p.productID, p.productName
                    ORDER BY SUM(o.quantity) DESC;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@topCount", topCount);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new PopularProduct
                    {
                        ProductId = reader["productID"] is int pid ? pid : Convert.ToInt32(reader["productID"]),
                        ProductName = reader["productName"]?.ToString() ?? "Unknown",
                        TotalQuantitySold = reader["totalQuantitySold"] is int qty ? qty : Convert.ToInt32(reader["totalQuantitySold"]),
                        TotalSales = reader["totalSales"] is decimal sales ? sales : Convert.ToDecimal(reader["totalSales"])
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to get popular products: {ex.Message}");
            }

            return products;
        }

        public class PopularProduct
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; } = string.Empty;
            public int TotalQuantitySold { get; set; }
            public decimal TotalSales { get; set; }
        }
    }
}

