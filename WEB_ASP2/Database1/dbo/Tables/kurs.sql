CREATE TABLE [dbo].[kurs] (
    [Id]    INT           NOT NULL,
    [Name]  VARCHAR (50)  NOT NULL,
    [Description]  VARCHAR (255) NOT NULL,
    [Photo] IMAGE         NULL,
    [Cost] REAL NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

