using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    public class ClEnumerableField : ClField
    {
        public bool IsAnEnumerable { get; set; }

        public ClEnumerableField(string name, Type fieldType, bool isEnumerable = true) : base(name, fieldType)
        {
            IsAnEnumerable = isEnumerable;
        }
    }
}
