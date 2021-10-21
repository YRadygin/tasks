--������� ������� � �����������
CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

--��������� ���������� ���������
INSERT INTO Category 
VALUES  (1, '���������'),
        (2, '�������'),
		(3, '��������� �������'),
		(4, '�����');

--������� ������� � ����������
CREATE TABLE Products (
	id int PRIMARY KEY,
	name varchar(255) NOT NULL);

--��������� �� ����������
INSERT INTO Products
VALUES  (1, '������'),
	(2, '�������'),
	(3, '������� ����� ���������'),
    (4, '������ �������������'),
	(5, '�����������'),
	(6, '������� �������������'),
    (7, '��������� ����'),
	(8, '��������� �����'),
	(9, '��������� ��������'),
	(10, '����'),
	(11, '�������� ���������');
	
--������� ������� �������� �������-���������
	CREATE TABLE ProductsCategoryMapping (
	products_id  INT not null,
	category_id INT not null);


--����������� ������� ������
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

--������ ������� �� �������� ������
select product.name AS [�������], category.name AS [���������]
from Products product
left join ProductsCategoryMapping prodmapping on product.id = prodmapping.products_id
left join Category category on category.id = prodmapping.category_id;
