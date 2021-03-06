

CREATE TABLE [Customer] (
    [CustomerID] uniqueidentifier NOT NULL,
    [Name] varchar(50) NOT NULL,
    [Email] varchar(50) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY ([CustomerID])
);

GO

CREATE TABLE [Address] (
    [AddressID] uniqueidentifier NOT NULL,
    [CustomerID] uniqueidentifier NOT NULL,
    [Street] varchar(50) NOT NULL,
    [Number] int NOT NULL,
    [Zipcode] varchar(9) NOT NULL,
    [City] varchar(50) NOT NULL,
    [State] varchar(25) NOT NULL,
    [Country] varchar(50) NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY ([AddressID]),
    CONSTRAINT [FK_Address_Customer_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [Customer] ([CustomerID]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Phone] (
    [PhoneID] uniqueidentifier NOT NULL,
    [CustomerID] uniqueidentifier NOT NULL,
    [Number] int NOT NULL,
    [TypePhone] int NOT NULL,
    CONSTRAINT [PK_Phone] PRIMARY KEY ([PhoneID]),
    CONSTRAINT [FK_Phone_Customer_PhoneID] FOREIGN KEY ([PhoneID]) REFERENCES [Customer] ([CustomerID]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Address_CustomerID] ON [Address] ([CustomerID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210306141457_TesteMigration', N'3.1.0');

GO

