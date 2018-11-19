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
            LanguageList = new List<FieldUIs.UCInstanceEditor>();
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
            var ofd = new OpenFileDialog();
            ofd.Filter = "C# source code(*.cs) | *.cs";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var ljson = new LoadJsFile();
                InputClass = ljson.ReadJSFile(ofd.FileName);
                button1.PerformClick();

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var outputList = new List<ClClassData>();
            var error = false;
            if (outputList != null)
            {

                foreach (var ele in LanguageList)
                {
                    if (ele.OutputInstance() != null)
                    {
                        outputList.Add(ele.OutputInstance());

                    }
                    else
                    {
                        error = true;
                    }
                }
                if (!error)
                {
                    var sfd = new SaveFileDialog();
                    sfd.Filter = "XML as .txt (*.txt)|*.txt|XML as .xml (*.xml)|*.xml";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var ele in outputList)
                        {
                            string path = sfd.FileName.Substring(0, sfd.FileName.Length - 4) + " " + ele.InstanceName + sfd.FileName.Substring(sfd.FileName.Length - 4);
                            MdCore.Serialize<ClClassData>(ele, path);
                        }
                    }
                }
            }
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
                LanguageList.Add(ucie);

            }
        }
    }
}
