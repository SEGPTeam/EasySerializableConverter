using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    // helper class for testing this system until a .js, .ts, and .cs parser is completed.
    public class TTestData
    {
        public static ClClass CreateTestClassPrimitive()
        {
            var output = new ClClass("Primitive Class");

            output.Fields.Add(new ClField("Int Field", typeof(int)));
            output.Fields.Add(new ClField("Byte Field", typeof(byte)));
            output.Fields.Add(new ClField("String Field", typeof(string)));
            output.Fields.Add(new ClField("Float Field", typeof(float)));

            return output;
        }


        public static ClClass CreateTestClassEnumerable()
        {
            var output = new ClClass("Class With Enumerable");

            output.Fields.Add(new ClField("Int Field", typeof(int)));
            output.Fields.Add(new ClField("Byte Field", typeof(byte)));
            output.Fields.Add(new ClField("String Field", typeof(string)));
            output.Fields.Add(new ClEnumerableField("List Int Field", typeof(int)));

            return output;
        }
    }
}
