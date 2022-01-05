CREATE TABLE Authors(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Publishers(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Genres(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Books(
Id int Identity (1,1) PRIMARY KEY,
Title nvarchar(128) NOT NULL,
Pages int NOT NULL,
[Year] DateTime NOT NULL,
Stock int NOT NULL DEFAULT 0 CHECK (Stock >= 0),
Sold int NOT NULL DEFAULT 0 CHECK (Sold >= 0),
Cost Money NOT NULL DEFAULT 0 CHECK (Stock >= 0),
Price Money NOT NULL DEFAULT 0 CHECK (Stock >= 0),
PriceMultiplier float NOT NULL DEFAULT 1 CHECK (PriceMultiplier BETWEEN 0 AND 1),
PreviousBookId int NULL,
AuthorId int NOT NULL FOREIGN KEY REFERENCES Authors(ID),
PublisherId int NOT NULL FOREIGN KEY REFERENCES Publishers(ID),
GenreId int NOT NULL FOREIGN KEY REFERENCES Genres(ID)
);

CREATE TABLE Sales(
Id int Identity (1,1) PRIMARY KEY,
BookId int NOT NULL FOREIGN KEY REFERENCES Books(ID),
SaleDate Date NOT NULL DEFAULT GETDATE()
);

INSERT INTO Authors([Name])
VALUES ('J. K. Rowling'), ('Tolkien')

INSERT INTO Genres([Name])
VALUES ('Fantasy')

INSERT INTO Publishers([Name])
VALUES ('Sample Publisher')

INSERT INTO Books([Title], [AuthorId], [GenreId], [PublisherId], [Pages], [Stock], [Cost], [Price], [PriceMultiplier], [Year], [PreviousBookId])
VALUES ('Harry Potter', 1, 1, 1, 500, 100, 20, 30, 1, 2000, null), 
('Lord Of Rings', 2, 1, 1, 1000, 40, 50, 50, 0.9, 1900, null)

SELECT * FROM Books

SELECT B.Title, A.[Name] AS Author, G.[Name] AS Genre, P.[Name] as Publisher, Pages,
Cost, Price AS RegularPrice, PriceMultiplier as Mult,
Price * PriceMultiplier AS CurrentPrice, [Year], PreviousBookId FROM Books AS B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id

IF (SELECT Stock FROM Books WHERE Id = 2) > 0
BEGIN
	INSERT INTO Sales([BookId])
	VALUES (2);
	UPDATE Books SET Stock = Stock - 1
	WHERE Id = 2;
END;

SELECT COUNT(Sales.BookId) [Sold books], Sales.BookId FROM Books
JOIN Sales ON Books.Id = Sales.BookId
GROUP BY Sales.BookId