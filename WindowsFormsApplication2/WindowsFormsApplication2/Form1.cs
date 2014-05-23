using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using log4net;
using System.Collections;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WindowsFormsApplication2
{
    public partial class WSEQuery : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	
      
        public WSEQuery()
        {
            InitializeComponent();
        }
        public static int exceptionLevel = 0;
        public static void DisplayException(Exception e)
        {
            // Increment exception level.
            exceptionLevel++;
            // Make spacer for level.
            string indent = new string('\t', exceptionLevel - 1);
            // Write out exception level data.
            log.Error(indent + "*** Exception Level {0} " +
                              "***************************************" + " " + exceptionLevel.ToString());
            log.Error(indent + "ExceptionType: " + e.GetType().Name.ToString());
            log.Error(indent + "HelpLine: " + e.HelpLink);
            log.Error(indent + "Message: " + e.Message + " Code: ");
            log.Error(indent + "Source: " + e.Source);
            log.Error(indent + "StackTrace: " + e.StackTrace);
            log.Error(indent + "TargetSite: " + e.TargetSite);
            log.Error(indent + "Data:");
            foreach (DictionaryEntry de in e.Data)
            {
                log.Error(indent + "\t" + de.Key.ToString() + " : " + de.Value.ToString());
            }

            // Get the inner exception for this exception.
            Exception ie = e.InnerException;

            // Print out the inner exceptions recursively.
            while (ie != null)
            {
                DisplayException(ie);
                // Check to see if we are doing the inner exceptions.
                if (exceptionLevel > 1)
                    ie = ie.InnerException;
                else // back to main level
                    ie = null;
            }
            // Decrement exception level.
            exceptionLevel--;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                
                // Create an instance of the webservice client
                ServiceReference1.coreSampleClassClient myClient = new ServiceReference1.coreSampleClassClient();
                //Create a  blank Resonse Message instance
                ServiceReference1.addValuesResponse myResponse = new ServiceReference1.addValuesResponse();
                //Create blank Request Message
                ServiceReference1.addValues myRequest = new ServiceReference1.addValues();

                // Create  blank request message Payload
                ServiceReference1.coreSampleVO coreSampleVO = new ServiceReference1.coreSampleVO();
                // Assign Values to the payload
                coreSampleVO.a = 1;
                coreSampleVO.b = 1;
                coreSampleVO.c = 1;
                // Add payload to Request Message
                myRequest.coreSampleVO = coreSampleVO;
               
                // display input  message in text box
                System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
                StringWriter requestwriter = new StringWriter();
                request.Serialize(requestwriter, myRequest);
                string xmlstring = requestwriter.ToString();
                // Update txtBox with the deserialized  XML
                WSQuery.Text = xmlstring;
                // update lof  file  with request details
                log.Info("List Notification XML: " + xmlstring);
                
                // call  the webservice and load the response into the Blank response Message we created earlier
                myResponse = myClient.addValues(myRequest);

                // display output in text box
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myResponse.GetType());
                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myResponse);
                xmlstring = resultwriter.ToString();
               
                // Update txtBox with the deserialized  XML returned  fromthe webservice
                QueryUPRNBtn.Text = xmlstring;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                log.Error(ex.Message, ex);
                DisplayException(ex);
            }


        }

        private void NonWSETest_Click(object sender, EventArgs e)
        {
           

            //try
            //{
            //    ServiceReference2.coreSampleClassClient myClient = new ServiceReference2.coreSampleClassClient();
            //    ServiceReference2.addValuesResponse myResponse = new ServiceReference2.addValuesResponse();
            //    ServiceReference2.addValues myRequest = new ServiceReference2.addValues();

            //    // display input  message in text box
            //    System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
            //    StringWriter requestwriter = new StringWriter();
            //    request.Serialize(requestwriter, myRequest);
            //    string xmlstring = requestwriter.ToString();
            //    WSQuery.Text = xmlstring;
            //    log.Info("List Notification XML: " + xmlstring);

            //    // call  the webservice
            //    myResponse = myClient.addValues(myRequest);

            //    // display output in text box
            //    System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myResponse.GetType());

            //    StringWriter resultwriter = new StringWriter();
            //    result.Serialize(resultwriter, myResponse);
            //    xmlstring = resultwriter.ToString();
            //    WSEResponse.Text = xmlstring;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    log.Error(ex.Message, ex);
            //    DisplayException(ex);
            //}

            
        }

        private void QueryUPRN_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference3.queryUPRN myqueryUPRN = new ServiceReference3.queryUPRN();
                string CallerToken = "testsp@cas.com";
                myqueryUPRN.CallerToken = CallerToken;
                ServiceReference3.QueryUPRNServiceClient myClient = new ServiceReference3.QueryUPRNServiceClient();
                ServiceReference3.queryUPRN myRequest = new ServiceReference3.queryUPRN();
                myRequest.CallerToken = CallerToken;
                myRequest.queryUPRNRequest = new ServiceReference3.QueryUPRNRequest();
                ServiceReference3.QueryUPRNRequest myQueryUPRN = new ServiceReference3.QueryUPRNRequest();
                ServiceReference3.RequestBody myRequestBody = new ServiceReference3.RequestBody();
                ServiceReference3.UPRNType myUPRNType = new ServiceReference3.UPRNType();
                // set the UPRN specified flag to true
                myUPRNType.UPRNType1Specified = true;
                // define the type of UPRN being sent P for Prodcution T for Temporary
                myUPRNType.UPRNType1 = ServiceReference3.UPRNTypeUPRNType.P;
                // add the value of the UPRN you are wanting to Query
                myUPRNType.Value = "118023437";
                // set the RequestBody to your  UPRNType 
                myRequestBody.Item = myUPRNType;
                // set the  QueryUPRNRequest.RequestBody to  the RequestBody you have define
                myRequest.queryUPRNRequest.RequestBody = myRequestBody;
                // display input  message in text box
                System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
                StringWriter requestwriter = new StringWriter();
                request.Serialize(requestwriter, myRequest);
                string xmlstring = requestwriter.ToString();
                // Update txtBox with the deserialized  XML
                WSQuery.Text = xmlstring;
                ServiceReference3.queryUPRNResponse myResponse = myClient.queryUPRN(myRequest);
                // display output in text box
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myResponse.GetType());
                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myResponse);
                xmlstring = resultwriter.ToString();

                // Update txtBox with the deserialized  XML returned  fromthe webservice
                QueryUPRNBtn.Text = xmlstring;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message, ex);
                DisplayException(ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference2.queryUPRN myqueryUPRN = new ServiceReference2.queryUPRN();
                string CallerToken = "testsp@cas.com";
                myqueryUPRN.CallerToken = CallerToken;
                ServiceReference2.QueryUPRNServiceClient myClient = new ServiceReference2.QueryUPRNServiceClient();
                ServiceReference2.queryUPRN myRequest = new ServiceReference2.queryUPRN();
                myRequest.CallerToken = CallerToken;
                myRequest.queryUPRNRequest = new ServiceReference2.QueryUPRNRequest();
                ServiceReference2.QueryUPRNRequest myQueryUPRN = new ServiceReference2.QueryUPRNRequest();
                ServiceReference2.RequestBody myRequestBody = new ServiceReference2.RequestBody();
                ServiceReference2.UPRNType myUPRNType = new ServiceReference2.UPRNType();
                // set the UPRN specified flag to true
                myUPRNType.UPRNType1Specified = true;
                // define the type of UPRN being sent P for Prodcution T for Temporary
                myUPRNType.UPRNType1 = ServiceReference2.UPRNTypeUPRNType.P;
                // add the value of the UPRN you are wanting to Query
                myUPRNType.Value = "118023437";
                // set the RequestBody to your  UPRNType 
                myRequestBody.Item = myUPRNType;
                // set the  QueryUPRNRequest.RequestBody to  the RequestBody you have define
                myRequest.queryUPRNRequest.RequestBody = myRequestBody;
                // display input  message in text box
                System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
                StringWriter requestwriter = new StringWriter();
                request.Serialize(requestwriter, myRequest);
                string xmlstring = requestwriter.ToString();
                // Update txtBox with the deserialized  XML
                WSQuery.Text = xmlstring;
                ServiceReference2.queryUPRNResponse myResponse = myClient.queryUPRN(myRequest);
                // display output in text box
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myResponse.GetType());
                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myResponse);
                xmlstring = resultwriter.ToString();

                // Update txtBox with the deserialized  XML returned  fromthe webservice
                QueryUPRNBtn.Text = xmlstring;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message, ex);
                DisplayException(ex);
            }
        }
    }
}
