using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySerializableConverterLib
{
    // helper function
    public class MdCore
    {
        // checks if an object is a list or something similar
        public static bool IsEnumerable(object input)
        {
            bool output = false;
            if (input != null)
            {
                if (input.GetType().IsGenericType && input is System.Collections.IEnumerable)
                {
                    output = true;
                }
            }
            return output;
        }
    }
}
