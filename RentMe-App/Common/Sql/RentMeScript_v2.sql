-- =========================================
-- Create Database
-- =========================================

-- Drop the database if it already exists
USE master
GO

IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'cs6232-g5'
)
DROP DATABASE [cs6232-g5]
GO

CREATE DATABASE [cs6232-g5]
GO

USE [cs6232-g5];
GO

-- =========================================
-- If table exists, drop it
-- =========================================
IF OBJECT_ID('dbo.states', 'U') IS NOT NULL
  DROP TABLE dbo.states
GO

IF OBJECT_ID('dbo.fine', 'U') IS NOT NULL
  DROP TABLE dbo.fine
GO

IF OBJECT_ID('dbo.furnitureRented', 'U') IS NOT NULL
  DROP TABLE dbo.furnitureRented
GO

IF OBJECT_ID('dbo.furnitureReturned', 'U') IS NOT NULL
  DROP TABLE dbo.furnitureReturned
GO

IF OBJECT_ID('dbo.regularEmployee', 'U') IS NOT NULL
  DROP TABLE dbo.regularEmployee
GO

IF OBJECT_ID('dbo.admin', 'U') IS NOT NULL
  DROP TABLE dbo.[admin]
GO

IF OBJECT_ID('dbo.login', 'U') IS NOT NULL
  DROP TABLE dbo.[login]
GO

IF OBJECT_ID('dbo.employee', 'U') IS NOT NULL
  DROP TABLE dbo.employee
GO

IF OBJECT_ID('dbo.storeMember', 'U') IS NOT NULL
  DROP TABLE dbo.storeMember
GO

IF OBJECT_ID('dbo.furniture', 'U') IS NOT NULL
  DROP TABLE dbo.furniture
GO

IF OBJECT_ID('dbo.style', 'U') IS NOT NULL
  DROP TABLE dbo.style
GO

IF OBJECT_ID('dbo.category', 'U') IS NOT NULL
  DROP TABLE dbo.category
GO

IF OBJECT_ID('dbo.returnTransaction', 'U') IS NOT NULL
  DROP TABLE dbo.returnTransaction
GO

IF OBJECT_ID('dbo.rentalTransaction', 'U') IS NOT NULL
  DROP TABLE dbo.rentalTransaction
GO

-- =========================================
-- Add tables
-- =========================================

-- States
CREATE TABLE [dbo].[states]
(
	[name] VARCHAR(45) NOT NULL,
    PRIMARY KEY ([name])
)
GO

-- Employee (all)
CREATE TABLE [dbo].[employee]
(
	[employeeID] int NOT NULL IDENTITY(1,1), 
	[birthDate] DATE NOT NULL, 
	[fname] VARCHAR(45) NOT NULL,
	[lname] VARCHAR(45) NOT NULL,
	[phone] VARCHAR(45) NOT NULL,
	[address1] VARCHAR(45) NOT NULL,
	[address2] VARCHAR(45) NOT NULL,
	[city] VARCHAR(45) NOT NULL,
	[state] VARCHAR(45) NOT NULL FOREIGN KEY REFERENCES [dbo].[states](name),
	[zip] VARCHAR(20) NOT NULL,
	[active] BIT NOT NULL,
	[sex] VARCHAR(10) NOT NULL,
    PRIMARY KEY ([employeeID])
)
GO

-- Login
CREATE TABLE [dbo].[login]
(
	[employeeID] int NOT NULL FOREIGN KEY ([employeeID]) REFERENCES [dbo].[employee](employeeID), 
	[username] VARCHAR(45) NOT NULL, 
	[password] VARCHAR(100) NOT NULL,
	PRIMARY KEY ([employeeID])
)
GO

-- Admin
CREATE TABLE [dbo].[admin]
(
	[employeeID] int NOT NULL FOREIGN KEY ([employeeID]) REFERENCES [dbo].[employee](employeeID),
	PRIMARY KEY ([employeeID])
)
GO

-- Regular Employee
CREATE TABLE [dbo].[regularEmployee]
(
	[employeeID] int NOT NULL FOREIGN KEY ([employeeID]) REFERENCES [dbo].[employee](employeeID), 
	PRIMARY KEY ([employeeID])
)
GO

