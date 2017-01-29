using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows.Forms;

namespace PCPOS_WebServiceSqlData
{
    /// <summary>
    /// Summary description for PCPOS_DataFromSql
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PCPOS_DataFromSql : System.Web.Services.WebService
    {
        string connectionstring;
        string sqluser;
        string password;
        private string ustawpol(string ip, string sqluser, string password)
        { string cn;
            DBConnection pol = new DBConnection(ip, sqluser, password);
            cn = pol.cn;
            return cn;
        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet PcPosParagony(string ip)
        {
            DataTable dt = new DataTable();
            string constring;
            // constring = @"Data Source=" + ip + ";database=PCPOS7;user=sa;Password=Kq13zap805";
            constring = "Data Source=" + ip + ";Initial Catalog=pcpos7;User ID=sa;Password=Kq13zap805";
            //ustawpol(ip, sqluser, password);
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constring;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM[pcpos7].[dbo].[Receipt] where [Type] = 1", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        [WebMethod]
        public DataSet PcPosParDaty(string ip, string DataStart, string DataStop)
        {
            DataTable dt = new DataTable();
            string constring;
            // constring = @"Data Source=" + ip + ";database=PCPOS7;user=sa;Password=Kq13zap805";
            constring = "Data Source=" + ip + ";Initial Catalog=pcpos7;User ID=sa;Password=Kq13zap805";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constring;
            // rzutowanie stringów na datatime

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [pcpos7].[dbo].[Receipt] where [Type] = 1 and OperationDate between CAST('" + DataStart + "' AS DATETIME) and CAST('" + DataStop + "' AS DATETIME)", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        [WebMethod]
        public DataSet PcPosParItems(string ip, int posid, int receiptid)
        {
            string sqlstr = "SELECT[PosId],[ReceiptItemId],[ReceiptId],[ProductId],[VatRate],[ProductType],[BasePrice],[Price],[DiscountType],[DiscountValue],[Quantity],[TotalBrutto],[TotalNetto],[TotalDiscount],[IsStorno],[IsReturn],[Barcode],[ItemType],[RemainingQuantity],[SellPrice],[PriceMin],[DiscountedPrice],[CalcType],[ExpireDate],[ExternalId],[LotId],[LotNr],[ExtReceiptItemId],[PriceLevel] FROM[pcpos7].[dbo].[ReceiptItem] where [PosId] = " + posid + " and [ReceiptId] = " + receiptid;
            DataTable dt = new DataTable();
            string constring;
            constring = "Data Source=" + ip + ";Initial Catalog=pcpos7;User ID=sa;Password=Kq13zap805";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constring;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        [WebMethod]
        public void ListaSklepow()
        {
            // najpierw pobierz dane z pliku config'u o bazie danych z listą sklepów - 
            ZapiszKonfig();
        }

        [WebMethod]
        public Information WebMetOdczytajKonfig()
        {
            Information cfg = new Information();

            cfg = OdczytajKonfig();
            return cfg;
        }


        public void ZapiszKonfig()
        {


            try
            {
                Information info = new Information();
                info.SQLSRV = @"ADMNETLAP\SQLEXPRESS2014";
                info.DBNAME = "DBCONPCPOS";
                info.UserId = "sasa";
                info.Password = "Bosman72";
                info.TRUSTED_CONNECTION = "Yes";
                string filename_ = @"E:\PIERO\PRG\proj_VS2015\PCPOS_WebServiceSqlData\PCPOS_WebServiceSqlData\cfg.xml";
                SaveXMLCFG.SaveData(info, filename_);


            }
            catch (Exception ex)
            {

            }


        }


        [WebMethod]
        public DataSet WebMetOdczytajListęSklepów()
        {
            //pobierz dane do połaczenia z konfigu- xml'a
            Information info = new Information();
            info = OdczytajKonfig();
            // jak juz masz dane o dostępie do bazy to pobieramy dane z tabelki 

            string sqlstr = "SELECT (cast([Sklep_ZAKŁAD] as nchar(4)) + '/' + rtrim([IPADDRESS]) +'/' + [SklepNazwa]) as ZakładIpNazwaSklepu, [Sklep_ZAKŁAD],[IPADDRESS],[SklepNazwa],[SklepNazwaDługa],[NazwaBazyDanych],[UserDB],[PasswordDB] FROM [DBCONPCPOS].[dbo].[Sklepy]";
            DataTable dt = new DataTable();
            string constring;
            //constring = "Data Source=" + info.SQLSRV + ";Initial Catalog=" + info.DBNAME + ";User ID=" + info.UserId + ";Password="+ info.Password;
            constring = "Data Source=" + info.SQLSRV + ";Initial Catalog=" + info.DBNAME + ";Trusted_Connection=" + info.TRUSTED_CONNECTION;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constring;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
        [WebMethod]
        public DataSet WebMetDostępDB(string ipsrv)
        {
            //pobierz dane do połaczenia z konfigu- xml'a
            Information info = new Information();
            info = OdczytajKonfig();
            // jak juz masz dane o dostępie do bazy to pobieramy dane z tabelki 

            string sqlstr = "SELECT [SQLUSER],[PASSWORD],[IPSRV] FROM [DBCONPCPOS].[dbo].[sqlusers] where IPSRV = '" + ipsrv + "'";
            DataTable dt = new DataTable();
            string constring;
            constring = "Data Source=" + info.SQLSRV + ";Initial Catalog=" + info.DBNAME + ";User ID=" + info.UserId + ";Password=" + info.Password;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constring;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }



        public Information OdczytajKonfig()
        {
            Information cfg = new Information();

            ReadCFGFromXml readcfg = new ReadCFGFromXml();
            cfg = readcfg.ReadCFG();

            return cfg;
        }

    }

}
