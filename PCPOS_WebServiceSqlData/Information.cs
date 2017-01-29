using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCPOS_WebServiceSqlData
{
    public class Information
    {
        private string sqlsrv;
        private string dbname;
        private string userid;
        private string password;
        private string trusted_connection;

        public string SQLSRV
        {
            get { return sqlsrv; }
            set { sqlsrv = value; }
        }

        public string DBNAME
        {
            get { return dbname; }
            set { dbname = value; }
            //zmiana repozytorium git ???
        }

        public string UserId
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string TRUSTED_CONNECTION
        {
            get { return trusted_connection; }
            set { trusted_connection = value; }
        }


    }
}