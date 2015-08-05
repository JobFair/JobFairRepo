using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DAL
{
    /// <summary>
    /// Summary description for SqlHelper
    /// </summary>
    public class SqlHelper
    {
        //public SqlHelper()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //} cvbcvb

        string ConnectionString = string.Empty;

        static SqlConnection con;

        public SqlHelper()
        {

            ConnectionString = ConfigurationManager.ConnectionStrings["LogosPortalConnString"].ConnectionString;

            con = new SqlConnection(ConnectionString);

        }

        public void SetConnection()
        {

            if (ConnectionString == string.Empty)
            {

                ConnectionString = ConfigurationManager.ConnectionStrings["LogosPortalConnString"].ConnectionString;

            }

            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public DataSet ExecuteProcudere(string procName, Hashtable parms)
        {

            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.CommandText = procName;

            cmd.CommandType = CommandType.StoredProcedure;

            if (con == null)
            {

                SetConnection();

            }

            cmd.Connection = con;

            if (parms.Count > 0)
            {

                foreach (DictionaryEntry de in parms)
                {

                    cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);

                }

            }

            da.SelectCommand = cmd;

            da.Fill(ds);

            return ds;

        }

        public int ExecuteQuery(string procName, Hashtable parms)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = procName;

            if (parms.Count > 0)
            {

                foreach (DictionaryEntry de in parms)
                {

                    cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);

                }

            }

            if (con == null)
            {

                SetConnection();

            }

            cmd.Connection = con;

            if (con.State == ConnectionState.Closed)

                con.Open();

            int result = cmd.ExecuteNonQuery();

            return result;

        }

        public int ExecuteQuerywithOutputparams(SqlCommand cmd)
        {

            if (con == null)
            {

                SetConnection();

            }

            cmd.Connection = con;

            if (con.State == ConnectionState.Closed)

                con.Open();

            int result = cmd.ExecuteNonQuery();

            return result;

        }

        public int ExecuteQueryWithOutParam(string procName, Hashtable parms)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter sqlparam = new SqlParameter();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = procName;

            if (parms.Count > 0)
            {

                foreach (DictionaryEntry de in parms)
                {

                    if (de.Key.ToString().Contains("_out"))
                    {

                        sqlparam = new SqlParameter(de.Key.ToString(), de.Value);

                        sqlparam.DbType = DbType.Int32;

                        sqlparam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(sqlparam);

                    }

                    else
                    {

                        cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);

                    }

                }

            }

            if (con == null)
            {

                SetConnection();

            }

            cmd.Connection = con;

            if (con.State == ConnectionState.Closed)

                con.Open();

            int result = cmd.ExecuteNonQuery();

            if (sqlparam != null)

                result = Convert.ToInt32(sqlparam.SqlValue.ToString());

            return result;

        }
    }
}