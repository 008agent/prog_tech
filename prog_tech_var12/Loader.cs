using System;
using System.Collections.Generic;
using System.Text;
using utils;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace utils
{
    class Loader
    {
        public static Context loadXML(string fname)
        {
            Context Ctx = new Context();
            try
            {
                XmlReader xml = XmlReader.Create(fname);
                XmlSerializer XmlS = new XmlSerializer(Ctx.GetType());
                if (XmlS.CanDeserialize(xml))
                {
                    Ctx = (Context)XmlS.Deserialize(xml);
                    xml.Close();

                }
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
                Ctx = null;
            }
            return Ctx;
        }

        public static bool saveXML(Context Ctx,string fname)
        {
            try
            {
                XmlWriter xml = XmlWriter.Create(fname);
                XmlSerializer xmls = new XmlSerializer(Ctx.GetType());
                xmls.Serialize(xml, Ctx);
                xml.Close();
                return true;
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
            }
            return false;
        }
    }
}