-- Store Member
CREATE TABLE [dbo].[storeMember]
(
	[memberID] int NOT NULL IDENTITY(1,1), 
	[birthDate] DATE NOT NULL, 
	[fname] VARCHAR(45) NOT NULL,
	[lname] VARCHAR(45) NOT NULL,
	[phone] VARCHAR(45) NOT NULL,
	[address1] VARCHAR(45) NOT NULL,
	[address2] VARCHAR(45),
	[city] VARCHAR(45) NOT NULL,
	[state] VARCHAR(45) NOT NULL FOREIGN KEY REFERENCES [dbo].[states](name),
	[zip] VARCHAR(20) NOT NULL,
	[active] BIT NOT NULL,
    PRIMARY KEY ([memberID])
)
GO

-- Style
CREATE TABLE [dbo].[style]
(
	[name] VARCHAR(45) NOT NULL,
	PRIMARY KEY ([name])
)
GO

-- Category
CREATE TABLE [dbo].[category]
(
	[name] VARCHAR(45) NOT NULL,
	PRIMARY KEY ([name])
)
GO

-- Furniture
CREATE TABLE [dbo].[furniture]
(
	[furnitureID] int NOT NULL IDENTITY(1,1),  
	[name] VARCHAR(100) NOT NULL,
	[description] VARCHAR(1500) NOT NULL,
	[daily_rental_rate] DECIMAL(5,2) NOT NULL,
	[daily_fine_rate] DECIMAL(5,2) NOT NULL,
	[style_name] VARCHAR(45) NOT NULL FOREIGN KEY REFERENCES [dbo].[style](name),
	[category_name] VARCHAR(45) NOT NULL FOREIGN KEY REFERENCES [dbo].[category](name),
	[image_small_url] VARCHAR(200),
  [image_large_url] VARCHAR(200),
    PRIMARY KEY ([furnitureID])
)
GO

