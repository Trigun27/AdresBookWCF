USE AddressBook

CREATE TABLE Contact
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(MAX) NOT NULL, 
    [MiddleName] NVARCHAR(MAX) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(MAX) NOT NULL
)


INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (1,'�������','����������','������',    '(985) 345-3423')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (2,'�����','����������','��������',    '(985) 326-3489')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (3,'���������','����������','��������','(945) 345-0023')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (4,'��������','���������','������',    '(912) 945-3423')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (5,'�����','�������','���������',      '(930) 345-3420')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (6,'�������','���������','������',     '(910) 300-3023')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (7,'������','����������','��������',   '(920) 545-3225')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (8,'����','����������','�����',        '(915) 345-1327')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (9,'����','�������������','���������', '(985) 675-3125')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (10,'������','���������','������',      '(910) 098-1422')

