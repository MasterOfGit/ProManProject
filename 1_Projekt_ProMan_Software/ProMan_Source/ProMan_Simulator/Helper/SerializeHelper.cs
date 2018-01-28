using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace ProMan_Simulator.Helper
{
    public static class SerializeHelper
    {
        public static string XmlSerialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var Serializer = new XmlSerializer(typeof(T));
                Serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string JSonSerialize<T>(T dataToSerialize)
        {
            try
            {
                T data = new JavaScriptSerializer().Deserialize<T>(dataToSerialize.ToString());

                var stringwriter = new System.IO.StringWriter();
                var Serializer = new XmlSerializer(typeof(T));
                Serializer.Serialize(stringwriter, data);
                return stringwriter.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
