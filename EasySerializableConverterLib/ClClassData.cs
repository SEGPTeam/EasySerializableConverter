using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClClassData
    {
        public string ClassName { get; set; }
        public string InstanceName { get; set; }
        public List<ClFieldData> FieldDatas { get; set; }
        public List<ClEnumerableFieldData> EnumerableFieldDatas { get; set; }


        public ClClassData(string instanceName, string className, List<ClFieldData> fieldDatas, List<ClEnumerableFieldData> enumerableFieldDatas)
        {
            ClassName = className;
            InstanceName = instanceName;

            FieldDatas = new List<ClFieldData>();
            foreach (var f in fieldDatas) // clones fieldDatas byVal to FieldData
            {
                FieldDatas.Add(f);
            }
            EnumerableFieldDatas = new List<ClEnumerableFieldData>();
            foreach (var ef in enumerableFieldDatas)
            {
                EnumerableFieldDatas.Add(ef);
            }
        }

        public ClClassData(string instanceName, ClClass classType) : this(instanceName, classType.ClassName, new List<ClFieldData>(), new List<ClEnumerableFieldData>())
        {
            foreach (var f in classType.Fields)
            {
                FieldDatas.Add(new ClFieldData(f)); // populates field data list with new instances constructed from field data
            }
        }

        public ClClassData(ClClass classType) : this ("Unnamed Instance", classType)
        {

        }

        public ClClassData() : this ("Unnamed Instance", new ClClass())
        {

        }
    }
}
