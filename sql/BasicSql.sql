USE Practice;

-- Query used in order to find the information of different tables. (It will only execute when we are using any database)
SELECT * FROM INFORMATION_SCHEMA.TABLES;

--selecting all rows from table
SELECT * FROM Person;

--selecting particular columns from table
SELECT ID, [Name], Age, Email FROM Person;

--selecting rows from table on the basic of condition
SELECT ID, [Name], Age, Email 
FROM Person 
WHERE Email IS NOT NULL;

--selecting rows from table on the basic of multiple condition 
SELECT ID, [Name], Age, Email 
FROM Person 
WHERE City = 'Mystic Falls' AND Email IS NOT NULL;  --Using AND, the rows which fulfil both the conditions are fetched

SELECT ID, [Name], Age, Email 
FROM Person 
WHERE City = 'Mystic Falls' OR Email IS NOT NULL;  --Using OR, the rows which fulfil any one condition are fetched

-- truncating a table -. deletes the data of table but doesnt delete the structure of table
TRUNCATE TABLE Person;

-- inserting a row in table
INSERT INTO Person(Name, City, Age, Email)
Values (
'Caroline Forbes','New Orleans',19,'caroline.candice@tvd.com'
);

-- Updating a row in table
UPDATE Person
SET Name = 'Dimple Verma' 
WHERE Id = 1;

-- Adding a new column into the table -> All the entries will be null for the existing rows in new column
ALTER TABLE Person
ADD DateOfBirth Date;

-- Adding column in a tablw with default values
ALTER TABLE Person
ADD Extraa bit
DEFAULT(0)
WITH VALUES;

ALTER TABLE Person
ADD Gender char;

ALTER TABLE Person
DROP COLUMN Gender;

UPDATE Person
SET Extraa = 1 
WHERE ID In(1,3,6);

