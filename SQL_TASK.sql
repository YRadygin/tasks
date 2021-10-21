--Создаем таблицу с категориями
CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

--Наполняем значениями категорий
INSERT INTO Category 
VALUES  (1, 'Двигатель'),
        (2, 'Ходовая'),
		(3, 'Тормозная система'),
		(4, 'Кузов');

--Создаем таблицу с продуктами
CREATE TABLE Products (
	id int PRIMARY KEY,
	name varchar(255) NOT NULL);

--Наполняем ее значениями
INSERT INTO Products
VALUES  (1, 'Поршни'),
	(2, 'Клапаны'),
	(3, 'Головка блока цилиндров'),
    (4, 'Стойка стабилизатора'),
	(5, 'Сайлентблок'),
	(6, 'Пружина стабилизатора'),
    (7, 'Тормозной диск'),
	(8, 'Тормозной шланг'),
	(9, 'Тормозная жидкость'),
	(10, 'Фары'),
	(11, 'Жидкость омывателя');
	
--Создаем таблицу маппинга Продукт-категория
	CREATE TABLE ProductsCategoryMapping (
	products_id  INT not null,
	category_id INT not null);


--Присваиваем товарам группы
INSERT INTO ProductsCategoryMapping
VALUES  (1, 1),
	(2, 1),
	(3, 1),
	(4, 2),
	(5, 2),
	(6, 2),
	(7, 3),
	(8, 3),
	(9, 3);

--Делаем выборку по условиям задачи
select product.name AS [Продукт], category.name AS [Категория]
from Products product
left join ProductsCategoryMapping prodmapping on product.id = prodmapping.products_id
left join Category category on category.id = prodmapping.category_id;
