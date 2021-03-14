﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnTestApp
{
    class DBhelper 
    {
        public IDbConnection GetDbconnection()
        {
            IDbConnection dbConn = null;
            string connString = ConfigurationManager.AppSettings["Connection"];
            var DBtype = ConfigurationManager.AppSettings["DbType"];
            switch (DBtype)
            {
                case "SQLServer":
                    dbConn = new SqlConnection(connString);
                    break;
                case "Oracle":
                    dbConn = new OracleConnection(connString);
                    break;
                case "OleDB":
                    dbConn = new OleDbConnection(connString);
                    break;
                default:
                    break;
            }
            return dbConn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
