USE AddressBook

CREATE TABLE Contact
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(MAX) NOT NULL, 
    [MiddleName] NVARCHAR(MAX) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(MAX) NOT NULL
)


INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (1,'Василий','Анатольвич','Павлов',    '(985) 345-3423')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (2,'Антон','Рустанович','Молодцов',    '(985) 326-3489')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (3,'Елизавета','Евгеньевна','Моложина','(945) 345-0023')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (4,'Анатолий','Борисовна','Черных',    '(912) 945-3423')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (5,'Елена','Иванова','Черкашина',      '(930) 345-3420')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (6,'Тимофей','Романович','Песков',     '(910) 300-3023')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (7,'Роберт','Васильевич','Басаргин',   '(920) 545-3225')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (8,'Юрий','Евгеньевич','Белых',        '(915) 345-1327')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (9,'Илья','Ростиславович','Васютович', '(985) 675-3125')
INSERT INTO Contact(Id, FirstName, MiddleName, LastName, PhoneNumber) VALUES (10,'Сергей','Борисович','Евсеев',      '(910) 098-1422')

