using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasySerializableConverterLib;

namespace EasySerializableConverterUI
{
    public partial class UCInstanceEditor : UserControl
    {
        public UCInstanceEditor()
        {
            InitializeComponent();
        }

        public ClClassData OutputInstance()
        {
            var output = new ClClassData();
            return output;
        }
    }
}
