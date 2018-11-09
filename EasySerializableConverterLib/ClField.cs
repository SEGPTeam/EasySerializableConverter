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
        public ClField()
        {
            //TODO
        }

        public ClField(string name, Type fieldType) : this()
        {
            Name = name;
            FieldType = fieldType;
        }
    }
}
