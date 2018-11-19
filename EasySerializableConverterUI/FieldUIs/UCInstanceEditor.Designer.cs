namespace EasySerializableConverterUI.FieldUIs
{
    partial class UCInstanceEditor
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
            this.FLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FLPMain
            // 
            this.FLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPMain.AutoScroll = true;
            this.FLPMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPMain.Location = new System.Drawing.Point(4, 23);
            this.FLPMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FLPMain.Name = "FLPMain";
            this.FLPMain.Size = new System.Drawing.Size(588, 527);
            this.FLPMain.TabIndex = 0;
            this.FLPMain.WrapContents = false;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(94, 2);
            this.TBName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(222, 22);
            this.TBName.TabIndex = 1;
            this.TBName.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language Name:";
            // 
            // UCInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.FLPMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCInstanceEditor";
            this.Size = new System.Drawing.Size(592, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPMain;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
    }
}
