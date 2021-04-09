use Dominion

insert into Users(UserID, UserName, FirstName, LastName, OrgID, AuthLevel)
values			(1, 'ERWatson' ,'Evin', 'Watson', 100, 1),
				(2, 'BSundell','Brandon', 'Sundell', 100, 1),
				(3, 'JRhoads','Johnathan', 'Rhoads', 200, 1),
				(4, 'DaDubose','Darius', 'Dubose', 300, 2),
				(5, 'ChrisKing','Christian', 'King', 432, 3);

select * from Users

insert into StockList(StockID, ItemName, ImagePath, OrgID)
values					(1 , 'Hammer', 'Not Implemented', 4),
						(2 , 'Wrench', 'Not Implemented', 7),
						(3 , 'Tire Lever', 'Not Implemented', 23),
						(4 , 'Tanker Bar', 'Not Implemented', 65),
						(5 , 'Keyboard', 'Not Implemented', 12)

select * from StockList

insert into Requests(ReqID, UserID, OrgID, StockID, ReqDesc, ReqItems, ReqStatus)
values				(1321 , 3, 7, 2, 'Order wrench', 'Wrench', 'Placed'),
					(4322 , 4, 34, 3, 'Order Tire lever', 'Tire Lever', 'Shipped'),
					(2342 , 1, 23, 5, 'Order Keyboard', 'Keyboard', 'Delivered')

select * from Requests

insert into Inventory(StockID, ItemName, Quantity, OrgID)
values				(3, 'Tire lever', 5, 3),
					(1, 'Hammer', 7, 1),
					(4, 'Tanker Bar', 2, 8),
					(2, 'Wrench', 8, 2)

select * from Inventory