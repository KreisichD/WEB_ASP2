CREATE TABLE [dbo].[uzytkownik] (
    [Id]          INT          NOT NULL,
    [FirstName]   VARCHAR (50) NOT NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [DateOfBirth] DATE         NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

