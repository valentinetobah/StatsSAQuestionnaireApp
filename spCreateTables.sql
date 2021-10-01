SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Shané Erasmus
-- Create date: 2021/09/27
-- Description:	CMPG223  create tables stored proc
-- =============================================
CREATE OR ALTER PROCEDURE create_table
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	CREATE TABLE Survey (
		Survey_ID INT NOT NULL PRIMARY KEY,
		Name VARCHAR(100),
		StartDate DATE,
		EndDate DATE
	)

	CREATE TABLE Questionnaire (
		QN_ID INT NOT NULL PRIMARY KEY,
		Survey_ID INT FOREIGN KEY REFERENCES Survey(Survey_ID),
		desription VARCHAR(MAX)
	)

	--CREATE TABLE Question (
	--	Q_ID INT NOT NULL PRIMARY KEY,
	--	Q_text VARCHAR(MAX)
	--)

	CREATE TABLE City (
		City_ID INT NOT NULL PRIMARY KEY, 
		City_Name VARCHAR(MAX)
	)

	CREATE TABLE District (
		district_ID INT NOT NULL PRIMARY KEY,
		district_name VARCHAR(MAX)
	)
	
	CREATE TABLE Employee (
		Empl_ID INT NOT NULL PRIMARY KEY,
		Name VARCHAR(100),
		LastName VARCHAR(200),
		Type_empl VARCHAR(2)	--Type refers to F = FIeldworker, M = Manager etc...
	)

	CREATE TABLE Respondent (
		Resp_ID INT NOT NULL PRIMARY KEY,
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
		date_completed DATE,
		district_ID INT FOREIGN KEY REFERENCES District(district_ID),
		Approved_YN VARCHAR(2),
		approved_by INT FOREIGN KEY REFERENCES Employee(Empl_ID),
		field_worker INT FOREIGN KEY REFERENCES Employee(Empl_ID),
		CONSTRAINT PK_RespondentQuestionnaire PRIMARY KEY (Resp_ID,QN_ID)

	)
	
	--CREATE TABLE ANSWER_TO_QUESTIONS(
	--	ANSWER_ID INT NOT NULL PRIMARY KEY,
	--	QN_ID INT FOREIGN KEY REFERENCES Questionnaire(QN_ID),
	--	Q_ID INT FOREIGN KEY REFERENCES Question(Q_ID),
	--	Resp_ID INT FOREIGN KEY REFERENCES Respondent(Resp_ID),
	--	Answer_Text VARCHAR(MAX)
	--)

END
GO


