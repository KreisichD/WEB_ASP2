CREATE TABLE [dbo].[kurs_uzytkownik] (
    [IdKursu]       INT NOT NULL,
    [IdUzytkownika] INT NOT NULL,
    CONSTRAINT [PK_kurs_uzytkownik] PRIMARY KEY CLUSTERED ([IdKursu] ASC, [IdUzytkownika] ASC)
);

