CREATE DATABASE MINI_MART
GO
use MINI_MART

CREATE TABLE PRODUCTS(
	Product_ID varchar(100) NOT NULL PRIMARY KEY,
	Product_CategoryID varchar(100) NOT NULL,
	Product_Name nvarchar(500) NOT NULL,
	Product_Price int NOT NULL,
	Product_Status bit NOT NULL,
)

GO

CREATE TABLE CATEGORIES(
	Category_ID varchar(100) NOT NULL PRIMARY KEY,
	Category_Name nvarchar(500) NOT NULL
)	
GO

CREATE TABLE RECEIPTS(
	Receipt_ID varchar(100) NOT NULL PRIMARY KEY,
	Product_ID varchar(100) NOT NULL,
	Product_Amount int NOT NULL,
	Receipt_Date Datetime
)

-- ADD CONSTRAINT AND FOREIGN KEY

ALTER TABLE PRODUCTS
ADD CONSTRAINT FK_PRODUCTS_TO_CATEGORIES
FOREIGN KEY (Product_CategoryID)
REFERENCES CATEGORIES(Category_ID)
ON DELETE CASCADE 

ALTER TABLE RECEIPTS
ADD CONSTRAINT FK_PRODUCTS_TO_RECEIPTS
FOREIGN KEY (Product_ID)
REFERENCES PRODUCTS(Product_ID)
ON DELETE CASCADE

-- INSERT DATA

-- CATEGORIES MOCK DATA
INSERT INTO CATEGORIES(Category_ID,Category_Name)
VALUES ('GD',N'Đồ gia dụng')

INSERT INTO CATEGORIES(Category_ID,Category_Name)
VALUES ('DT',N'Đồ điện tử')

INSERT INTO CATEGORIES(Category_ID,Category_Name)
VALUES ('TP',N'Thực phẩm')

INSERT INTO CATEGORIES(Category_ID,Category_Name)
VALUES ('TT',N'Thời trang')

INSERT INTO CATEGORIES(Category_ID,Category_Name)
VALUES ('PK',N'Phụ kiện')

-- PRODUCTS MOCK DATA


INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('GD001','GD',N'Nồi cơm điện Kangaroo',400000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('GD002','GD',N'Máy lọc không khí',2240000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('GD003','GD',N'Nồi chiên không dầu Philips',2500000,0)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('GD004','GD',N'Bàn ủi Sunhouse',230000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('GD005','GD',N'Máy hút bụi Daiko',2616000,0)

INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('DT001','DT',N'Loa JBL Charge 3',2850000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('DT002','DT',N'Karaoke JBL',4850000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('DT003','DT',N'Lens máy ảnh Canon',1850000,0)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('DT004','DT',N'Iphone 7 plus',16850000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('DT005','DT',N'Máy ghi âm',500000,0)

INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TP001','TP',N'Bột tăng cân',243000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TP002','TP',N'Bột tăng chiều cao',1243000,0)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TP003','TP',N'Thực phẩm tăng cơ',943000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TP004','TP',N'Thực phẩm giảm cân',743000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TP005','TP',N'Bột tăng sức mạnh',2443000,0)

INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TT001','TT',N'Quần bò siêu nhân',12447000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TT002','TT',N'Quần váy cho nam',142447000,0)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TT003','TT',N'Bikini tắm núi lửa',999999,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TT004','TT',N'Quần bơi áp lực cao',1235220,0)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('TT005','TT',N'Vòng tay superman',777777,0)


INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('PK001','PK',N'Gậy tự sướng',550000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('PK002','PK',N'Gậy đập chó',1550000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('PK003','PK',N'Súng bắn nơ ron thần kinh',56550000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('PK004','PK',N'Mũ trùm toán học',950000,1)
INSERT INTO PRODUCTS(Product_ID,Product_CategoryID,Product_Name,Product_Price,Product_Status)
VALUES('PK005','PK',N'Cân đẩu vân hack',2950000,0)

-- RECEIPTS MOCK DATA

INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC001','DT001',10,'6/21/2020 6:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC002','DT002',5,'6/21/2020 7:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC003','DT003',2,'6/21/2020 6:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC004','DT004',1,'6/21/2020 6:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC005','TT001',30,'6/21/2020 6:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC006','TT002',4,'6/21/2020 6:48:41 AM')
INSERT INTO RECEIPTS(Receipt_ID,Product_ID,Product_Amount,Receipt_Date)
VALUES('RC007','PK001',19,'6/21/2020 6:48:41 AM')


