namespace SpeakerDesigner
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDriverParameters = new System.Windows.Forms.TabPage();
            this.tabVASMassMethod = new System.Windows.Forms.TabPage();
            this.tabVASPortedBoxMethod = new System.Windows.Forms.TabPage();
            this.tabOpenBoxDesign = new System.Windows.Forms.TabPage();
            this.tabPortedBoxDesign = new System.Windows.Forms.TabPage();
            this.DriverParametersBtn = new System.Windows.Forms.Button();
            this.DCResistancetxt = new System.Windows.Forms.TextBox();
            this.DCResistanceLbl = new System.Windows.Forms.Label();
            this.FreeAirResonanceLbl = new System.Windows.Forms.Label();
            this.FreeAirResonancetxt = new System.Windows.Forms.TextBox();
            this.ImpedenceAtFreeAirResonancetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrequencyBelowFreeAirResonanceLbl = new System.Windows.Forms.Label();
            this.FreqBelowFreeAirtxt = new System.Windows.Forms.TextBox();
            this.FrequencyAboveFreeAirResonanceLbl = new System.Windows.Forms.Label();
            this.FrequencyAboveFreeAirResonancetxt = new System.Windows.Forms.TextBox();
            this.QESResult = new System.Windows.Forms.Label();
            this.QEStxt = new System.Windows.Forms.Label();
            this.QTStxt = new System.Windows.Forms.Label();
            this.QMStxt = new System.Windows.Forms.Label();
            this.TestBoxVolumeLbl = new System.Windows.Forms.Label();
            this.TestBoxVolumetxt = new System.Windows.Forms.TextBox();
            this.DriverResonanceTestBoxLbl = new System.Windows.Forms.Label();
            this.DriverResonanceTestBoxtxt = new System.Windows.Forms.TextBox();
            this.VAStxt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDriverParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDriverParameters);
            this.tabControl1.Controls.Add(this.tabVASMassMethod);
            this.tabControl1.Controls.Add(this.tabVASPortedBoxMethod);
            this.tabControl1.Controls.Add(this.tabOpenBoxDesign);
            this.tabControl1.Controls.Add(this.tabPortedBoxDesign);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDriverParameters
            // 
            this.tabDriverParameters.Controls.Add(this.VAStxt);
            this.tabDriverParameters.Controls.Add(this.DriverResonanceTestBoxLbl);
            this.tabDriverParameters.Controls.Add(this.DriverResonanceTestBoxtxt);
            this.tabDriverParameters.Controls.Add(this.TestBoxVolumeLbl);
            this.tabDriverParameters.Controls.Add(this.TestBoxVolumetxt);
            this.tabDriverParameters.Controls.Add(this.QMStxt);
            this.tabDriverParameters.Controls.Add(this.QTStxt);
            this.tabDriverParameters.Controls.Add(this.QEStxt);
            this.tabDriverParameters.Controls.Add(this.QESResult);
            this.tabDriverParameters.Controls.Add(this.FrequencyAboveFreeAirResonanceLbl);
            this.tabDriverParameters.Controls.Add(this.FrequencyAboveFreeAirResonancetxt);
            this.tabDriverParameters.Controls.Add(this.FrequencyBelowFreeAirResonanceLbl);
            this.tabDriverParameters.Controls.Add(this.FreqBelowFreeAirtxt);
            this.tabDriverParameters.Controls.Add(this.label1);
            this.tabDriverParameters.Controls.Add(this.ImpedenceAtFreeAirResonancetxt);
            this.tabDriverParameters.Controls.Add(this.FreeAirResonanceLbl);
            this.tabDriverParameters.Controls.Add(this.FreeAirResonancetxt);
            this.tabDriverParameters.Controls.Add(this.DCResistanceLbl);
            this.tabDriverParameters.Controls.Add(this.DCResistancetxt);
            this.tabDriverParameters.Controls.Add(this.DriverParametersBtn);
            this.tabDriverParameters.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDriverParameters.Location = new System.Drawing.Point(4, 22);
            this.tabDriverParameters.Name = "tabDriverParameters";
            this.tabDriverParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabDriverParameters.Size = new System.Drawing.Size(699, 267);
            this.tabDriverParameters.TabIndex = 0;
            this.tabDriverParameters.Text = "Driver Parameters";
            this.tabDriverParameters.UseVisualStyleBackColor = true;
             // 
            // tabVASMassMethod
            // 
            this.tabVASMassMethod.Location = new System.Drawing.Point(4, 22);
            this.tabVASMassMethod.Name = "tabVASMassMethod";
            this.tabVASMassMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tabVASMassMethod.Size = new System.Drawing.Size(699, 267);
            this.tabVASMassMethod.TabIndex = 1;
            this.tabVASMassMethod.Text = "VAS, Mass Method";
            this.tabVASMassMethod.UseVisualStyleBackColor = true;
            // 
            // tabVASPortedBoxMethod
            // 
            this.tabVASPortedBoxMethod.Location = new System.Drawing.Point(4, 22);
            this.tabVASPortedBoxMethod.Name = "tabVASPortedBoxMethod";
            this.tabVASPortedBoxMethod.Size = new System.Drawing.Size(699, 267);
            this.tabVASPortedBoxMethod.TabIndex = 2;
            this.tabVASPortedBoxMethod.Text = "VAS, Ported Box Method";
            this.tabVASPortedBoxMethod.UseVisualStyleBackColor = true;
            // 
            // tabOpenBoxDesign
            // 
            this.tabOpenBoxDesign.Location = new System.Drawing.Point(4, 22);
            this.tabOpenBoxDesign.Name = "tabOpenBoxDesign";
            this.tabOpenBoxDesign.Size = new System.Drawing.Size(699, 267);
            this.tabOpenBoxDesign.TabIndex = 3;
            this.tabOpenBoxDesign.Text = "Open Box Design";
            this.tabOpenBoxDesign.UseVisualStyleBackColor = true;
            // 
            // tabPortedBoxDesign
            // 
            this.tabPortedBoxDesign.Location = new System.Drawing.Point(4, 22);
            this.tabPortedBoxDesign.Name = "tabPortedBoxDesign";
            this.tabPortedBoxDesign.Size = new System.Drawing.Size(699, 267);
            this.tabPortedBoxDesign.TabIndex = 4;
            this.tabPortedBoxDesign.Text = "Ported Box Design";
            this.tabPortedBoxDesign.UseVisualStyleBackColor = true;
            // 
            // DriverParametersBtn
            // 
            this.DriverParametersBtn.Location = new System.Drawing.Point(43, 216);
            this.DriverParametersBtn.Name = "DriverParametersBtn";
            this.DriverParametersBtn.Size = new System.Drawing.Size(141, 23);
            this.DriverParametersBtn.TabIndex = 0;
            this.DriverParametersBtn.Text = "Calculate Parameter";
            this.DriverParametersBtn.UseVisualStyleBackColor = true;
            this.DriverParametersBtn.Click += new System.EventHandler(this.DriverParametersBtn_Click);
            // 
            // DCResistancetxt
            // 
            this.DCResistancetxt.Location = new System.Drawing.Point(227, 27);
            this.DCResistancetxt.Name = "DCResistancetxt";
            this.DCResistancetxt.Size = new System.Drawing.Size(100, 20);
            this.DCResistancetxt.TabIndex = 1;
            this.DCResistancetxt.Text = "5.7";
            // 
            // DCResistanceLbl
            // 
            this.DCResistanceLbl.AutoSize = true;
            this.DCResistanceLbl.Location = new System.Drawing.Point(30, 30);
            this.DCResistanceLbl.Name = "DCResistanceLbl";
            this.DCResistanceLbl.Size = new System.Drawing.Size(150, 16);
            this.DCResistanceLbl.TabIndex = 2;
            this.DCResistanceLbl.Text = "DC Resistiance of  Voice Coil";
            // 
            // FreeAirResonanceLbl
            // 
            this.FreeAirResonanceLbl.AutoSize = true;
            this.FreeAirResonanceLbl.Location = new System.Drawing.Point(30, 56);
            this.FreeAirResonanceLbl.Name = "FreeAirResonanceLbl";
            this.FreeAirResonanceLbl.Size = new System.Drawing.Size(104, 16);
            this.FreeAirResonanceLbl.TabIndex = 4;
            this.FreeAirResonanceLbl.Text = "Free Air Resonance";
            // 
            // FreeAirResonancetxt
            // 
            this.FreeAirResonancetxt.Location = new System.Drawing.Point(227, 53);
            this.FreeAirResonancetxt.Name = "FreeAirResonancetxt";
            this.FreeAirResonancetxt.Size = new System.Drawing.Size(100, 20);
            this.FreeAirResonancetxt.TabIndex = 3;
            this.FreeAirResonancetxt.Text = "33";
             // 
            // ImpedenceAtFreeAirResonancetxt
            // 
            this.ImpedenceAtFreeAirResonancetxt.Location = new System.Drawing.Point(227, 79);
            this.ImpedenceAtFreeAirResonancetxt.Name = "ImpedenceAtFreeAirResonancetxt";
            this.ImpedenceAtFreeAirResonancetxt.Size = new System.Drawing.Size(100, 20);
            this.ImpedenceAtFreeAirResonancetxt.TabIndex = 5;
            this.ImpedenceAtFreeAirResonancetxt.Text = "38";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Impedence at Free Air Resonance";
            // 
            // FrequencyBelowFreeAirResonanceLbl
            // 
            this.FrequencyBelowFreeAirResonanceLbl.AutoSize = true;
            this.FrequencyBelowFreeAirResonanceLbl.Location = new System.Drawing.Point(30, 108);
            this.FrequencyBelowFreeAirResonanceLbl.Name = "FrequencyBelowFreeAirResonanceLbl";
            this.FrequencyBelowFreeAirResonanceLbl.Size = new System.Drawing.Size(191, 16);
            this.FrequencyBelowFreeAirResonanceLbl.TabIndex = 8;
            this.FrequencyBelowFreeAirResonanceLbl.Text = "Frequency Below Free Air Resonance";
            // 
            // FreqBelowFreeAirtxt
            // 
            this.FreqBelowFreeAirtxt.Location = new System.Drawing.Point(227, 105);
            this.FreqBelowFreeAirtxt.Name = "FreqBelowFreeAirtxt";
            this.FreqBelowFreeAirtxt.Size = new System.Drawing.Size(100, 20);
            this.FreqBelowFreeAirtxt.TabIndex = 7;
            this.FreqBelowFreeAirtxt.Text = "23";
             // 
            // FrequencyAboveFreeAirResonanceLbl
            // 
            this.FrequencyAboveFreeAirResonanceLbl.AutoSize = true;
            this.FrequencyAboveFreeAirResonanceLbl.Location = new System.Drawing.Point(30, 134);
            this.FrequencyAboveFreeAirResonanceLbl.Name = "FrequencyAboveFreeAirResonanceLbl";
            this.FrequencyAboveFreeAirResonanceLbl.Size = new System.Drawing.Size(193, 16);
            this.FrequencyAboveFreeAirResonanceLbl.TabIndex = 10;
            this.FrequencyAboveFreeAirResonanceLbl.Text = "Frequency Above Free Air Resonance";
            // 
            // FrequencyAboveFreeAirResonancetxt
            // 
            this.FrequencyAboveFreeAirResonancetxt.Location = new System.Drawing.Point(227, 131);
            this.FrequencyAboveFreeAirResonancetxt.Name = "FrequencyAboveFreeAirResonancetxt";
            this.FrequencyAboveFreeAirResonancetxt.Size = new System.Drawing.Size(100, 20);
            this.FrequencyAboveFreeAirResonancetxt.TabIndex = 9;
            this.FrequencyAboveFreeAirResonancetxt.Text = "46";
            // 
            // QESResult
            // 
            this.QESResult.AutoSize = true;
            this.QESResult.Location = new System.Drawing.Point(435, 30);
            this.QESResult.Name = "QESResult";
            this.QESResult.Size = new System.Drawing.Size(0, 16);
            this.QESResult.TabIndex = 11;
           
            // 
            // QEStxt
            // 
            this.QEStxt.AutoSize = true;
            this.QEStxt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QEStxt.Location = new System.Drawing.Point(355, 56);
            this.QEStxt.Name = "QEStxt";
            this.QEStxt.Size = new System.Drawing.Size(36, 16);
            this.QEStxt.TabIndex = 12;
            this.QEStxt.Text = "label2";
            this.QEStxt.Visible = false;
            // 
            // QTStxt
            // 
            this.QTStxt.AutoSize = true;
            this.QTStxt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTStxt.Location = new System.Drawing.Point(355, 86);
            this.QTStxt.Name = "QTStxt";
            this.QTStxt.Size = new System.Drawing.Size(36, 16);
            this.QTStxt.TabIndex = 13;
            this.QTStxt.Text = "label2";
            this.QTStxt.Visible = false;
            // 
            // QMStxt
            // 
            this.QMStxt.AutoSize = true;
            this.QMStxt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QMStxt.Location = new System.Drawing.Point(355, 27);
            this.QMStxt.Name = "QMStxt";
            this.QMStxt.Size = new System.Drawing.Size(36, 16);
            this.QMStxt.TabIndex = 14;
            this.QMStxt.Text = "label2";
            this.QMStxt.Visible = false;
            // 
            // TestBoxVolumeLbl
            // 
            this.TestBoxVolumeLbl.AutoSize = true;
            this.TestBoxVolumeLbl.Location = new System.Drawing.Point(30, 160);
            this.TestBoxVolumeLbl.Name = "TestBoxVolumeLbl";
            this.TestBoxVolumeLbl.Size = new System.Drawing.Size(89, 16);
            this.TestBoxVolumeLbl.TabIndex = 16;
            this.TestBoxVolumeLbl.Text = "Test Box Volume";
            // 
            // TestBoxVolumetxt
            // 
            this.TestBoxVolumetxt.Location = new System.Drawing.Point(227, 157);
            this.TestBoxVolumetxt.Name = "TestBoxVolumetxt";
            this.TestBoxVolumetxt.Size = new System.Drawing.Size(100, 20);
            this.TestBoxVolumetxt.TabIndex = 15;
            this.TestBoxVolumetxt.Text = "14";
            // 
            // DriverResonanceTestBoxLbl
            // 
            this.DriverResonanceTestBoxLbl.AutoSize = true;
            this.DriverResonanceTestBoxLbl.Location = new System.Drawing.Point(30, 186);
            this.DriverResonanceTestBoxLbl.Name = "DriverResonanceTestBoxLbl";
            this.DriverResonanceTestBoxLbl.Size = new System.Drawing.Size(154, 16);
            this.DriverResonanceTestBoxLbl.TabIndex = 18;
            this.DriverResonanceTestBoxLbl.Text = "Driver Resonance in Test Box";
            // 
            // DriverResonanceTestBoxtxt
            // 
            this.DriverResonanceTestBoxtxt.Location = new System.Drawing.Point(227, 183);
            this.DriverResonanceTestBoxtxt.Name = "DriverResonanceTestBoxtxt";
            this.DriverResonanceTestBoxtxt.Size = new System.Drawing.Size(100, 20);
            this.DriverResonanceTestBoxtxt.TabIndex = 17;
            this.DriverResonanceTestBoxtxt.Text = "73";
            // 
            // VAStxt
            // 
            this.VAStxt.AutoSize = true;
            this.VAStxt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAStxt.Location = new System.Drawing.Point(355, 112);
            this.VAStxt.Name = "VAStxt";
            this.VAStxt.Size = new System.Drawing.Size(36, 16);
            this.VAStxt.TabIndex = 19;
            this.VAStxt.Text = "label2";
            this.VAStxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Loud Speaker Designer";
            this.tabControl1.ResumeLayout(false);
            this.tabDriverParameters.ResumeLayout(false);
            this.tabDriverParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDriverParameters;
        private System.Windows.Forms.Button DriverParametersBtn;
        private System.Windows.Forms.TabPage tabVASMassMethod;
        private System.Windows.Forms.TabPage tabVASPortedBoxMethod;
        private System.Windows.Forms.TabPage tabOpenBoxDesign;
        private System.Windows.Forms.TabPage tabPortedBoxDesign;
        private System.Windows.Forms.Label FrequencyBelowFreeAirResonanceLbl;
        private System.Windows.Forms.TextBox FreqBelowFreeAirtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImpedenceAtFreeAirResonancetxt;
        private System.Windows.Forms.Label FreeAirResonanceLbl;
        private System.Windows.Forms.TextBox FreeAirResonancetxt;
        private System.Windows.Forms.Label DCResistanceLbl;
        private System.Windows.Forms.TextBox DCResistancetxt;
        private System.Windows.Forms.Label FrequencyAboveFreeAirResonanceLbl;
        private System.Windows.Forms.TextBox FrequencyAboveFreeAirResonancetxt;
        private System.Windows.Forms.Label QESResult;
        private System.Windows.Forms.Label QMStxt;
        private System.Windows.Forms.Label QTStxt;
        private System.Windows.Forms.Label QEStxt;
        private System.Windows.Forms.Label VAStxt;
        private System.Windows.Forms.Label DriverResonanceTestBoxLbl;
        private System.Windows.Forms.TextBox DriverResonanceTestBoxtxt;
        private System.Windows.Forms.Label TestBoxVolumeLbl;
        private System.Windows.Forms.TextBox TestBoxVolumetxt;
    }
}

