drop database if exists Dominion
create database Dominion
use Dominion

drop table if exists Users
create table Users
(
	UserID int identity,
	UserName varchar(15) primary key,
	FirstName nvarchar(30),
	LastName nvarchar(30),
	Organization nvarchar,
	OrgID int,
	AuthLevel int
)

drop table if exists Requests
create table Requests
(
	ReqID int identity,
	ReqDesc nvarchar(100),
	ReqItems nvarchar(500),
	ReqStatus nvarchar(100)
)

drop table if exists Inventory
create table Inventory
(
	StockID int identity,
	ItemName nvarchar(100),
	Quantity int
)

drop table if exists StockList
create table StockList
(
	StockID int identity,
	ItemName nvarchar(100),
	ImagePath nvarchar(500)
)