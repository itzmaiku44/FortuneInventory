 /*
    Microsoft SQL Server build-out for original MySQL `posdb` schema.
    - Drops any existing database named posdb, then recreates it
    - Recreates tables with SQL Server data types and identity columns
    - Applies keys, constraints, and seed data
 */

IF DB_ID(N'posdb') IS NOT NULL
BEGIN
    ALTER DATABASE posdb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE posdb;
END
GO

CREATE DATABASE posdb;
GO

USE posdb;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Ensure predictable clean state
IF OBJECT_ID(N'dbo.loginhistory_t', N'U') IS NOT NULL DROP TABLE dbo.loginhistory_t;
IF OBJECT_ID(N'dbo.users_t', N'U') IS NOT NULL DROP TABLE dbo.users_t;
IF OBJECT_ID(N'dbo.products_t', N'U') IS NOT NULL DROP TABLE dbo.products_t;
IF OBJECT_ID(N'dbo.categories_t', N'U') IS NOT NULL DROP TABLE dbo.categories_t;
IF OBJECT_ID(N'dbo.roles_t', N'U') IS NOT NULL DROP TABLE dbo.roles_t;
GO

CREATE TABLE dbo.categories_t
(
    categoryID   INT IDENTITY(1,1) NOT NULL,
    categoryName NVARCHAR(50)      NOT NULL,
    CONSTRAINT PK_categories_t PRIMARY KEY CLUSTERED (categoryID),
    CONSTRAINT UQ_categories_t_categoryName UNIQUE (categoryName)
);
GO

CREATE TABLE dbo.roles_t
(
    roleID   INT IDENTITY(1,1) NOT NULL,
    roleName NVARCHAR(20)      NOT NULL,
    CONSTRAINT PK_roles_t PRIMARY KEY CLUSTERED (roleID)
);
GO

CREATE TABLE dbo.products_t
(
    productID   INT IDENTITY(1,1) NOT NULL,
    categoryID  INT               NOT NULL,
    price       DECIMAL(18,2)     NOT NULL,
    productName NVARCHAR(255)     NOT NULL,
    discount    INT               NULL,
    quantity    INT               NULL,
    imagePath   NVARCHAR(260)     NULL, -- relative path to file stored under /images
    CONSTRAINT PK_products_t PRIMARY KEY CLUSTERED (productID),
    CONSTRAINT UQ_products_t_productName UNIQUE (productName),
    CONSTRAINT FK_products_t_categories FOREIGN KEY (categoryID)
        REFERENCES dbo.categories_t(categoryID)
);
GO

CREATE TABLE dbo.users_t
(
    userID    INT IDENTITY(1,1) NOT NULL,
    roleID    INT               NOT NULL,
    firstName NVARCHAR(50)      NOT NULL,
    lastName  NVARCHAR(50)      NOT NULL,
    password  NVARCHAR(256)     NOT NULL,
    timeIn    DATETIME2(0)      NULL,
    TimeOut   DATETIME2(0)      NULL,
    CONSTRAINT PK_users_t PRIMARY KEY CLUSTERED (userID),
    CONSTRAINT FK_users_t_roles FOREIGN KEY (roleID) REFERENCES dbo.roles_t(roleID)
);
GO

CREATE TABLE dbo.loginhistory_t
(
    logID   INT IDENTITY(1,1) NOT NULL,
    TimeIn  DATE              NULL,
    TimeOut DATE              NULL,
    UserID  INT               NOT NULL,
    CONSTRAINT PK_loginhistory_t PRIMARY KEY CLUSTERED (logID),
    CONSTRAINT FK_loginhistory_t_users FOREIGN KEY (UserID) REFERENCES dbo.users_t(userID)
);
GO

-- Seed data ---------------------------------------------------------------
SET IDENTITY_INSERT dbo.categories_t ON;
INSERT INTO dbo.categories_t (categoryID, categoryName) VALUES
(1, N'Apparel'),
(2, N'Appliances'),
(3, N'Electronics');
SET IDENTITY_INSERT dbo.categories_t OFF;
GO

SET IDENTITY_INSERT dbo.roles_t ON;
INSERT INTO dbo.roles_t (roleID, roleName) VALUES
(1, N'Admin'),
(2, N'Staff');
SET IDENTITY_INSERT dbo.roles_t OFF;
GO

SET IDENTITY_INSERT dbo.users_t ON;
INSERT INTO dbo.users_t (userID, roleID, firstName, lastName, password, timeIn, TimeOut) VALUES
(1, 1, N'Admin', N'Admin', N'123123', NULL, NULL),
(2, 2, N'Staff',  N'Staff',  N'123123', NULL, NULL);
SET IDENTITY_INSERT dbo.users_t OFF;
GO

-- The remaining tables (products_t, loginhistory_t) intentionally start empty.
-- Add data imports or ETL steps here if you have CSV/seed data available.
