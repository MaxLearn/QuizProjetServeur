/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
SELECT TOP (1000) [id]
      ,[first_name]
      ,[last_name]
      ,[email]
      ,[gender]
      ,[phone]
  FROM [Customer].[dbo].[Customer]