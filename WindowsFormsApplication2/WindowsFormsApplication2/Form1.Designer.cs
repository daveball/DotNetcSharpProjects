namespace WindowsFormsApplication2
{
    partial class WSEQuery
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
            this.button1 = new System.Windows.Forms.Button();
            this.WSQuery = new System.Windows.Forms.TextBox();
            this.QueryUPRNBtn = new System.Windows.Forms.TextBox();
            this.NonWSETest = new System.Windows.Forms.Button();
            this.QueryUPRN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "WSE Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WSQuery
            // 
            this.WSQuery.Location = new System.Drawing.Point(12, 69);
            this.WSQuery.Multiline = true;
            this.WSQuery.Name = "WSQuery";
            this.WSQuery.Size = new System.Drawing.Size(347, 181);
            this.WSQuery.TabIndex = 1;
            // 
            // QueryUPRNBtn
            // 
            this.QueryUPRNBtn.Location = new System.Drawing.Point(365, 14);
            this.QueryUPRNBtn.Multiline = true;
            this.QueryUPRNBtn.Name = "QueryUPRNBtn";
            this.QueryUPRNBtn.Size = new System.Drawing.Size(347, 236);
            this.QueryUPRNBtn.TabIndex = 2;
            // 
            // NonWSETest
            // 
            this.NonWSETest.Location = new System.Drawing.Point(125, 12);
            this.NonWSETest.Name = "NonWSETest";
            this.NonWSETest.Size = new System.Drawing.Size(100, 23);
            this.NonWSETest.TabIndex = 3;
            this.NonWSETest.Text = "Non WSE test";
            this.NonWSETest.UseVisualStyleBackColor = true;
            this.NonWSETest.Click += new System.EventHandler(this.NonWSETest_Click);
            // 
            // QueryUPRN
            // 
            this.QueryUPRN.Location = new System.Drawing.Point(231, 14);
            this.QueryUPRN.Name = "QueryUPRN";
            this.QueryUPRN.Size = new System.Drawing.Size(110, 23);
            this.QueryUPRN.TabIndex = 4;
            this.QueryUPRN.Text = "QueryUPRN";
            this.QueryUPRN.UseVisualStyleBackColor = true;
            this.QueryUPRN.Click += new System.EventHandler(this.QueryUPRN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WSEQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QueryUPRN);
            this.Controls.Add(this.NonWSETest);
            this.Controls.Add(this.QueryUPRNBtn);
            this.Controls.Add(this.WSQuery);
            this.Controls.Add(this.button1);
            this.Name = "WSEQuery";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WSQuery;
        private System.Windows.Forms.TextBox QueryUPRNBtn;
        private System.Windows.Forms.Button NonWSETest;
        private System.Windows.Forms.Button QueryUPRN;
        private System.Windows.Forms.Button button2;
    }
}

