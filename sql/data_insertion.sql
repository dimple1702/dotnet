-- These are the tables that I had created first But the naming convention was wrong. 

-- creating table country
CREATE TABLE countries (
	country_id INT IDENTITY(1,1) PRIMARY KEY,
	country_code CHAR (2),
	country_name VARCHAR (40) DEFAULT NULL,
	region_name VARCHAR(25) DEFAULT NULL
);

--inserting data into countries table
INSERT INTO countries(country_code,country_name,region_name) VALUES ('AR','Argentina','Americas');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('AU','Australia','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('BE','Belgium','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('BR','Brazil','Americas');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('CA','Canada','Americas');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('CH','Switzerland','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('CN','China','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('DE','Germany','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('DK','Denmark','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('EG','Egypt','Middle East and Africa');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('FR','France','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('HK','HongKong','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('IL','Israel','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('IN','India','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('IT','Italy','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('JP','Japan','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('KW','Kuwait','Middle East and Africa');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('MX','Mexico','Americas');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('NG','Nigeria','Middle East and Africa');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('NL','Netherlands','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('SG','Singapore','Asia');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('UK','United Kingdom','Europe');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('US','United States of America','Americas');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('ZM','Zambia','Middle East and Africa');
INSERT INTO countries(country_code,country_name,region_name) VALUES ('ZW','Zimbabwe','Middle East and Africa');


-- creating a table locations
CREATE TABLE locations (
	location_id INT IDENTITY(1,1) PRIMARY KEY,
	[address] VARCHAR (50) DEFAULT NULL,
	pin_code VARCHAR (50) DEFAULT NULL,
	city VARCHAR (30) NOT NULL,
	country_id INT NOT NULL,
	FOREIGN KEY (country_id) REFERENCES countries (country_id) ON DELETE CASCADE ON UPDATE CASCADE
);

--inserting data into locations table
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('2014 Jabberwocky Rd','26192','Southlake',23);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('2011 Interiors Blvd','99236','South San Francisco',23);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('2004 Charade Rd','98199','Seattle',23);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('147 Spadina Ave','M5V 2L7','Toronto',5);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('8204 Arthur St',NULL,'London',22);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('Magdalen Centre, The Oxford Science Park','OX9 9ZB','Oxford',22);
INSERT INTO locations([address],pin_code,city,country_id) VALUES ('Schwanthalerstr. 7031','80925','Munich',8);

--creating database departments
CREATE TABLE departments (
	department_id INT IDENTITY(1,1) PRIMARY KEY,
	department_name VARCHAR (30) NOT NULL,
);

--inserting record into departments
INSERT INTO departments(department_name) VALUES ('Administration');
INSERT INTO departments(department_name) VALUES ('Marketing');
INSERT INTO departments(department_name) VALUES ('Management');
INSERT INTO departments(department_name) VALUES ('Human Resources');
INSERT INTO departments(department_name) VALUES ('Agriculture');
INSERT INTO departments(department_name) VALUES ('IT');
INSERT INTO departments(department_name) VALUES ('Commerce');
INSERT INTO departments(department_name) VALUES ('Sales');
INSERT INTO departments(department_name) VALUES ('Science');
INSERT INTO departments(department_name) VALUES ('Medical');
INSERT INTO departments(department_name) VALUES ('Accounting');

--creating table teacher
CREATE TABLE teachers (
	teacher_id INT Identity(1,1) PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	email VARCHAR (100) NOT NULL,
	phone_number VARCHAR (20) DEFAULT NULL,
	hire_date DATE NOT NULL,
	department_id INT NOT NULL,
	location_id INT NOT NULL,
	FOREIGN KEY (department_id) REFERENCES departments (department_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (location_id) REFERENCES locations (location_id) ON DELETE CASCADE ON UPDATE CASCADE
);

--inserting record into teachers
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Penelope','Gietz','atomkiewicz@hotmail.com','01944-36996','1987-06-17',10,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Nick','Higgins','evan.zigomalas@gmail.com','01714-737668','1989-09-21',1,1);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Ed','Whalen','france.andrade@hotmail.com','01935-821636','1993-01-13',5,7);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Jennifer','King','ulysses@hotmail.com','01302-601380','1990-01-03',9,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Johnny','Kochhar','tyisha.veness@hotmail.com','01545-817375','1991-05-21',9,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Bette','De Haan','erampy@rampy.co.uk','01362-620532','1997-06-25',4,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Grace','Faviet','marg@hotmail.com','01340-713951','1998-02-05',2,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Matthew','Chen','laquita@yahoo.com','01687-879391','1999-02-07',6,2);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Joe','Sciarra','lura@hotmail.com','01342-793603','1994-08-17',10,7);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Christian','Urman','yuette.klapec@klapec.co.uk','01956-535511','1994-08-16',10,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Zero','Popp','fernanda@writer.co.uk','01241-964675','1997-09-28',10,6);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Karl','Greenberg','charlesetta_erm@gmail.com','01743-139456','1997-09-30',6,2);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Uma','Mavris','corrinne_jaret@gmail.com','01939-815208','1999-12-07',10,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Vivien','Hunold','niesha.bruch@yahoo.com','01366-210656','1994-12-07',4,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Cuba','Ernst','rueben_gastellum@gastellum.co.uk','01292-297245','1995-05-18',1,4);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Fred','Austin','mthrossell@throssell.co.uk','01405-648623','1997-07-24',4,5);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Helen','Pataballa','edgar.kanne@yahoo.com','01809-443217','1999-08-10',6,2);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Dan','Lorentz','dewitt.julio@hotmail.com','01351-868965','1996-07-18',4,5);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Bob','Hartstein','charisse_spinello@spinello.co.uk','01640-661191','1995-05-01',5,2);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Lucille','Fay','mee.lapinski@yahoo.com','01765-519419','1997-04-10',11,7);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Kirsten','Baer','octavio.salvadore@yahoo.com','01286-258121','2000-01-04',8,4);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Elvis','Khoo','mteplica@teplica.co.uk','01818-980469','1996-02-04',5,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Sandra','Baida','tveigel@veigel.co.uk','01572-193368','1994-12-07',7,7);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Cameron','Tobias','lkufner@kufner.co.uk','01295-331807','1997-08-17',3,1);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Kevin','Himuro','tess_sitra@hotmail.com','01333-972244','1997-08-17',1,4);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Rip','Colmenares','svetlana_tauras@tauras.co.uk','01245-559333','1994-06-07',11,7);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Julia','Raphaely','augustine.growcock@growcock.co.uk','01493-245349','1994-06-07',9,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Woody','Russell','luis@hotmail.com','01823-517315','1996-02-17',1,4);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Alec','Partners','mloperfido@gmail.com','01987-728730','1994-06-07',7,3);
INSERT INTO teachers(first_name,last_name, email, phone_number, hire_date, department_id, location_id) VALUES ('Sandra','Taylor','alethea@hotmail.com','01789-132579','2000-01-04',3,1);


