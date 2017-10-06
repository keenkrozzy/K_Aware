namespace K_Aware
{
    partial class Form1
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
			this.lstbxTest = new System.Windows.Forms.ListBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnWriteXML = new System.Windows.Forms.Button();
			this.btnReadXML = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstbxTest
			// 
			this.lstbxTest.FormattingEnabled = true;
			this.lstbxTest.Location = new System.Drawing.Point(12, 12);
			this.lstbxTest.Name = "lstbxTest";
			this.lstbxTest.Size = new System.Drawing.Size(215, 797);
			this.lstbxTest.TabIndex = 1;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(309, 29);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 2;
			this.btnTest.Text = "Populate";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(343, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// btnWriteXML
			// 
			this.btnWriteXML.Location = new System.Drawing.Point(309, 119);
			this.btnWriteXML.Name = "btnWriteXML";
			this.btnWriteXML.Size = new System.Drawing.Size(75, 23);
			this.btnWriteXML.TabIndex = 4;
			this.btnWriteXML.Text = "Write";
			this.btnWriteXML.UseVisualStyleBackColor = true;
			this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
			// 
			// btnReadXML
			// 
			this.btnReadXML.Location = new System.Drawing.Point(309, 164);
			this.btnReadXML.Name = "btnReadXML";
			this.btnReadXML.Size = new System.Drawing.Size(75, 23);
			this.btnReadXML.TabIndex = 5;
			this.btnReadXML.Text = "Read";
			this.btnReadXML.UseVisualStyleBackColor = true;
			this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 820);
			this.Controls.Add(this.btnReadXML);
			this.Controls.Add(this.btnWriteXML);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.lstbxTest);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnWriteXML;
		private System.Windows.Forms.Button btnReadXML;
	}
}

