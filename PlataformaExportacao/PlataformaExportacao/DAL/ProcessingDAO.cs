﻿using PlataformaExportacao.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.DAL
{
    public class ProcessingDAO
    {
        public void Save(ProcessingVO processing)
        {
            throw new NotImplementedException();
        }

        public ProcessingVO Get(int IdJob)
        {
            String sqlCommandText = "SELECT * FROM [dbo].[ProcessingJobs] WHERE IdJob = @IdJob";

            using (IDbConnection connection = ConnectionFactory.CreateConnection())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sqlCommandText;
                IDbDataParameter paramId = command.CreateParameter();
                paramId.ParameterName = "IdJob";
                paramId.Value = IdJob;
                command.Parameters.Add(paramId);
                IDataReader dataReader = command.ExecuteReader();
                ProcessingVO processing = new ProcessingVO();
                while (dataReader.Read())
                {
                    processing.IdJob = Convert.ToInt32(dataReader["IdJob"]);
                    processing.JobName = Convert.ToString(dataReader["JobName"]);
                    processing.JobDescription = Convert.ToString(dataReader["JobDescription"]);
                    processing.IsJobActiveFlag = Convert.ToBoolean(dataReader["IsJobActiveFlag"]);
                    processing.JobOperationMode = Convert.ToInt16(dataReader["JobOperationMode"]);

                    processing.ProcedureName = Convert.ToString(dataReader["ProcedureName"]);
                    processing.BackupFolderpath = Convert.ToString(dataReader["BackupFolderPath"]);

                    processing.InputFileFolderPath = Convert.ToString(dataReader["InputFileFolderPath"]);
                    processing.InputFileName = Convert.ToString(dataReader["InputFileName"]);
                    processing.InputFileExtension = Convert.ToString(dataReader["InputFileExtension"]);
                    processing.InputFileSeparatorChar = Convert.ToString(dataReader["InputFileSeparatorChar"]);

                    processing.OutputFileFolderPath = Convert.ToString(dataReader["OutputFileFolderPath"]);
                    processing.OutputFileName = Convert.ToString(dataReader["OutputFileName"]);
                    processing.OutputFileExtension = Convert.ToString(dataReader["OutputFileExtension"]);
                    processing.OutputFileSeparatorChar = Convert.ToString(dataReader["OutputFileSeparatorChar"]);

                    processing.FileExportDateTimeFlag = Convert.ToBoolean(dataReader["FileExportDateTimeFlag"]);
                    processing.FileProcessingDateTimeFlag = Convert.ToBoolean(dataReader["FileProcessingDateTimeFlag"]);

                    // INFO: other ways to get the conversions
                    //processing.IdJob = dataReader.GetInt32(dataReader.GetOrdinal("IdJob"));
                    //processing.IsJobActiveFlag = dataReader.GetBoolean(dataReader.GetOrdinal("IsJobActiveFlag"));
                    //processing.JobOperationMode = (short) dataReader.GetInt32(dataReader.GetOrdinal("JobOperationMode"));
                    //processing.JobName = dataReader.GetString(dataReader.GetOrdinal("JobName"));
                    //processing.JobDescription = dataReader.IsDBNull(dataReader.GetOrdinal("JobDescription")) ? String.Empty : dataReader.GetString(dataReader.GetOrdinal("JobDescription"));
                }
                dataReader.Close();
                return processing;
            }
        }

        public IList<ProcessingVO> List()
        {
            throw new NotImplementedException();
        }

        public void Merge(ProcessingVO processing)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProcessingVO processing)
        {
            throw new NotImplementedException();
        }
    }
}
