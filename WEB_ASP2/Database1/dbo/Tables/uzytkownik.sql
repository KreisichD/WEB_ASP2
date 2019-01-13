CREATE TABLE [dbo].[uzytkownik] (
    [Id]          INT          NOT NULL,
    [FirstName]   VARCHAR (50) NOT NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [DateOfBirth] DATE         NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Phone] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

