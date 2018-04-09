﻿INSERT INTO dbo.ProcessingJobs
(
	JobName,
	JobDescription,
	JobOperationMode,
	IsJobActiveFlag,
	ProcedureName,
	BackupFolderPath,
	InputFileFolderPath,
	InputFileName,
	InputFileExtension,
	InputFileSeparatorChar,
	OutputFileFolderPath,
	OutputFileName,
	OutputFileExtension,
	OutputFileSeparatorChar,
	FileExportDateTimeFlag,
	FileProcessingDateTimeFlag
	)
VALUES
(
	'CV4S003S',
	'This job extract data from RAROC and writes to a txt file.',
	3,
	1,
	'Procedure',
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	'C:\USERS\FRAZEAL\SOURCE\REPOS\PLATAFORMAEXPORTACAO\SERVER\OUTPUT',
	'RAROC',
	'.CSV',
	',',
	1,
	0
)