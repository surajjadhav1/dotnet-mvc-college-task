/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CourseId]
      ,[CourseName]
      ,[Fees]
      ,[Duration]
  FROM [MetMumbai].[dbo].[Course]