namespace EasySerializableConverterUI
{
    partial class FmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.FLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnTestA = new System.Windows.Forms.Button();
            this.BtnTestB = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBInstanceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FLPMain
            // 
            this.FLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPMain.Location = new System.Drawing.Point(16, 50);
            this.FLPMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FLPMain.Name = "FLPMain";
            this.FLPMain.Size = new System.Drawing.Size(1124, 556);
            this.FLPMain.TabIndex = 0;
            this.FLPMain.WrapContents = false;
            // 
            // BtnTestA
            // 
            this.BtnTestA.Location = new System.Drawing.Point(16, 15);
            this.BtnTestA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTestA.Name = "BtnTestA";
            this.BtnTestA.Size = new System.Drawing.Size(235, 28);
            this.BtnTestA.TabIndex = 1;
            this.BtnTestA.Text = "Load tes with primitive data types";
            this.BtnTestA.UseVisualStyleBackColor = true;
            this.BtnTestA.Click += new System.EventHandler(this.BtnTestA_Click);
            // 
            // BtnTestB
            // 
            this.BtnTestB.Location = new System.Drawing.Point(259, 15);
            this.BtnTestB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTestB.Name = "BtnTestB";
            this.BtnTestB.Size = new System.Drawing.Size(297, 28);
            this.BtnTestB.TabIndex = 2;
            this.BtnTestB.Text = "Load test with enumerable";
            this.BtnTestB.UseVisualStyleBackColor = true;
            this.BtnTestB.Click += new System.EventHandler(this.BtnTestB_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(1040, 614);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 28);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Instance Name:";
            // 
            // TBInstanceName
            // 
            this.TBInstanceName.Location = new System.Drawing.Point(723, 17);
            this.TBInstanceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBInstanceName.Name = "TBInstanceName";
            this.TBInstanceName.Size = new System.Drawing.Size(327, 22);
            this.TBInstanceName.TabIndex = 6;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 657);
            this.Controls.Add(this.TBInstanceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnTestB);
            this.Controls.Add(this.BtnTestA);
            this.Controls.Add(this.FLPMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmMain";
            this.Text = "EasySerializableConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPMain;
        private System.Windows.Forms.Button BtnTestA;
        private System.Windows.Forms.Button BtnTestB;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBInstanceName;
    }
}

