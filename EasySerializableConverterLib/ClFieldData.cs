using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClFieldData
    {
        public string FieldName { get; set; }
        public object FieldData { get; set; }

        public ClFieldData(ClField fieldType, object fieldData)
        {
            FieldName = fieldType.Name;
            FieldData = fieldData;
        }

        public ClFieldData(ClField fieldInfo) : this(fieldInfo, Activator.CreateInstance(fieldInfo.FieldType))
        {

        }

        public ClFieldData() : this(new ClField())
        {

        }


    }
}
