﻿using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FunctionalAreaDAL
    { 
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public DataTable GetFunctionalDAL()
        {
            { 
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from FunctionalArea", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            }
        }
    }


}
