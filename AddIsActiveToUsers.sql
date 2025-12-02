-- One-time migration script to add soft-delete support to users_t
-- Run this against your existing INV.MDF database.

IF COL_LENGTH('dbo.users_t', 'isActive') IS NULL
BEGIN
    ALTER TABLE dbo.users_t
        ADD isActive BIT NOT NULL CONSTRAINT DF_users_t_isActive DEFAULT (1);
END
GO


