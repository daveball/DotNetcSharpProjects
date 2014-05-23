namespace SampleWebserviceClient
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
            this.UCRNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QueryUCRNUsingWapperBtn = new System.Windows.Forms.Button();
            this.QueryUCRNRequestMessagetxt = new System.Windows.Forms.TextBox();
            this.QueryUCRNBtn = new System.Windows.Forms.Button();
            this.UCRNResultstxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UCRNtxt
            // 
            this.UCRNtxt.Location = new System.Drawing.Point(65, 15);
            this.UCRNtxt.Name = "UCRNtxt";
            this.UCRNtxt.Size = new System.Drawing.Size(130, 20);
            this.UCRNtxt.TabIndex = 5;
            this.UCRNtxt.Text = "200017120001711003";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UCRN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QueryUCRNUsingWapperBtn);
            this.groupBox3.Controls.Add(this.QueryUCRNRequestMessagetxt);
            this.groupBox3.Controls.Add(this.QueryUCRNBtn);
            this.groupBox3.Controls.Add(this.UCRNtxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(80, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 446);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request";
            // 
            // QueryUCRNUsingWapperBtn
            // 
            this.QueryUCRNUsingWapperBtn.Location = new System.Drawing.Point(224, 33);
            this.QueryUCRNUsingWapperBtn.Name = "QueryUCRNUsingWapperBtn";
            this.QueryUCRNUsingWapperBtn.Size = new System.Drawing.Size(123, 45);
            this.QueryUCRNUsingWapperBtn.TabIndex = 8;
            this.QueryUCRNUsingWapperBtn.Text = "Query UCRN Using Wrapper";
            this.QueryUCRNUsingWapperBtn.UseVisualStyleBackColor = true;
            this.QueryUCRNUsingWapperBtn.Click += new System.EventHandler(this.QueryUCRNUsingWapperBtn_Click);
            // 
            // QueryUCRNRequestMessagetxt
            // 
            this.QueryUCRNRequestMessagetxt.Location = new System.Drawing.Point(24, 84);
            this.QueryUCRNRequestMessagetxt.Multiline = true;
            this.QueryUCRNRequestMessagetxt.Name = "QueryUCRNRequestMessagetxt";
            this.QueryUCRNRequestMessagetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QueryUCRNRequestMessagetxt.Size = new System.Drawing.Size(323, 351);
            this.QueryUCRNRequestMessagetxt.TabIndex = 7;
            // 
            // QueryUCRNBtn
            // 
            this.QueryUCRNBtn.Location = new System.Drawing.Point(224, 11);
            this.QueryUCRNBtn.Name = "QueryUCRNBtn";
            this.QueryUCRNBtn.Size = new System.Drawing.Size(123, 23);
            this.QueryUCRNBtn.TabIndex = 6;
            this.QueryUCRNBtn.Text = "Query UCRN";
            this.QueryUCRNBtn.UseVisualStyleBackColor = true;
            this.QueryUCRNBtn.Click += new System.EventHandler(this.QueryUCRNBtn_Click);
            // 
            // UCRNResultstxt
            // 
            this.UCRNResultstxt.Location = new System.Drawing.Point(22, 15);
            this.UCRNResultstxt.Multiline = true;
            this.UCRNResultstxt.Name = "UCRNResultstxt";
            this.UCRNResultstxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UCRNResultstxt.Size = new System.Drawing.Size(463, 416);
            this.UCRNResultstxt.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UCRNResultstxt);
            this.groupBox2.Location = new System.Drawing.Point(455, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 446);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UCRNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button QueryUCRNUsingWapperBtn;
        private System.Windows.Forms.TextBox QueryUCRNRequestMessagetxt;
        private System.Windows.Forms.Button QueryUCRNBtn;
        private System.Windows.Forms.TextBox UCRNResultstxt;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

