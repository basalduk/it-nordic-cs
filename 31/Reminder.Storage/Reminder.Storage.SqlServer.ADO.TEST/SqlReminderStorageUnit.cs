using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.SqlServer.ADO.TEST.Properties;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Reminder.Storage.SqlServer.ADO.TEST
{

    public class SqlReminderStorageUnit
    {
        private  readonly string _connectionString;
        public SqlReminderStorageUnit(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InitalizationData()
        {
            RunSqlScript(Resources.Schema);
            RunSqlScript(Resources.SPs);
            RunSqlScript(Resources.Date);
        }

        private void RunSqlScript(string script)
        {
            using (SqlConnection sqlConnection = GetOpenConnection())
            {
                var cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                var SqlInsruction = SplitSqlInsruction(script);
                foreach (string sqlInsruction in sqlInsructions)
                {
                    if (string.IsNullOrWhiteSpace(sqlInsruction))
                        continue;

                }

                cmd.CommandText = script;

                cmd.ExecuteNonQuery();
            }
        }
        private string[] SplitSqlInsruction(string script)
        {
            return Regex.Split(script, @"\bGO\b");
        }
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetOpenConnection()
        {
            //var ;
        }

        
    }
}