-- Rental Transactions
CREATE TABLE [dbo].[rentalTransaction]
(
	[transactionID] int NOT NULL,  
	[employeeID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[employee](employeeID),
	[memberID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[storeMember](memberID),
	[transaction_date] DATETIME,
	[return_date] DATE,
    PRIMARY KEY ([transactionID])
)
GO

-- Return Transactions
CREATE TABLE [dbo].[returnTransaction]
(
	[transactionID] int NOT NULL,  
	[employeeID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[employee](employeeID) ON DELETE CASCADE ON UPDATE CASCADE,
	[return_date] DATE,
    PRIMARY KEY ([transactionID])
)
GO

-- Furniture Rented
CREATE TABLE [dbo].[furnitureRented]
(
	[furnitureID] int NOT NULL,  
	[rental_transactionID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[rentalTransaction](transactionID),
	[quantity] int,
    PRIMARY KEY ([furnitureID], [rental_transactionID])
)
GO

-- Furniture Returned
CREATE TABLE [dbo].[furnitureReturned]
(
	[furnitureID] int NOT NULL,  
	[return_transactionID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[returnTransaction](transactionID),
	[rental_transactionID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[rentalTransaction](transactionID),
	[quantity] int,
	PRIMARY KEY([furnitureID], [return_transactionID], [rental_transactionID]),
	CONSTRAINT fk_rented_furniture FOREIGN KEY([furnitureID], [rental_transactionID]) REFERENCES [dbo].[furnitureRented](furnitureID, rental_transactionID)
)
GO

-- Fine
CREATE TABLE [dbo].[fine]
(
	[memberID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[storeMember](memberID),  
	[furnitureID] int NOT NULL,
	[rental_transactionID] int NOT NULL,
	[late_fee] DECIMAL(10,2),
	[days_late] int,
    PRIMARY KEY ([furnitureID]),
	CONSTRAINT fk_fine_rented_furniture FOREIGN KEY([furnitureID], [rental_transactionID]) REFERENCES [dbo].[furnitureRented](furnitureID, rental_transactionID)
)
GO

-- =========================================
-- Insert data
-- =========================================

INSERT INTO [states] (name)
VALUES
    ('AL')
    , ('AK')
    , ('AZ')
    , ('AR')
    , ('AS')
    , ('CA')
    , ('CO')
    , ('CT')
    , ('DE')
    , ('DC')
    , ('FL')
    , ('GA')
    , ('GU')
    , ('HI')
    , ('ID')
    , ('IL')
    , ('IN')
    , ('IA')
    , ('KS')
    , ('KY')
    , ('LA')
    , ('ME')
    , ('MD')
    , ('MA')
    , ('MI')
    , ('MN')
    , ('MS')
    , ('MO')
    , ('MT')
    , ('NE')
    , ('NV')
    , ('NH')
    , ('NJ')
    , ('NM')
    , ('NY')
    , ('NC')
    , ('ND')
    , ('CM')
    , ('OH')
    , ('OK')
    , ('OR')
    , ('PA')
    , ('PR')
    , ('RI')
    , ('SC')
    , ('SD')
    , ('TN')
    , ('TX')
    , ('TT')
    , ('UT')
    , ('VT')
    , ('VA')
    , ('VI')
    , ('WA')
    , ('WV')
    , ('WI')
    , ('WY')
    ;
GO

INSERT INTO [storeMember] (birthDate,fname,lname,phone,address1,address2,city,state,zip,active)
VALUES
    ('1985-02-23','Juliet','Dominguez','6824285665','363 Sagittis Av.','Ap #920','Springdale','AR','73467',1)
    , ('1963-06-20','Vernon','Maldonado','6587191360','9983 Lobortis Road','Ap #869','Bellevue','WA','2397',1)
    , ('2001-09-23','Lyle','Paul','4586813755','2774 Sem Street',NULL,'Saint Paul','MN','20287',0)
    , ('1977-10-31','Dominique','Irwin','1525960104','1378 Cras St.','Ap #511','Great Falls','MT','5257',0)
    , ('1962-05-04','Rosalyn','Norman','3843327737','7172 Orci Rd.','Ap #169','Kapolei','HI','33411',0)
    , ('1992-03-31','Liberty','England','6528883334','5139 Ultrices Av.',NULL,'Springdale','AR','72424',1)
    , ('1962-07-11','Yuri','Stokes','6564829694','8823 Diam St.',NULL,'Huntsville','AL','0509 RW',1)
    , ('1963-10-28','Sade','Sharp','4382031910','8422 Ridiculus Av.','Ap #573','Fort Worth','TX','813739',0)
    , ('1998-04-22','Andrew','Estrada','2133576556','3532 Massa. Rd.','Ap #949','Lakewood','CO','2652',0)
    , ('1988-05-04','Burton','Delaney','7474272489','9296 Scelerisque Rd.','Ap #789','Gary','IN','3928',1)
    , ('1976-12-31','Boris','Hunter','6964260567','7940 Vel St.',NULL,'South Burlington','VT','780138',0)
    , ('1993-09-29','Sigourney','Carver','3174412318','642 Sed, Rd.','Ap #685','West Valley City','UT','78491',0)
    , ('1966-08-14','Vaughan','Watts','1913831067','3371 Nulla. Rd.','Ap #343','San Jose','CA','7120',1)
    , ('1999-05-29','Graiden','Middleton','8448349371','287 Duis St.',NULL,'Missoula','MT','p7W 4C8',1)
    , ('1977-09-01','Quail','Parker','3469354489','6032 Tristique St.','Ap #470','Idaho Falls','ID','656594',0)
    , ('1995-04-08','Jenna','Davidson','3398468141','3964 Suspendisse Rd.','Ap #800','Norman','OK','60757-21203',1)
    , ('1999-12-15','Guy','O''donnell','6436593141','5560 Amet Road','Ap #523','Cleveland','OH','5711',0)
    , ('1974-02-09','Jonas','Reilly','7568582254','3171 Fusce Road','Ap #467','Gresham','OR','381752',1)
    , ('1975-10-26','Silas','Gregory','6664464033','2932 Pede St.','Ap #772','Savannah','GA','55106',1)
    , ('1998-03-24','Ora','Whitaker','4232651102','8985 Ultrices. Road',NULL,'Olathe','KS','6806',0)
    ;
GO

INSERT INTO [style] (name)
VALUES
    ('Disney')
    , ('Star Wars')
    , ('Contemporary')
    , ('Transitional')
    , ('Cottage')
    , ('Modern')
    , ('Traditional')
    , ('Classic')
    , ('Chic')
    , ('Rustic')
    , ('Industrial')
    ;
GO

INSERT INTO [category] (name)
VALUES
    ('Kids - Nursery')
    , ('Kids - Bed')
    , ('Kids - Desk')
    , ('Kids - Bedroom')
    , ('Kids - Nursery Dresser')
    , ('Kids - Dresser')
    , ('Kids - Accessory')
    , ('Kids - Nursery Bed')
    , ('Kids - Nightstand')
    , ('Kids - Chair')
    , ('Kids - Vanity')
    , ('Bedroom')
    , ('Bed')
    , ('Chair')
    , ('Dining Room')
    , ('Dining Table')
    , ('Lamp')
    , ('Living Room')
    , ('Ottoman')
    , ('Patio')
    , ('Rug')
    , ('Sectional')
    , ('Sofa')
    ;
GO

INSERT INTO [employee] (birthDate,fname,lname,phone,address1,address2,city,state,zip,active,sex)
VALUES
    ('1945-01-27','Connie','Tiley','4044564561','22 Saint John Road','','Alamo','GA','30411',1,'female')
    , ('1975-07-18','Brent','Tradon','4044899821','21 Woodfire Court','','Suwanee','GA','30024',1,'male')
    , ('1990-06-11','Kendra','Donald','4049856541','26 Sweetwater Drive','','Cataula','GA','31804',1,'female')
    , ('1986-05-25','Tobey','Reynolds','4048794563','13 Carters Drive','','Hartwell','GA','30643',1,'male')
    , ('1987-04-22','Lucy','Leonard','4045643211','14 Patterson Drive','','Franklin','GA','30213',1,'female')
    , ('1988-02-15','Larry','Post','4047893201','16 Shadowrock Drive','Apt 56','Marietta','GA','30062',1,'male')
    , ('1989-01-11','Doris','Littlefoot','4049850303','29 Meadows Road','Apt 5','Wadley','GA','30433',1,'female')
    , ('1991-08-08','Kathryn','Cornwall','4045465656','23 Frederick Drive','','Augusta','GA','30909',1,'female')
    , ('1992-11-02','Daphne','Moon','4049871212','3 Aimwell Road','','Vidalia','GA','30434',1,'female')
    , ('1988-12-24','Justin','Bean','4049876541','26 Meeting House Mtn Road','','Clayton','GA','30525',1,'male')
    , ('1986-07-24','Kelly','Bayer','4049873210','33 Monroe Street','','Midway','GA','31320',1,'female')
    ;
GO

INSERT INTO [admin] (employeeID)
VALUES
    (4)
    ;
GO

INSERT INTO [regularEmployee] (employeeID)
VALUES
    (1)
    , (2)
    , (3)
    , (5)
    , (6)
    , (7)
    , (8)
    , (9)
    , (10)
    , (11)
    ;
GO

INSERT INTO [login] (employeeID,username,password)
VALUES
    (1,'cTiley','0xE66860546F18CDBBCD86B35E18B525BFFC67F772C650CEDFE3FF7A0026FA1DEE')
    , (2,'bTradon','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (3,'kDonald','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (4,'tReynolds','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (5,'lLeonard','0xE66860546F18CDBBCD86B35E18B525BFFC67F772C650CEDFE3FF7A0026FA1DEE')
    , (6,'lPost','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (7,'dLittlefoot','0xE66860546F18CDBBCD86B35E18B525BFFC67F772C650CEDFE3FF7A0026FA1DEE')
    , (8,'kCornwall','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (9,'dMoon','0x6E303D89F7AA3DB12FD351C4BD6C5171371A99F0D9602D1C060AA36D5826D936')
    , (10,'jBean','0xE66860546F18CDBBCD86B35E18B525BFFC67F772C650CEDFE3FF7A0026FA1DEE')
    , (11,'kBayer','0xE66860546F18CDBBCD86B35E18B525BFFC67F772C650CEDFE3FF7A0026FA1DEE')
    ;
GO