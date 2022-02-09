CREATE TABLE [dbo].[tbSupplier](
	[supplierID] [varchar](6) NOT NULL Primary key,
	[supplierName] [nvarchar](50) NULL,
	[contractName] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[telephone] [varchar](15) NULL
	);

insert into tbSupplier values('0001',N'ທະນູສອນ','somchai autosound','phontong village','');