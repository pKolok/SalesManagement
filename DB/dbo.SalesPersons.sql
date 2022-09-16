CREATE TABLE [dbo].[SalesPersons] (
    [ID]   INT             IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (150)   NOT NULL,
    [Fees] DECIMAL (18, 3) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

