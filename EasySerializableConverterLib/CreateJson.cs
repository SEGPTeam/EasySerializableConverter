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
        //Create a Json file with obj data to user select path
        public void Json<T>(T obj,string path)
        {
            // use Json serializer 
            // create setting
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            var json = new JavaScriptSerializer().Serialize(obj);
            Console.WriteLine(json);

            //use streawriter to write
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);

            }
        }

        //For testing data use
        public void CallJson(string path)
        {
            MyDate Mydate1 = new MyDate();
            Json<MyDate>(Mydate1, path);
            
        }

    }
    //Testing data class my data
    public class MyDate
    {
        public int year;
        public int month;
        public int day;
    }

    //Testing data lad
    public class Lad
    {
        public string firstName;
        public string lastName;
        public MyDate dateOfBirth;
    }


}
