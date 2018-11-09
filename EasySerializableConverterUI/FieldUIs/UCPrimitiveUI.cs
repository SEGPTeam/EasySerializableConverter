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
    public partial class UCPrimitiveUI : UserControl
    {
        public ClField FieldType { get; set; }
        public object FieldData { get; set; }
        public bool Error { get; set; }
        public UCPrimitiveUI()
        {
            FieldData = null;
            LFieldWarning.Text = "";
            InitializeComponent();

        }
        public UCPrimitiveUI(ClField fieldType, object fieldData)
        {

            FieldType = fieldType;
            FieldData = fieldData;
            InitializeComponent();
            LFieldName.Text = FieldType.Name;
            LFieldType.Text = fieldType.FieldType.Name;
            LFieldWarning.Text = "";
            if (FieldData != null)
            {
                TBFieldData.Text = FieldData.ToString();
            }
            
        }
        public UCPrimitiveUI(ClField fieldType) : this(fieldType, null)
        {

        }

        private void TBFieldData_TextChanged(object sender, EventArgs e)
        {
            if (TBFieldData.Text == "")
            {
                FieldData = null;
                LFieldWarning.Text = "";
            }
            else
            {
                try
                {
                    FieldData = Convert.ChangeType(TBFieldData.Text, FieldType.FieldType);
                    LFieldWarning.Text = "";
                }
                catch (Exception ex)
                {
                    LFieldWarning.Text = ex.Message;
                    //MessageBox.Show("Overflow exception!");
                    //TBFieldData.Text = FieldData?.ToString() ?? "";
                }
            }
        }

        public void SetIndicatorWidth(int input)
        {
            TLPMain.ColumnStyles[0].Width = input;
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

        public ClFieldData OutputData()
        {
            return new ClFieldData(FieldType, FieldData);
        }
    }
}
