using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClFieldData
    {
        public ClField FieldInfo { get; set; }
        public object FieldData { get; set; }

        public ClFieldData(ClField fieldInfo, object fieldData)
        {
            FieldInfo = fieldInfo;
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
