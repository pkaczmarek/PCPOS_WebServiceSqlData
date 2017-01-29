using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PCPOS_WebServiceSqlData
{
    public class ReadCFGFromXml
    {
        public Information ReadCFG()
        {
          
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream(@"E:\PIERO\PRG\proj_VS2015\PCPOS_WebServiceSqlData\PCPOS_WebServiceSqlData\cfg.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);

            

            return info;
        }

    }
}