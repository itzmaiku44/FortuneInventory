-- Create order_t table for sales history
-- This table stores order records after successful payment

IF OBJECT_ID(N'dbo.order_t', N'U') IS NOT NULL
BEGIN
    -- Table already exists, you may want to drop and recreate if needed
    -- DROP TABLE dbo.order_t;
    PRINT 'Table order_t already exists.';
END
ELSE
BEGIN
    CREATE TABLE dbo.order_t
    (
        orderID    INT IDENTITY(1,1) NOT NULL,
        cashierID  INT               NOT NULL,
        date       DATETIME2(0)      NOT NULL,
        productID  INT               NOT NULL,
        quantity   INT               NOT NULL,
        totalPrice DECIMAL(18,2)     NOT NULL,
        CONSTRAINT PK_order_t PRIMARY KEY CLUSTERED (orderID),
        CONSTRAINT FK_order_t_users FOREIGN KEY (cashierID)
            REFERENCES dbo.users_t(userID),
        CONSTRAINT FK_order_t_products FOREIGN KEY (productID)
            REFERENCES dbo.products_t(productID)
    );
    
    PRINT 'Table order_t created successfully.';
END
GO

