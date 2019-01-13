CREATE TABLE [dbo].[kurs] (
    [Id]    INT           NOT NULL,
    [Name]  VARCHAR (50)  NOT NULL,
    [Desc]  VARCHAR (255) NOT NULL,
    [Photo] IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

