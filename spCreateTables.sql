SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Shané Erasmus
-- Create date: 2021/09/27
-- Description:	CMPG223  Create required tables for StatsSa App Use Cases
-- =============================================


DROP TABLE IF EXISTS District, SystemUser, Employee, Respondent, RespondentQuestionnaire, Questionnaire, City, Survey;
GO

CREATE TABLE Survey (
	Survey_ID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100),
	StartDate DATE,
	EndDate DATE
)

CREATE TABLE Questionnaire (
	QN_ID INT IDENTITY(1,1) PRIMARY KEY,
	Survey_ID INT FOREIGN KEY REFERENCES Survey(Survey_ID),
	Description VARCHAR(MAX)
)

CREATE TABLE City (
	City_ID INT IDENTITY(1,1) PRIMARY KEY, 
	City_Name VARCHAR(MAX)
)

CREATE TABLE District (
	District_ID INT IDENTITY(1,1) PRIMARY KEY,
	District_name VARCHAR(MAX)
)

CREATE TABLE Employee (
	Empl_ID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100),
	LastName VARCHAR(200),
	Type_empl VARCHAR(2)	--Type refers to F = FIeldworker, M = Manager etc...
)

CREATE TABLE Respondent (
	Resp_ID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100),
	LastName VARCHAR(400),
	DOB DATE,
	Street_No_Addr INT,
	Street_Name VARCHAR(400),
	City_ID INT FOREIGN KEY REFERENCES City(City_ID)
)

CREATE TABLE RespondentQuestionnaire(
	Resp_ID INT NOT NULL ,
	QN_ID INT NOT NULL,
	Date_completed DATE,
	District_ID INT FOREIGN KEY REFERENCES District(District_ID),
	Approved_YN VARCHAR(2),
	Approved_by INT FOREIGN KEY REFERENCES Employee(Empl_ID),
	Field_worker INT FOREIGN KEY REFERENCES Employee(Empl_ID),
	CONSTRAINT PK_RespondentQuestionnaire PRIMARY KEY (Resp_ID,QN_ID)
)

CREATE TABLE SystemUser(
	User_ID INT IDENTITY(1,1) PRIMARY KEY,
	Password VARCHAR(100),
	Employee_ID INT FOREIGN KEY REFERENCES Employee(Empl_ID)
)