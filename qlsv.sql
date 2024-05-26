USE [master]
GO
/****** Object:  Database [firstDB]    Script Date: 25-May-24 5:46:37 PM ******/
CREATE DATABASE [firstDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'firstDB', FILENAME = N'D:\sql2022\MSSQL16.MSSQLSERVER\MSSQL\DATA\firstDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'firstDB_log', FILENAME = N'D:\sql2022\MSSQL16.MSSQLSERVER\MSSQL\DATA\firstDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [firstDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [firstDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [firstDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [firstDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [firstDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [firstDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [firstDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [firstDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [firstDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [firstDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [firstDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [firstDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [firstDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [firstDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [firstDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [firstDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [firstDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [firstDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [firstDB] SET RECOVERY FULL 
GO
ALTER DATABASE [firstDB] SET  MULTI_USER 
GO
ALTER DATABASE [firstDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [firstDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [firstDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [firstDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [firstDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [firstDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'firstDB', N'ON'
GO
ALTER DATABASE [firstDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [firstDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [firstDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [varchar](20) NOT NULL,
	[Name] [varchar](50) NULL,
	[StudyYear] [int] NULL,
	[TeacherID] [varchar](20) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[StudentID] [varchar](20) NOT NULL,
	[CourseID] [varchar](20) NOT NULL,
	[Points] [float] NULL,
	[Grading] [nchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC,
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_MSGV] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [fk_Grade_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [fk_Grade_Course]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [fk_Grade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [fk_Grade_Student]
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteCourse]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_deleteCourse]
@CourseID varchar(20)
AS
delete from Course 
where CourseID = @CourseID
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteGrade]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_deleteGrade]
@StudentID varchar(20),
@CourseID varchar(20)
AS 
delete from Grade 
where @StudentID = StudentID and @CourseID = CourseID
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteStudent]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_deleteStudent]
@StudentID varchar(20)
AS 
delete FROM Student
where StudentID = @StudentID 
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteTeacher]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_deleteTeacher]
@TeacherID varchar(20)
AS 
delete FROM Teacher
where TeacherID = @TeacherID
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllCourse]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_getAllCourse]
AS
select 
c.CourseID as [Course ID], 
c.Name as [Course Name], 
c.StudyYear as [Year], 
t.Name as [Teacher Name]
from Course c
inner join Teacher t on c.TeacherID = t.TeacherID
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllGrade]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_getAllGrade]
AS
SELECT
	g.StudentID AS [Student ID],
	g.CourseID AS [Course ID],
    s.Name AS [Student Name],
    c.Name AS [Course Name],
    g.Points,
    g.Grading,
    t.Name AS [Teacher Name]
FROM
    Grade g
INNER JOIN Student s ON g.StudentID = s.StudentID
INNER JOIN Course c ON g.CourseID = c.CourseID
INNER JOIN Teacher t ON c.TeacherID = t.TeacherID;
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllStudent]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_getAllStudent]
AS 
SELECT * FROM Student
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllTeacher]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pr_getAllTeacher]
AS
select 
*
from Teacher
GO
/****** Object:  StoredProcedure [dbo].[pr_getAverageScore]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_getAverageScore]
AS 
select sd.*, Round(avg(g.Points), 2) AverageScore from Student sd
join Grade g on sd.StudentID = g.StudentID
group by sd.StudentID, sd.Name, sd.Address, sd.DateOfBirth
GO
/****** Object:  StoredProcedure [dbo].[pr_insertCourse]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pr_insertCourse]
@CourseID varchar(20),
@CourseName varchar(50),
@StudyYear int,
@TeacherID varchar(20)
AS
insert into Course values 
(@CourseID, @CourseName, @StudyYear, @TeacherID)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertGrade]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_update]
    @Points FLOAT,
    @StudentID VARCHAR(50)
AS
BEGIN
    UPDATE YourTableName
    SET Points = @Points
    WHERE StudentID = @StudentID
END

GO
create PROC [dbo].[pr_insertGrade]
@StudentID varchar(20),
@CourseID varchar(20),
@Points float,
@Grading nchar(1)
AS 
insert into Grade values 
(@StudentID, @CourseID, @Points, @Grading)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertStudent]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_insertStudent]
@StudentID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50),
@DateOfBirth date
AS 
insert into Student values 
(@StudentID, @Name, @Address, @DateOfBirth)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertTeacher]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_insertTeacher]
@TeacherID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50)
AS 
insert into Teacher values 
(@TeacherID, @Name, @Address)
GO
/****** Object:  StoredProcedure [dbo].[pr_updateCourse]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC IF EXISTS [dbo].[pr_updateGrade]
GO
CREATE PROCEDURE [dbo].[pr_updateGrade]
    @StudentID VARCHAR(20),
    @CourseID VARCHAR(20),
    @Points FLOAT,
    @Grading NCHAR(1)
AS 
    BEGIN
        UPDATE Grade 
        SET 
			Points = @Points,
            Grading = @Grading
        WHERE StudentID = @StudentID
          AND CourseID = @CourseID;
END
GO
/****** Object:  StoredProcedure [dbo].[pr_updateStudent]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_updateStudent]
@StudentID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50),
@DateOfBirth date
AS
UPDATE Student 
SET
StudentID = @StudentID,
Name = @Name,
Address = @Address, 
DateOfBirth = @DateOfBirth
WHERE StudentID = @StudentID
GO
/****** Object:  StoredProcedure [dbo].[pr_updateTeacher]    Script Date: 25-May-24 5:46:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_updateTeacher]
@TeacherID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50)
AS
UPDATE Teacher 
SET
TeacherID = @TeacherID,
Name = @Name,
Address = @Address
WHERE TeacherID = @TeacherID
GO
USE [master]
GO
ALTER DATABASE [firstDB] SET  READ_WRITE 
GO

--insert data
-- Insert data into Course table (20 entries)
INSERT INTO Course (CourseID, Name, StudyYear, TeacherID)
VALUES ('CS101', 'Introduction to Computer Science', 1, 'T001'),
       ('MATH201', 'Calculus I', 2, 'T002'),
       ('ENG305', 'Advanced English Composition', 3, 'T003'),
       ('BIO112', 'General Biology', 1, 'T004'),
       ('HIST310', 'Modern World History', 3, 'T005'),
       ('CHEM205', 'Organic Chemistry', 2, 'T006'),
       ('MUS120', 'Music Appreciation', 1, 'T007'),
       ('ART180', 'Introduction to Drawing', 2, 'T008'),
       ('PHIL250', 'Ethics and Society', 3, 'T009'),
       ('ECON301', 'Macroeconomics', 3, 'T010'),
       ('CS220', 'Data Structures', 2, 'T001'),
       ('MATH310', 'Linear Algebra', 3, 'T002'),
       ('PHYS210', 'General Physics I', 2, 'T011'),
       ('PSYC101', 'Introduction to Psychology', 1, 'T012'),
       ('MGT305', 'Principles of Management', 3, 'T013'),
       ('MKT250', 'Marketing Fundamentals', 2, 'T014'),
       ('STAT280', 'Statistical Methods', 2, 'T015'),
       ('ACCT201', 'Financial Accounting', 2, 'T016'),
       ('SPAN102', 'Elementary Spanish II', 1, 'T017'),
       ('COMM210', 'Public Speaking', 2, 'T018');

GO
-- Insert data into Student table (20 entries)
INSERT INTO Student (StudentID, Name, Address, DateOfBirth)
VALUES ('S001', 'John Doe', '123 Main St, Cityville, USA', '1995-05-15'),
       ('S002', 'Jane Smith', '456 Oak Rd, Towncenter, USA', '1997-11-22'),
       ('S003', 'Michael Johnson', '789 Pine Ave, Villageton, USA', '1996-09-03'),
       ('S004', 'Emily Brown', '321 Maple Ln, Cityville, USA', '1998-03-28'),
       ('S005', 'David Wilson', '654 Elm St, Towncenter, USA', '1997-07-10'),
       ('S006', 'Olivia Taylor', '987 Cedar Rd, Villageton, USA', '1999-12-05'),
       ('S007', 'William Anderson', '159 Oak Ave, Cityville, USA', '1996-02-18'),
       ('S008', 'Sophia Martinez', '753 Pine St, Towncenter, USA', '1998-09-22'),
       ('S009', 'James Thompson', '246 Maple Blvd, Villageton, USA', '1997-04-30'),
       ('S010', 'Ava Garcia', '369 Elm Ln, Cityville, USA', '1999-08-11'),
       ('S011', 'Benjamin Hernandez', '159 Cedar Ave, Towncenter, USA', '1996-06-25'),
       ('S012', 'Isabella Gonzalez', '753 Oak St, Villageton, USA', '1998-01-07'),
       ('S013', 'Daniel Rodriguez', '246 Pine Blvd, Cityville, USA', '1997-11-14'),
       ('S014', 'Mia Perez', '369 Maple Ln, Towncenter, USA', '1999-05-29'),
       ('S015', 'Matthew Sanchez', '159 Elm Ave, Villageton, USA', '1996-10-02'),
       ('S016', 'Abigail Ramirez', '753 Cedar St, Cityville, USA', '1998-03-16'),
       ('S017', 'Andrew Torres', '246 Oak Blvd, Towncenter, USA', '1997-07-21'),
       ('S018', 'Emma Flores', '369 Pine Ln, Villageton, USA', '1999-12-09'),
       ('S019', 'Joshua Rivera', '159 Maple Ave, Cityville, USA', '1996-05-04'),
       ('S020', 'Avery Gomez', '753 Elm St, Towncenter, USA', '1998-09-27');
GO
--GRADE
INSERT INTO Grade (StudentID, CourseID, Points, Grading)
VALUES ('S001', 'CS101', 92.5, 'A'),
       ('S002', 'MATH201', 85.0, 'B'),
       ('S003', 'ENG305', 91.0, 'A'),
       ('S004', 'BIO112', 88.0, 'B'),
       ('S005', 'HIST310', 78.5, 'C'),
       ('S006', 'CHEM205', 95.0, 'A'),
       ('S007', 'MUS120', 82.0, 'B'),
       ('S008', 'ART180', 90.0, 'A'),
       ('S009', 'PHIL250', 75.5, 'C'),
       ('S010', 'ECON301', 87.0, 'B'),
       ('S011', 'CS220', 93.5, 'A'),
       ('S012', 'MATH310', 79.0, 'C'),
       ('S013', 'PHYS210', 85.5, 'B'),
       ('S014', 'PSYC101', 92.0, 'A'),
       ('S015', 'MGT305', 88.5, 'B'),
       ('S016', 'MKT250', 77.0, 'C'),
       ('S017', 'STAT280', 94.0, 'A'),
       ('S018', 'ACCT201', 81.5, 'B'),
       ('S019', 'SPAN102', 89.0, 'A'),
       ('S020', 'COMM210', 91.5, 'A');
GO
-- Insert data into Teacher table (20 entries)
INSERT INTO Teacher (TeacherID, Name, Address)
VALUES ('T001', 'Alice Williams', '111 Maple Ln, Cityville, USA'),
       ('T002', 'Bob Thompson', '222 Elm St, Towncenter, USA'),
       ('T003', 'Carol Davis', '333 Cedar Rd, Villageton, USA'),
       ('T004', 'David Johnson', '444 Oak Ave, Cityville, USA'),
       ('T005', 'Emily Wilson', '555 Pine St, Towncenter, USA'),
       ('T006', 'Michael Brown', '666 Maple Blvd, Villageton, USA'),
       ('T007', 'Sarah Taylor', '777 Elm Ln, Cityville, USA'),
       ('T008', 'Christopher Anderson', '888 Cedar Ave, Towncenter, USA'),
       ('T009', 'Jessica Martinez', '999 Oak St, Villageton, USA'),
       ('T010', 'Matthew Thompson', '110 Pine Blvd, Cityville, USA'),
       ('T011', 'Olivia Garcia', '221 Maple Ln, Towncenter, USA'),
       ('T012', 'Daniel Hernandez', '332 Elm Ave, Villageton, USA'),
       ('T013', 'Sophia Gonzalez', '443 Cedar St, Cityville, USA'),
       ('T014', 'William Rodriguez', '554 Oak Blvd, Towncenter, USA'),
       ('T015', 'Isabella Perez', '665 Pine Ln, Villageton, USA'),
       ('T016', 'Benjamin Sanchez', '776 Maple Ave, Cityville, USA'),
       ('T017', 'Mia Ramirez', '887 Elm St, Towncenter, USA'),
       ('T018', 'Andrew Torres', '998 Cedar Rd, Villageton, USA'),
       ('T019', 'Abigail Flores', '111 Oak Ln, Cityville, USA'),
       ('T020', 'Emma Rivera', '222 Pine Ave, Towncenter, USA');
GO
--course
INSERT INTO Course (CourseID, Name, StudyYear, TeacherID)
VALUES ('CS101', 'Introduction to Computer Science', 1, 'T001'),
       ('MATH201', 'Calculus I', 2, 'T002'),
       ('ENG305', 'Advanced English Composition', 3, 'T003'),
       ('BIO112', 'General Biology', 1, 'T004'),
       ('HIST310', 'Modern World History', 3, 'T005'),
       ('CHEM205', 'Organic Chemistry', 2, 'T006'),
       ('MUS120', 'Music Appreciation', 1, 'T007'),
       ('ART180', 'Introduction to Drawing', 2, 'T008'),
       ('PHIL250', 'Ethics and Society', 3, 'T009'),
       ('ECON301', 'Macroeconomics', 3, 'T010'),
       ('CS220', 'Data Structures', 2, 'T001'),
       ('MATH310', 'Linear Algebra', 3, 'T002'),
       ('PHYS210', 'General Physics I', 2, 'T011'),
       ('PSYC101', 'Introduction to Psychology', 1, 'T012'),
       ('MGT305', 'Principles of Management', 3, 'T013'),
       ('MKT250', 'Marketing Fundamentals', 2, 'T014'),
       ('STAT280', 'Statistical Methods', 2, 'T015'),
       ('ACCT201', 'Financial Accounting', 2, 'T016'),
       ('SPAN102', 'Elementary Spanish II', 1, 'T017'),
       ('COMM210', 'Public Speaking', 2, 'T018');