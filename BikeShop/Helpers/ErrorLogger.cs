using BikeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace BikeShop.Helpers
{
    internal static class ErrorLogger
    {
        internal static void Log(Exception ex)
        {
            try
            {
                using var db = DatabaseHelper.CreateContext();
                Exception baseException = ex.GetBaseException();
                var error = new ErrorLog
                {
                    ErrorTime = DateTime.Now,
                    UserName = Environment.UserName,
                    ErrorNumber = ex.HResult,
                    ErrorSeverity = null,
                    ErrorState = null,
                    ErrorProcedure = ex.TargetSite?.Name,
                    ErrorLine = null,
                    ErrorMessage = ex.Message
                };

                if (baseException is SqlException sqlEx)
                {
                    error.ErrorNumber = sqlEx.Number;
                    error.ErrorSeverity = sqlEx.Class;
                    error.ErrorState = sqlEx.State;
                    error.ErrorProcedure = sqlEx.Procedure;
                    error.ErrorLine = sqlEx.LineNumber;
                }

                if (error.ErrorMessage.Length > 4000)
                {
                    error.ErrorMessage = error.ErrorMessage.Substring(0, 4000);
                }

                if (error.ErrorProcedure?.Length > 126)
                {
                    error.ErrorProcedure =
                        error.ErrorProcedure.Substring(0, 126);
                }

                db.ErrorLogs.Add(error);
                db.SaveChanges();

            }
            catch (Exception logException)
            {
                MessageBox.Show("Unable to log error: " + logException.Message);
            }
        }
    }
}
