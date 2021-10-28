USE [dbUdemyTest_ 85323e9b08b44737ad6376eb8fdfab94]
SELECT * FROM [User]

INSERT INTO [User] VALUES (NEWID(), GETDATE(), NULL, 'ADMIN', 'admin@gmail.com')