using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCPOS_WebServiceSqlData
{
    public class DBConnection
    {
        public string cn;
        public DBConnection(string ip, string sqluser, string password )
        {

            cnset(ip, sqluser, password);
            

        }

        //public string  connectionstring
        //{
        //    get
        //    {
        //        return cn;
        //    }
        //    set
        //    {
        //        cn = cnset(ip, sqluser, password);
        //    }
        //}
        private string cnset(string ip, string sqluser, string password)
        {
            
            return cn = "Data Source=" + ip + ";Initial Catalog=pcpos7;User ID=" + sqluser + ";Password=" + password + "";
        }
    }
}