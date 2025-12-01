using System.Drawing;

namespace FortuneInventory
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image? ProductImage { get; set; }

        public decimal TotalPrice => Price * Quantity;
    }
}

