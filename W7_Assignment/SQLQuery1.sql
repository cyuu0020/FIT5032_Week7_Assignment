CREATE TABLE [dbo].[UserInfor] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NULL,
    [LastName]   VARCHAR (50) NULL, 
    [Phone]      VARCHAR (30) NULL, 
	[UserId]     VARCHAR(max) NOT NULL,
	PRIMARY KEY (Id)
);
GO 
