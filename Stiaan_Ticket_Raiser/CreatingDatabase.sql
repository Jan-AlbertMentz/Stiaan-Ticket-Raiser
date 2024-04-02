CREATE DATABASE StiaanAccountingDB;
GO

USE StiaanAccountingDB;
GO
CREATE TABLE Clients (
	CID	varchar(6) Primary Key,-- Client ID Primary Key
	CName varchar(6),--Client Name
	Surname varchar(MAX),--Client Surname
	Number varchar(MAX)--Client Phone Number
);

CREATE TABLE Accounting (
	CID varchar(6),--Client Num Foreign Key
	Account_Num varchar(6),--Account Num Primary Key
	TDescription varchar(Max),--Discriptuon of what was done
	FOREIGN KEY (CID) REFERENCES Clients (CID),
	PRIMARY KEY (Account_Num)
);

CREATE TABLE Taxing (
	CID varchar(6),--Client Num Foreign Key
	Account_Num varchar(6),--account num Primary Key
	TDescription varchar(Max),--description of work done or the business
	FOREIGN KEY (CID) REFERENCES Clients (CID),
	PRIMARY KEY (Account_Num)
);

CREATE TABLE Inviocing (
	Invoice_Num varchar(6),--Invoice num Primary Key
	CID varchar(6),--client num coming from client
	Invoice_Amount varchar(MAX),--amount of invoice
	Invoice_Date DATE,--date of invoice 
	Work_Done varchar(Max),--type of account
	FOREIGN KEY (CID) REFERENCES Clients (CID)
);