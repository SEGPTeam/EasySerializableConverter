using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasySerializableConverterLib;
namespace EasySerializableConverterUI
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            MessageBox.Show(MdCore.IsEnumerable(new List<object>()).ToString());
        }
    }
}
