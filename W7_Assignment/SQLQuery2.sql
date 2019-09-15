CREATE TABLE [dbo].[Hall] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Hall_No]   NVARCHAR (MAX) NOT NULL,
    [Hall_Name] NVARCHAR (MAX) NOT NULL,
    [Fee]       NVARCHAR (MAX) NOT NULL,
    [Open_Hour] NVARCHAR (MAX) NOT NULL,
    [Capacity]  NVARCHAR (MAX) NOT NULL,
	[UserId]     VARCHAR(max) NOT NULL,
	PRIMARY KEY (Id)
);

GO