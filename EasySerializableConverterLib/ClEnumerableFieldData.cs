using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClEnumerableFieldData
    {
        public string FieldName { get; set; }
        public List<object> FieldDatas { get; set; }

        public ClEnumerableFieldData(ClField fieldType, List<object> fieldData)
        {
            FieldName = fieldType.Name;
            FieldDatas = new List<object>();
            foreach (var obj in fieldData)
            {
                FieldDatas.Add(obj);
            }
        }

        public ClEnumerableFieldData(ClField fieldInfo) : this(fieldInfo, new List<object>())
        {

        }

        public ClEnumerableFieldData() : this(new ClField())
        {

        }
    }
}
