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
    public partial class UCInstanceEditor : UserControl
    {
        public ClClass InputClass { get; set; }
        public UCInstanceEditor()
        {
            InitializeComponent();
        }

        public UCInstanceEditor(ClClass input) : this()
        {
            FLPMain.Controls.Clear();
            InputClass = input;
            foreach (var ele in input.Fields)
            {
                if (ele.GetType() == typeof(ClEnumerableField))
                {
                    var uc = new UCEnumerableUI(ele);
                    uc.Parent = FLPMain;
                }
                else
                {

                    var uc = new UCPrimitiveUI(ele);
                    uc.Parent = FLPMain;
                }
            }
        }

        public ClClassData OutputInstance()
        {
            var output = new ClClassData(TBName.Text, InputClass.ClassName, new List<ClFieldData>(), new List<ClEnumerableFieldData>());

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
                return output;
            }
            else
            {
                MessageBox.Show("Error: there are syntax errors in the instance editor.");
                return null;
            }
        }
    }
}
