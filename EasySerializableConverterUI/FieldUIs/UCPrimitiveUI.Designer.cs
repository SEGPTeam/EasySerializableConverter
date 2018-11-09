namespace EasySerializableConverterUI.FieldUIs
{
    partial class UCPrimitiveUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LFieldType = new System.Windows.Forms.Label();
            this.LFieldName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LFieldWarning = new System.Windows.Forms.Label();
            this.TBFieldData = new System.Windows.Forms.TextBox();
            this.TLPMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMain
            // 
            this.TLPMain.ColumnCount = 2;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Controls.Add(this.panel1, 0, 0);
            this.TLPMain.Controls.Add(this.panel2, 1, 0);
            this.TLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMain.Location = new System.Drawing.Point(0, 0);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 1;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Size = new System.Drawing.Size(578, 55);
            this.TLPMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LFieldType);
            this.panel1.Controls.Add(this.LFieldName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 49);
            this.panel1.TabIndex = 1;
            // 
            // LFieldType
            // 
            this.LFieldType.AutoSize = true;
            this.LFieldType.Location = new System.Drawing.Point(3, 26);
            this.LFieldType.Name = "LFieldType";
            this.LFieldType.Size = new System.Drawing.Size(35, 13);
            this.LFieldType.TabIndex = 2;
            this.LFieldType.Text = "label3";
            // 
            // LFieldName
            // 
            this.LFieldName.AutoSize = true;
            this.LFieldName.Location = new System.Drawing.Point(3, 6);
            this.LFieldName.Name = "LFieldName";
            this.LFieldName.Size = new System.Drawing.Size(35, 13);
            this.LFieldName.TabIndex = 0;
            this.LFieldName.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LFieldWarning);
            this.panel2.Controls.Add(this.TBFieldData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(128, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 49);
            this.panel2.TabIndex = 2;
            // 
            // LFieldWarning
            // 
            this.LFieldWarning.AutoSize = true;
            this.LFieldWarning.ForeColor = System.Drawing.Color.Red;
            this.LFieldWarning.Location = new System.Drawing.Point(3, 26);
            this.LFieldWarning.Name = "LFieldWarning";
            this.LFieldWarning.Size = new System.Drawing.Size(35, 13);
            this.LFieldWarning.TabIndex = 1;
            this.LFieldWarning.Text = "label2";
            this.LFieldWarning.TextChanged += new System.EventHandler(this.LFieldWarning_TextChanged);
            // 
            // TBFieldData
            // 
            this.TBFieldData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBFieldData.Location = new System.Drawing.Point(0, 3);
            this.TBFieldData.Name = "TBFieldData";
            this.TBFieldData.Size = new System.Drawing.Size(444, 20);
            this.TBFieldData.TabIndex = 1;
            this.TBFieldData.TextChanged += new System.EventHandler(this.TBFieldData_TextChanged);
            // 
            // UCPrimitiveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TLPMain);
            this.Name = "UCPrimitiveUI";
            this.Size = new System.Drawing.Size(578, 55);
            this.TLPMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TLPMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LFieldType;
        private System.Windows.Forms.Label LFieldName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LFieldWarning;
        private System.Windows.Forms.TextBox TBFieldData;
    }
}
