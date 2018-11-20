-- Table creation
CREATE TABLE [dbo].[Products] (
    [Id_product] INT NOT NULL PRIMARY KEY ,
    [Name] NVARCHAR(50) NOT NULL,
);
CREATE TABLE [dbo].Categories
(
	[Id_Category] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].ProductCategories
(
	[id_product] INT NULL , 
    [id_category] INT NULL, 
    CONSTRAINT [FK_ProductCategories_ToProducts] FOREIGN KEY (id_product) REFERENCES [Products]([id_product]),
	CONSTRAINT [FK_ProductCategories_ToCategories] FOREIGN KEY (id_category) REFERENCES [Categories]([id_category])
);

-- Test data
insert into Products (id_product, Name) values(1, 'Product 1');
insert into Products (id_product, Name) values(2, 'Product 2');
insert into Products (id_product, Name) values(3, 'Product 3');

insert into categories (id_category, Name) values(1, 'Category 1');
insert into categories (id_category, Name) values(2, 'Category 2');
insert into categories (id_category, Name) values(3, 'Category 3');

insert into ProductCategories (id_product, id_category) values (1, 1);
insert into ProductCategories (id_product, id_category) values (1, 2);
insert into ProductCategories (id_product, id_category) values (2, 2);

-- Query
select 
 p.name productname,
 c.name categoryname 
from 
Products p 
left join ProductCategories pc on p.Id_product=pc.id_product
left join Categories c on pc.id_category=c.id_category;

