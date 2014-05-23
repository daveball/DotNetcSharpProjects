/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 06/02/2014
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CASRefreshWebserviceSampleApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabCASRefresh = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.QueryUPRNBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.UPRNtxt = new System.Windows.Forms.TextBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.tabCASRefresh.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCASRefresh
			// 
			this.tabCASRefresh.Controls.Add(this.tabPage1);
			this.tabCASRefresh.Controls.Add(this.tabPage2);
			this.tabCASRefresh.Controls.Add(this.tabPage3);
			this.tabCASRefresh.Controls.Add(this.tabPage4);
			this.tabCASRefresh.Controls.Add(this.tabPage5);
			this.tabCASRefresh.Controls.Add(this.tabPage6);
			this.tabCASRefresh.Controls.Add(this.tabPage7);
			this.tabCASRefresh.Controls.Add(this.tabPage8);
			this.tabCASRefresh.Location = new System.Drawing.Point(3, 1);
			this.tabCASRefresh.Name = "tabCASRefresh";
			this.tabCASRefresh.SelectedIndex = 0;
			this.tabCASRefresh.Size = new System.Drawing.Size(970, 308);
			this.tabCASRefresh.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(962, 282);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Registration";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(962, 282);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Registration with NEC";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(962, 282);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Query UCRN";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.QueryUPRNBtn);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.UPRNtxt);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(962, 282);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Query UPRN";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// QueryUPRNBtn
			// 
			this.QueryUPRNBtn.Location = new System.Drawing.Point(247, 24);
			this.QueryUPRNBtn.Name = "QueryUPRNBtn";
			this.QueryUPRNBtn.Size = new System.Drawing.Size(149, 23);
			this.QueryUPRNBtn.TabIndex = 2;
			this.QueryUPRNBtn.Text = "Query UPRN";
			this.QueryUPRNBtn.UseVisualStyleBackColor = true;
			this.QueryUPRNBtn.Click += new System.EventHandler(this.QueryUPRNBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "URPN";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// UPRNtxt
			// 
			this.UPRNtxt.Location = new System.Drawing.Point(67, 24);
			this.UPRNtxt.Name = "UPRNtxt";
			this.UPRNtxt.Size = new System.Drawing.Size(158, 20);
			this.UPRNtxt.TabIndex = 0;
			this.UPRNtxt.Text = "906700213419";
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(962, 282);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Search Citizen Details";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(962, 282);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Change Address Details";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(962, 282);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Change Citizen Consent";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// tabPage8
			// 
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(962, 282);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Change Personal Details";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 309);
			this.Controls.Add(this.tabCASRefresh);
			this.Name = "MainForm";
			this.Text = "CASRefreshWebserviceSampleApplication";
			this.tabCASRefresh.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button QueryUPRNBtn;
		private System.Windows.Forms.TextBox UPRNtxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabCASRefresh;
	}
}
