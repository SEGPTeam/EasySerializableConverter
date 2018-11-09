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

        private void DeployClass(ClClass input)
        {
            FLPMain.Controls.Clear();
            InputClass = input;
            foreach (var ele in input.Fields)
            {
                if (ele.GetType() == typeof(ClEnumerableField))
                {
                    var uc = new FieldUIs.UCEnumerableUI(ele);
                    uc.Parent = FLPMain;
                }
                else
                {

                    var uc = new FieldUIs.UCPrimitiveUI(ele);
                    uc.Parent = FLPMain;
                }
            }
        }

        //TODO these should be removed and replaced with a source file (.js .ts .cs) reader that outputs a ClClass instance.
        private void BtnTestA_Click(object sender, EventArgs e)
        {
            DeployClass(TTestData.CreateTestClassPrimitive());
        }

        private void BtnTestB_Click(object sender, EventArgs e)
        {
            DeployClass(TTestData.CreateTestClassEnumerable());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var output = new ClClassData(TBInstanceName.Text, InputClass.ClassName, new List<ClFieldData>(), new List<ClEnumerableFieldData>());

            bool error = false;
            foreach (Control c in FLPMain.Controls)
            {
                if (c is FieldUIs.UCPrimitiveUI)
                {
                    if ((c as FieldUIs.UCPrimitiveUI).Error == true)
                    {
                        error = true;
                    }
                }
                else if (c is FieldUIs.UCEnumerableUI)
                {

                    if ((c as FieldUIs.UCEnumerableUI).Error == true)
                    {
                        error = true;
                    }
                }
            }
            

            if (!error) // if there are no errors
            {

                foreach (Control c in FLPMain.Controls)
                {
                    if (c is FieldUIs.UCPrimitiveUI)
                    {
                        output.FieldDatas.Add((c as FieldUIs.UCPrimitiveUI).OutputData());
                    }
                    else if (c is FieldUIs.UCEnumerableUI)
                    {
                        output.EnumerableFieldDatas.Add((c as FieldUIs.UCEnumerableUI).OutputData());
                    }
                }
                //Now output is ready to be serialized

                var sfd = new SaveFileDialog();
                sfd.Filter = "XML file as txt (*.txt)|*.txt|XML file as xml (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MdCore.Serialize<ClClassData>(output, sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("Error: there are syntax errors in the instance editor.");
            }
        }
    }
}
