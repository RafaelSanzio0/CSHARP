USE [UdemyDB]
SELECT * FROM [User]

INSERT INTO [User] VALUES (NEWID(), GETDATE(), NULL, 'ADMIN', 'admin@gmail.com')