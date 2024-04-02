CREATE DATABASE StiaanAccountingDB;
GO

USE StiaanAccountingDB;
GO
CREATE TABLE Clients (
	CID	varchar(6) PRIMARY KEY,-- Client ID Primary Key
	CName varchar(6),--Client Name
	Surname varchar(MAX),--Client Surname
	Number varchar(MAX),--Client Phone Number
);

CREATE TABLE Invioce (
	CID varchar(6),--client num coming from client
	Invoice_Amount varchar(MAX),--amount of invoice
	Invoice_Date DATE,--date of invoice 
	Work_Done varchar(Max),--type of account
	FOREIGN KEY (CID) REFERENCES Clients (CID)
);

CREATE TABLE NewTicket (
	CID varchar(6),
	TDiscription varchar(MAX),
	OpenDate DATE,
	FOREIGN KEY (CID) REFERENCES Clients (CID),
);

CREATE TABLE InProgress (
	CID varchar(6),
	TDiscription varchar(MAX),
	Invoice_Num varchar(6),
	OpenDate DATE,
	FOREIGN KEY (CID) REFERENCES Clients (CID),
);

CREATE TABLE Closed (
	CID varchar(6),
	TDiscription varchar(MAX),
	Invoice_Num varchar(6),
	OpenDate DATE,
	FOREIGN KEY (CID) REFERENCES Clients (CID),
);
