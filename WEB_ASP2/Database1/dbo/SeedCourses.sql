INSERT INTO kurs (Id, Name, Description, Photo, Cost)
SELECT 0, 'Java od podstaw', 'Kurs javy dla każdego, tanio i szybko', 
BulkColumn, 11.50
FROM Openrowset(Bulk 'C:\Users\Master\source\repos\WEB_ASP2\WEB_ASP2\MediaFiles\java.png', Single_Blob) as img;

INSERT INTO kurs (Id, Name, Description, Photo, Cost)
VALUES (1, 'C# od podstaw', 'Z nami ASP.NET nigdy nie będzie dla Ciebie skomplikowane', null, 9.12);

INSERT INTO kurs (Id, Name, Description, Photo, Cost)
VALUES (2, 'Javascript od podstaw', 'Jak szybko stworzyć cud web devu? przejdź nasz kurs i się dowiedz!', null, 7.30);

INSERT INTO kurs (Id, Name, Description, Photo, Cost)
VALUES (3, 'Python od podstaw', 'Prawdziwy data scientist? tylko po tym kursie!', null, 5.50);