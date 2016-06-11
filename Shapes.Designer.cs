namespace GeometricShapes
{
    partial class frmShapes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnCube = new System.Windows.Forms.RadioButton();
            this.radBtnSphere = new System.Windows.Forms.RadioButton();
            this.txtBxValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rchTxtBxOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnCube);
            this.groupBox1.Controls.Add(this.radBtnSphere);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a Shape";
            // 
            // radBtnCube
            // 
            this.radBtnCube.AutoSize = true;
            this.radBtnCube.Location = new System.Drawing.Point(15, 52);
            this.radBtnCube.Name = "radBtnCube";
            this.radBtnCube.Size = new System.Drawing.Size(50, 17);
            this.radBtnCube.TabIndex = 1;
            this.radBtnCube.TabStop = true;
            this.radBtnCube.Text = "Cube";
            this.radBtnCube.UseVisualStyleBackColor = true;
            this.radBtnCube.CheckedChanged += new System.EventHandler(this.radBtn_CheckedChanged);
            // 
            // radBtnSphere
            // 
            this.radBtnSphere.AutoSize = true;
            this.radBtnSphere.Location = new System.Drawing.Point(15, 19);
            this.radBtnSphere.Name = "radBtnSphere";
            this.radBtnSphere.Size = new System.Drawing.Size(59, 17);
            this.radBtnSphere.TabIndex = 0;
            this.radBtnSphere.TabStop = true;
            this.radBtnSphere.Text = "Sphere";
            this.radBtnSphere.UseVisualStyleBackColor = true;
            this.radBtnSphere.CheckedChanged += new System.EventHandler(this.radBtn_CheckedChanged);
            // 
            // txtBxValue
            // 
            this.txtBxValue.Location = new System.Drawing.Point(160, 78);
            this.txtBxValue.Name = "txtBxValue";
            this.txtBxValue.Size = new System.Drawing.Size(100, 20);
            this.txtBxValue.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(171, 44);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(92, 23);
            this.lblValue.TabIndex = 2;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(37, 262);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(171, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rchTxtBxOutput
            // 
            this.rchTxtBxOutput.Location = new System.Drawing.Point(37, 138);
            this.rchTxtBxOutput.Name = "rchTxtBxOutput";
            this.rchTxtBxOutput.Size = new System.Drawing.Size(209, 96);
            this.rchTxtBxOutput.TabIndex = 5;
            this.rchTxtBxOutput.Text = "";
            // 
            // frmShapes
            // 
            this.AcceptButton = this.btnSummary;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(292, 314);
            this.Controls.Add(this.rchTxtBxOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtBxValue);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShapes";
            this.Text = "Geometric Shapes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnCube;
        private System.Windows.Forms.RadioButton radBtnSphere;
        private System.Windows.Forms.TextBox txtBxValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rchTxtBxOutput;
    }
}

