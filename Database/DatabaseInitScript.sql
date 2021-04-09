drop database if exists Dominion
create database Dominion
use Dominion

drop table if exists Users
create table Users
(
	UserID int primary key,
	UserName varchar(15),
	FirstName nvarchar(30),
	LastName nvarchar(30),
	OrgID int,
	AuthLevel int
)

drop table if exists StockList
create table StockList
(
	StockID int primary key,
	ItemName nvarchar(100),
	ImagePath nvarchar(500),
	OrgID int
)

drop table if exists Requests
create table Requests
(
	ReqID int primary key,
	UserID int foreign key references Users(UserID),
	OrgID int,
	StockID int foreign key references StockList(StockID),
	ReqDesc nvarchar(100),
	ReqItems nvarchar(500),
	ReqStatus nvarchar(100)
)



drop table if exists Inventory
create table Inventory
(
	StockID int foreign key references StockList(StockID),
	ItemName nvarchar(100),
	Quantity int,
	OrgID int,
)

