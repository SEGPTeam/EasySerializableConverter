using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace EasySerializableConverterLib
{
    // helper function
    public class MdCore
    {
        // checks if an object is a list or something similar
        public static bool IsEnumerableObject(object input)
        {
            bool output = false;
            if (input != null)
            {
                if (input.GetType().IsGenericType && input is System.Collections.IEnumerable)
                {
                    output = true;
                }
            }
            return output;
        }

        public static bool IsEnumerableType(Type input)
        {
            bool output = false;
            if (input != null)
            {
                if (typeof(System.Collections.IEnumerable).IsAssignableFrom(input))
                {
                    output = true;
                }
            }
            return output;
        }



        //TODO We will want to replace these with custom serialisers
        public static void Serialize<T>(T obj, string path)
        {
            var sw = new StreamWriter(path, false);
            var ser = new XmlSerializer(typeof(T));
            ser.Serialize(sw, obj);
            sw.Close();
        }

        public static T Deserialize<T>(string path)
        {
            var sr = new StreamReader(path);
            var ser = new XmlSerializer(typeof(T));
            var output = (T)ser.Deserialize(sr);

            sr.Close();
            return output;
        }
    }
}
