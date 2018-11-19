using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Script.Serialization;
using System.IO;
using System.Windows.Forms;

namespace EasySerializableConverterLib
{
    class CreateJson
    {

        public void Json<T>(T obj,string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            var json = new JavaScriptSerializer().Serialize(obj);
            Console.WriteLine(json);

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);

            }
        }

        //For testing data use
        public void function1()
        {
            MyDate aaa = new MyDate();
            Json<MyDate>(aaa, @"C:\json.txt");
            
        }

    }

    public class MyDate
    {
        public int year;
        public int month;
        public int day;
    }

    public class Lad
    {
        public string firstName;
        public string lastName;
        public MyDate dateOfBirth;
    }

}
