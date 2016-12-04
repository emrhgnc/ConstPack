using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SqlHelper
    {

        public SqlConnection conn = new SqlConnection(@"Server=94.73.170.2;Database=DB_CONSTPACK;User Id=CONSTPACK;Password=PKgw97M5;");

        public static SqlCommand cmd { get; set; }

        public bool open()
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    result = true;
                }
                else
                {
                    result = true;
                }
            }
            catch (Exception)
            {

            }
            return result;
        }
        public bool close()
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    result = true;
                }
                else
                {
                    result = true;
                }
            }
            catch (Exception)
            {

            }
            return result;
        }
        public bool prepareCommand(string cmdText, CommandType cmdType, SqlParameter[] prms)
        {
            bool result = false;
            try
            {
                cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = cmdType;
                if (prms != null)
                {
                    if (prms.Length > 0)
                    {

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddRange(prms);
                    }
                }
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        public bool prepareCommand(string cmdText, CommandType cmdType)
        {
            bool result = false;
            try
            {
                cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = cmdType;

                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        public int runCommandNonQuery()
        {
            int result = 0;

            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public object runCommandScalar()
        {
            object result = null;

            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public SqlDataReader runCommandReturnReader()
        {
            SqlDataReader dr = null;

            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dr;
        }
        public SqlDataAdapter runCommandReturnAdapter()
        {
            SqlDataAdapter da = null;
            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    da = new SqlDataAdapter(cmd);
                    SqlConnection.ClearAllPools();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return da;
        }
        public DataTable runCommandReturnDataTable()
        {
            DataTable dt = null;
            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    SqlDataAdapter da = runCommandReturnAdapter();
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }
}
