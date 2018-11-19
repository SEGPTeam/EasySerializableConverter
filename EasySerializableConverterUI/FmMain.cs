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
        public ClClass InputClass { get; set; }
        public FmMain()
        {
            InitializeComponent();
            
        }
        

        private void BtnTestA_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "javascript(*.js) | *.js";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var ljson = new LoadJsFile();
                InputClass = ljson.ReadJSFile(ofd.FileName);
                button1.PerformClick();

            }
        }

        private void BtnTestB_Click(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        public List<FieldUIs.UCInstanceEditor> LanguageList { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (InputClass != null)
            {
                var ucie = new FieldUIs.UCInstanceEditor(InputClass);
                ucie.Dock = DockStyle.Fill;
                var tp = new TabPage("Language " + tabControl1.TabPages.Count.ToString());
                tp.Controls.Add(ucie);
                tabControl1.TabPages.Add(tp);

            }
        }
    }
}
