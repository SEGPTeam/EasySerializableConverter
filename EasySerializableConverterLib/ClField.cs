using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClField
    {
        public string Name { get; set; }
        public Type FieldType { get; set; }

        public ClField(string name, Type fieldType)
        {
            Name = name;
            FieldType = fieldType;
        }


        public ClField() : this("Unnamed Field", typeof(object))
        {

        }

        public ClField(ClField input)
        {
            Name = input.Name;
            FieldType = input.FieldType;
        }

    }
}
