using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Program to work out various parameters for the design  and building of Loud Speaker Cabinets 
// Program is a porting of the program originally  developed by Robert L. Claude and  David B Weems
// To a Windows  application written in C# by Dave Ball
// based  on  the  equation of D.B. Keele, Richard Small, Ralph Gonzalize, George Augspuger and E.M.Sutphin


namespace SpeakerDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        
        private void DriverParametersBtn_Click(object sender, EventArgs e)
        {
            try {
                    //Read In Input Values
                    double CoilResistance = Convert.ToDouble(DCResistancetxt.Text);
                    double FreeAirResonance = Convert.ToDouble(FreeAirResonancetxt.Text);
                    double ImpedenceAtFreeAirResonance = Convert.ToDouble(ImpedenceAtFreeAirResonancetxt.Text);
                    double F1 = Convert.ToDouble(FreqBelowFreeAirtxt.Text);
                    double F2 = Convert.ToDouble(FrequencyAboveFreeAirResonancetxt.Text);
                    double RO = ImpedenceAtFreeAirResonance / CoilResistance;
                    double RF = Math.Sqrt(RO) * CoilResistance;
                    double TVB = Convert.ToDouble(TestBoxVolumetxt.Text);
                    double TFS = Convert.ToDouble(DriverResonanceTestBoxtxt.Text);
                
                    // Calculate  the  Magnification of Resonance Factors Q, a high Q is more resonat than one with a low  Q
                    //The Mechanical Q of the driver
                    double QMS = FreeAirResonance * Math.Sqrt(RO) / (F2 - F1);
                    //The Electrical Q of the driver
                    double QES= QMS/(RO-1);
                    // The total Q of the driver
                    double QTS = QMS*QES /(QMS+QES);
                    
                    
                    // Volume of air that offers the same degree of restoring  force on the the  cone as that of the cone's  suspension
                    double VAS = TVB * (1.149 * (Math.Pow((TFS / FreeAirResonance),2 ) - 1));

                 
                    // Set  Output Values
                    QEStxt.Text = "The Electrical Q of the driver, QES = " + QES.ToString("0.00");
                    QMStxt.Text = "The Mechanical Q of the driver, QMS = " + QMS.ToString("0.00");
                    QTStxt.Text = "The Total Q of the driver, QTS = " + QTS.ToString("0.00");
                    VAStxt.Text = "Volume of Air same Deg. of Force,VAS = " + VAS.ToString("0.00");
                    //Make Output Values Visible
                    QEStxt.Visible = true;
                    QMStxt.Visible = true;
                    QTStxt.Visible = true;
                    VAStxt.Visible = true;

                 }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
