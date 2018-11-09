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
    public partial class UCEnumerableUI : UserControl
    {
        public ClField FieldType { get; set; }
        public List<object> FieldData { get; set; }
        public bool Error { get; set; }

        public UCEnumerableUI()
        {
            FieldData = new List<object>();
            LFieldWarning.Text = "";
            Error = false;
            InitializeComponent();

        }
        public UCEnumerableUI(ClField fieldType, List<object> fieldData)
        {

            FieldType = fieldType;
            FieldData = new List<object>();
            foreach (var ele in fieldData)
            {
                fieldData.Add(ele);
            }
            InitializeComponent();
            LFieldName.Text = FieldType.Name;
            LFieldType.Text = fieldType.FieldType.Name;
            LFieldWarning.Text = "";
            Error = false;
            foreach (var ele in FieldData)
            {
                TBFieldData.Text = ele.ToString() + ", ";
            }
            if (FieldData.Count > 0)
            {
                TBFieldData.Text = TBFieldData.Text.Substring(0, TBFieldData.Text.Length - 2);
            }
            
        }
        public UCEnumerableUI(ClField fieldType) : this(fieldType, new List<object>())
        {

        }

        private void TBFieldData_TextChanged(object sender, EventArgs e)
        {
            FieldData.Clear();
            if (TBFieldData.Text == "")
            {
                LFieldWarning.Text = "";
            }
            else
            {
                try
                {
                    var splittedDatas = TBFieldData.Text.Replace(" ", "").Split(',').ToList();
                    foreach(var si in splittedDatas)
                    {
                        FieldData.Add(Convert.ChangeType(si, FieldType.FieldType));
                    }
                    LFieldWarning.Text = "";
                }
                catch (Exception ex)
                {
                    LFieldWarning.Text = ex.Message;
                }
            }
        }

        public void SetIndicatorWidth(int input)
        {
            TLPMain.ColumnStyles[0].Width = input;
        }

        private void BtnEditor_Click(object sender, EventArgs e)
        {
            //TODO HERE
        }

        private void LFieldWarning_TextChanged(object sender, EventArgs e)
        {
            if (LFieldWarning.Text != "")
            {
                Error = true;
            }
            else
            {
                Error = false;
            }
        }


        public ClEnumerableFieldData OutputData()
        {
            return new ClEnumerableFieldData(FieldType, FieldData);
        }
    }
}
