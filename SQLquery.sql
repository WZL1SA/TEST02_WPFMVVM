CREATE TABLE [dbo].[Customers] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Address]  VARCHAR (50) NULL,
    [Email]    VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
