using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace utils
{
    [Serializable]
    [XmlRoot]
    public class Context
    {
        [XmlElement]
        public string pt_context = "true"; 
        [XmlArray]
        public double[] Xarr;
        [XmlArray]
        public double[] Yarr;
        public Context()
        {
            this.Xarr = new double[1];
            this.Yarr = new double[1];
        }
        public Context(double[] sourceXarray, double[] sourceYarray)
        {
            this.Xarr = sourceXarray;
            this.Yarr = sourceYarray;
        }
    }
}
