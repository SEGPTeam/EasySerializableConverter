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
namespace EasySerializableConverterUI.FieldUIs
{
    public partial class UCIntegerUI : UserControl
    {
        public ClField FieldType { get; set; }
        public object FieldData { get; set; }
        public UCIntegerUI()
        {
            InitializeComponent();

        }
    }
}
