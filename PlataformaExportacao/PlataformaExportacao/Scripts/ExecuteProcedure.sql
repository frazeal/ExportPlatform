﻿USE [C:\USERS\FRAZEAL\SOURCE\REPOS\PLATAFORMAEXPORTACAO\PLATAFORMAEXPORTACAO\DATABASE.MDF]
GO

DECLARE	@return_value INT

EXEC	@return_value = [dbo].[Procedure] 2

SELECT	@return_value AS 'Return Value'
GO
