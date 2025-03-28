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

    }
}