-- creating table for students
CREATE TABLE Student (
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	StudentFname varchar(30) DEFAULT NULL,
	StudentLname varchar(30) NOT NULL,
	StudentEmail varchar(50) NOT NULL,
	StudentPhoneNo varchar(20) DEFAULT NULL,
	StudentDob  DATE NOT NULL,
	TeacherId int DEFAULT NULL,
	LocId int DEFAULT NULL,
	FOREIGN KEY (TeacherId) REFERENCES teachers (teacher_id) ON DELETE NO ACTION ON UPDATE NO ACTION,
	FOREIGN KEY (LocId) REFERENCES locations (location_id) ON DELETE NO ACTION ON UPDATE NO ACTION,
);

select * from Student;

INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Steven','King','steven.king@hotmail.org','515.123.4567','1989-09-21',21,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Neena','Kochhar','neena.kochhar@hotmail.org','515.123.4568','1989-09-21',24,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Alexander','Hunold','alexander.hunold@hotmail.org','590.423.4567','1990-01-03',11,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Bruce','Ernst','bruce.ernst@hotmail.org','590.423.4568','1991-05-21',21,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('David','Austin','david.austin@hotmail.org','590.423.4569','1997-06-25',21,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Valli','Pataballa','valli.pataballa@hotmail.org','590.423.4560','1998-02-05',9,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Diana','Lorentz','diana.lorentz@hotmail.org','590.423.5567','1999-02-07',9,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Nancy','Greenberg','nancy.greenberg@hotmail.org','515.124.4569','1994-08-17',7,7);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Daniel','Faviet','daniel.faviet@hotmail.org','515.124.4169','1994-08-16',16,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('John','Chen','john.chen@hotmail.org','515.124.4269','1997-09-28',21,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Ismael','Sciarra','ismael.sciarra@hotmail.org','515.124.4369','1997-09-30',16,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Jose Manuel','Urman','jose manuel.urman@hotmail.org','515.124.4469','1998-03-07',16,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Luis','Popp','luis.popp@hotmail.org','515.124.4567','1999-12-07',10,6);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Den','Raphaely','den.raphaely@hotmail.org','515.127.4561','1994-12-07',14,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Alexander','Khoo','alexander.khoo@hotmail.org','515.127.4562','1995-05-18',13,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Shelli','Baida','shelli.baida@hotmail.org','515.127.4563','1997-12-24',13,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Sigal','Tobias','sigal.tobias@hotmail.org','515.127.4564','1997-07-24',13,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Guy','Himuro','guy.himuro@hotmail.org','515.127.4565','1998-11-15',13,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Karen','Colmenares','karen.colmenares@hotmail.org','515.127.4566','1999-08-10',13,3);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Matthew','Weiss','matthew.weiss@hotmail.org','650.123.1234','1996-07-18',19,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Adam','Fripp','adam.fripp@hotmail.org','650.123.2234','1997-04-10',19,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Payam','Kaufling','payam.kaufling@hotmail.org','650.123.3234','1995-05-01',19,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Shanta','Vollman','shanta.vollman@hotmail.org','650.123.4234','1997-10-10',19,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Irene','Mikkilineni','irene.mikkilineni@hotmail.org','650.124.1224','1998-09-28',18,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('John','Russell','john.russell@hotmail.org',NULL,'1996-10-01',15,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Karen','Partners','karen.partners@hotmail.org',NULL,'1997-01-05',15,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Jonathon','Taylor','jonathon.taylor@hotmail.org',NULL,'1998-03-24',16,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Jack','Livingston','jack.livingston@hotmail.org',NULL,'1998-04-23',16,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Kimberely','Grant','kimberely.grant@hotmail.org',NULL,'1999-05-24',16,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Charles','Johnson','charles.johnson@hotmail.org',NULL,'2000-01-04',16,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Sarah','Bell','sarah.bell@hotmail.org','650.501.1876','1996-02-04',17,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Britney','Everett','britney.everett@hotmail.org','650.501.2876','1997-03-03',17,5);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Jennifer','Whalen','jennifer.whalen@hotmail.org','515.123.4444','1987-09-17',3,1);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Michael','Hartstein','michael.hartstein@hotmail.org','515.123.5555','1996-02-17',10,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Pat','Fay','pat.fay@hotmail.org','603.123.6666','1997-08-17',11,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Susan','Mavris','susan.mavris@hotmail.org','515.123.7777','1994-06-07',8,4);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Hermann','Baer','hermann.baer@hotmail.org','515.123.8888','1994-06-07',12,7);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('Shelley','Higgins','shelley.higgins@hotmail.org','515.123.8080','1994-06-07',11,2);
INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId,LocId) VALUES ('William','Gietz','william.gietz@hotmail.org','515.123.8181','1994-06-07',21,2);
