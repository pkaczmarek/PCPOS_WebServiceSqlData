using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PCPOS_Dane_WF
{
    class SqlConn
    {
        public static SqlConnection cn = null;
        private string constring;

        

        public void SqlConOpen(string srv, string db, string usr, string pass)
        {
            
            
            constring = "Data Source=" + srv + ";Initial Catalog=" + db + ";User ID=" + usr + ";Password=" + pass;
            cn.ConnectionString = constring;
            cn.Open();

        }
    }
}
