using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace InvertoryManagementProject
{
    public static class SQL
    {

        public static string SelectAllQueryGenerator(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            return query;
        }

    

        public static int FindMaxID(string tableName)
        {
            string query = $"SELECT MAX(ID) FROM {tableName}";

            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    var result = cmd.ExecuteScalar();
                    int maxID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    return maxID + 1;
                }
            }
        }

        public static void DeleteFromDB(string tableName, int ID)
        {
            try
            {
                string query = $"DELETE FROM {tableName} WHERE ID = {ID}";
                using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                HelperMethods.WriteLog(trace, ex);
            }
        }

        public static int FindNextID(string tableName)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                string query = $"SELECT IDENT_CURRENT('{tableName}') + 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int nextID = result != DBNull.Value ? Convert.ToInt32(result) : 1;
                    return nextID;
                }
            }
        }
    }

    public static class HelperMethods
    {
        public static object getdatavalue(object o)
        {
            if (o == null || string.Empty.Equals(o))
                return DBNull.Value;
            else
                return o;
        }

        public static object getboolvalue(object o)
        {
            if (o == null || o == DBNull.Value || string.Empty.Equals(o))
                return false;
            else
                return o;
        }
        public static object getintvalue(object o)
        {
            if (o == null || o == DBNull.Value || string.Empty.Equals(o))
                return 0;
            else
                return o;
        }

        public static bool integerornot(string girdi)
        {
            try
            {
                Convert.ToInt32(getintvalue(girdi));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void WriteLog(System.Diagnostics.StackTrace trace, Exception ex)
        {
            string LogText = DateTime.Now + " - " + ex.Message + " - " + trace.GetFrame(trace.FrameCount - 1).GetMethod().ReflectedType.FullName + " - " + "Line: " + trace.GetFrame(trace.FrameCount - 1).GetFileLineNumber() + " - " + "Column: " + trace.GetFrame(trace.FrameCount - 1).GetFileColumnNumber();
            if (!IsFileLocked(new FileInfo(GlobalVariables.LogPath)))
            {
                using (StreamWriter Stm_LogText = new StreamWriter(GlobalVariables.LogPath, append: true))
                {
                    try
                    {
                        Stm_LogText.WriteLine(LogText);
                    }
                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        Stm_LogText.Flush();
                        Stm_LogText.Close();
                        Stm_LogText.Dispose();
                    }
                }
            }
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                if (file.Exists)
                {
                    stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Write);
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }





    }


}
