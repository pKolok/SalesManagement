CREATE TABLE [dbo].[Sales] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [SalesPersonID] INT             NOT NULL,
    [SalesPerson]   VARCHAR (150)   NOT NULL,
    [Amount]        DECIMAL (18, 3) NOT NULL,
    [Date]          DATE            NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Sales_ToSalesPersons] FOREIGN KEY (SalesPersonID) REFERENCES SalesPersons(ID)
);

