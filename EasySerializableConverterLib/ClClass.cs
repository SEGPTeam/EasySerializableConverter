using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClClass
    {
        // props
        public string ClassName { get; set; }
        public List<ClField> Fields { get; set; }

        //TODO does this need a list of methods?

        // constructors
        public ClClass(string className, List<ClField> fields)
        {
            ClassName = className;

            Fields = new List<ClField>();
            foreach (var f in fields) // clones fields byVal to Field
            {
                Fields.Add(f);
            }
        }

        public ClClass(string className) : this(className, new List<ClField>())
        {
            ClassName = className;
        }

        public ClClass() : this ("Unnamed Class", new List<ClField>())
        {

        }


    }
}
