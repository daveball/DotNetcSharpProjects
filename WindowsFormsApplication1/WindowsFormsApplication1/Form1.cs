using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using log4net;
using System.Diagnostics;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	
        public Form1()
        {
            InitializeComponent();
        }

        private void QueryUPRNbtn_Click(object sender, EventArgs e)
        {
            try
            {
            // Create an instance of the QueryUPRNService Client
                CAS.QueryUPRNServiceClient myQueryUPRNServiceClient = new CAS.QueryUPRNServiceClient();

            // add client credential to your  QueryUPRNService Client
               // myQueryUPRNServiceClient.ChannelFactory.Endpoint.Behaviors.Remove<System.ServiceModel.Description.ClientCredentials>();
                //myQueryUPRNServiceClient.ChannelFactory.Endpoint.Behaviors.Add(new CustomCredentials());

                //myQueryUPRNServiceClient.ClientCredentials.UserName.UserName = "testsp@cas.com";
                //myQueryUPRNServiceClient.ClientCredentials.UserName.Password = "Agent@1234";
       

            //Create a queryResponse1
            CAS.queryUPRNResponse1 myQueryUPRNresponse1 = new CAS.queryUPRNResponse1();
         

            //Create a QueryUPRNRequest
            CAS.QueryUPRNRequest myQueryUPRNRequest = new CAS.QueryUPRNRequest();
            
            //Initiate  the message  body of the  myQueryUPRNRequest
            CAS.RequestBody myRequestBody = new CAS.RequestBody();
        
            // Create  an instance  UPRNType
            CAS.UPRNType myUPRNType = new CAS.UPRNType();
           // set the UPRN specified flag to true
            myUPRNType.UPRNType1Specified = true;
           // define the type of UPRN being sent P for Prodcution T for Temporary
            myUPRNType.UPRNType1 = CAS.UPRNTypeUPRNType.P;
            // add the value of the UPRN you are wanting to Query
            myUPRNType.Value = UPRNtxt.Text;
            // set the RequestBody to your  UPRNType 
            CAS.Address myAddressDetails = new CAS.Address();
     
           // myAddressDetails.AddressString = "Crissburn Cottage, 59,Goreburn Rd";
            myAddressDetails.PostCode = "G65TF";
          
          
            myRequestBody.Item = myAddressDetails;
            //myRequestBody.Item = myUPRNType;
            // set the  QueryUPRNRequest.RequestBody to  the RequestBody you have define
            myQueryUPRNRequest.RequestBody = myRequestBody;
            // Create a queryUPRN  you will thne use this to create your queryUPRNRequest1
            CAS.queryUPRN myQueryUPRN = new CAS.queryUPRN();
            myQueryUPRN.CallerToken = "testsp@cas.com";
            //Set your QueryUPRN queryUPRNRequest to the QueryUPRNRequest you have defined  earlier. 
            myQueryUPRN.queryUPRNRequest = myQueryUPRNRequest;
            // initiate a queryUPRNRequest1 usine the same username as nyour Caller token and the queryUPRN you have defined above
            CAS.queryUPRNRequest1 myQueryUCRNRequest1 = new CAS.queryUPRNRequest1( myQueryUPRN);

            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myQueryUCRNRequest1.GetType());
           StringWriter requestwriter = new StringWriter();
           request.Serialize(requestwriter, myQueryUCRNRequest1);
           string xmlstring = requestwriter.ToString();
           UPRNQueryRequestMessagetxt.Text = xmlstring;

            //Send  query message to webservice and save results in a queryUPRNResposne1
           
                myQueryUPRNresponse1 = myQueryUPRNServiceClient.queryUPRN(myQueryUCRNRequest1);

                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myQueryUPRNresponse1.GetType());

                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myQueryUPRNresponse1);
             xmlstring = resultwriter.ToString();
                UPRNResulttxt.Text = xmlstring;
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         


        }

        private void QueryUCRNBtn_Click(object sender, EventArgs e)
        {
            try
            {
            QueryUCRNService.QueryUCRNServiceClient myQueryUCRNService = new QueryUCRNService.QueryUCRNServiceClient();
            //myQueryUCRNService.ChannelFactory.Endpoint.Behaviors.Remove<System.ServiceModel.Description.ClientCredentials>();
            //myQueryUCRNService.ChannelFactory.Endpoint.Behaviors.Add(new CustomCredentials());
            //    
            myQueryUCRNService.ClientCredentials.UserName.UserName = "mdmwagent@cas.com";
            myQueryUCRNService.ClientCredentials.UserName.Password = "Agent@1234 ";
            
                QueryUCRNService.queryUCRNResponse myQueryUCRNResponse = new QueryUCRNService.queryUCRNResponse();
            QueryUCRNService.QueryUCRNRequest myQueryUCRNRequest = new QueryUCRNService.QueryUCRNRequest();
            QueryUCRNService.queryUCRN myqueryUCRN = new QueryUCRNService.queryUCRN();
            QueryUCRNService.RequestBody myRequestBody = new  QueryUCRNService.RequestBody();
           
            QueryUCRNService.UCRNType myUCRNType = new QueryUCRNService.UCRNType();
            myUCRNType.UCRNType1Specified = false;
            //myUCRNType.UCRNType1 = QueryUCRNService.UCRNTypeUCRNType.P;
            myUCRNType.Value = UCRNtxt.Text;

            myRequestBody.Item = myUCRNType;
           
            myQueryUCRNRequest.RequestBody = new QueryUCRNService.RequestBody();
            myQueryUCRNRequest.RequestBody = myRequestBody;
           
            //myQueryUCRNRequest.RequestBody.Item = myUCRNType;
            myqueryUCRN.queryUCRNRequest = myQueryUCRNRequest;

            QueryUCRNService.queryUCRNRequest1 myqueryUCRNRequest1 = new QueryUCRNService.queryUCRNRequest1("mdmwagent@cas.com", myqueryUCRN);
            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myqueryUCRNRequest1.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myqueryUCRNRequest1);
            string xmlstring = requestwriter.ToString();
                 log.Info("UCRN Query :" + xmlstring);
            QueryUCRNRequestMessagetxt.Text = xmlstring;
            
                myQueryUCRNResponse = myQueryUCRNService.queryUCRN("sp_super_admin", myqueryUCRN);
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myQueryUCRNResponse.GetType());

                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myQueryUCRNResponse);
                xmlstring = resultwriter.ToString();
                UCRNResultstxt.Text = xmlstring;
            }
            catch(Exception se)
            {
                MessageBox.Show(se.Message);
                log.Error(se.Message,se);
            }
           
           

        }

        private void QueryUPRNFactoryChannelBtn_Click(object sender, EventArgs e)
        {
            
           
        }

        private void UPRNtreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {



        }

        private void NecRegisrationMessageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void NECRegistrationRequest_Click(object sender, EventArgs e)
        {
            RegisterViaNECCardService.RegisterViaNECCardServiceClient myRegisterViaNECCardService = new RegisterViaNECCardService.RegisterViaNECCardServiceClient();
            myRegisterViaNECCardService.ClientCredentials.UserName.UserName = "sp_super_admin";
            myRegisterViaNECCardService.ClientCredentials.UserName.Password = "FFfwsf2cAIp8aow6MHT9Ow==";
 
            RegisterViaNECCardService.addNewUserNec myaddNewUserNec = new RegisterViaNECCardService.addNewUserNec();
            RegisterViaNECCardService.RegisterViaNECCardRequest myRegisterViaNECCardRequest = new RegisterViaNECCardService.RegisterViaNECCardRequest();
            myRegisterViaNECCardRequest.RequestBody = new RegisterViaNECCardService.RequestBody();
            myRegisterViaNECCardRequest.RequestBody.NECCardNumber= Convert.ToInt64(NECNumbertxt.Text);

            myRegisterViaNECCardRequest.RequestBody.Username =RegNecUsernametxt.Text;
             myRegisterViaNECCardRequest.RequestBody.EmailAddress = RegNECEmailtxt.Text;
             myRegisterViaNECCardRequest.RequestBody.MobileNumber = RegNecMobiletxt.Text;
            myRegisterViaNECCardRequest.RequestBody.PostCode = RegNecPostCodetxt.Text;
            //RegisterViaNECCardService.addNewUserNecRequest myaddNewNECRequest = new RegisterViaNECCardService.addNewUserNecRequest();
            myaddNewUserNec.registerViaNECCardRequest = myRegisterViaNECCardRequest;
            RegisterViaNECCardService.addNewUserNecRequest myaddNewNECRequest = new RegisterViaNECCardService.addNewUserNecRequest("sp_super_admin", myaddNewUserNec);
           
            //myaddNewNECRequest.addNewUserNec = myaddNewUserNec;
            RegisterViaNECCardService.addNewUserNecResponse1 myaddNewUserNecResponse1 = new RegisterViaNECCardService.addNewUserNecResponse1();

            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myaddNewNECRequest.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myaddNewNECRequest);
            string xmlstring = requestwriter.ToString();
            NecRegisrationMessageTxt.Text = xmlstring;
            try
            {
                myRegisterViaNECCardService.addNewUserNec(myaddNewNECRequest);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myaddNewUserNecResponse1.GetType());

            StringWriter resultwriter = new StringWriter();
            result.Serialize(resultwriter, myaddNewUserNecResponse1);
            xmlstring = resultwriter.ToString();
            NECRegistrationResponsetxt.Text = xmlstring;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void RegisterCitizenBtn_Click(object sender, EventArgs e)
        {

            RegistrationService.RegistrationServiceClient myRegistrationService = new RegistrationService.RegistrationServiceClient();
        }

        private void TestWSEBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                
            WSETest.coreSampleClassClient mySampleClient = new WSETest.coreSampleClassClient();
            mySampleClient.ClientCredentials.UserName.UserName = "cecagent";
            mySampleClient.ClientCredentials.UserName.Password = "Agent@1234";
            WSETest.addValuesRequest myAddValuesRequest = new WSETest.addValuesRequest();
            WSETest.addValues myAddvalues = new WSETest.addValues();
            WSETest.addValuesResponse myaddValuesResponse = new WSETest.addValuesResponse();
            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myAddvalues.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myAddvalues);
            string xmlstring = requestwriter.ToString();
            wseTestQuery.Text = xmlstring;

            log.Info("Query XML:" + xmlstring);
                     myaddValuesResponse=mySampleClient.addValues(myAddvalues);
                
            System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myaddValuesResponse.GetType());

            StringWriter resultwriter = new StringWriter();
            result.Serialize(resultwriter, myaddValuesResponse);
            xmlstring = resultwriter.ToString();
            NECRegistrationResponsetxt.Text = xmlstring;
            }
            catch( Exception ex)
            {
                log.Error(ex.Message, ex);
           MessageBox.Show(ex.Message);

            }

            
            
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void ListNotificationsBtn_Click(object sender, EventArgs e)
        { try
            {
            ListNotifications.coreSampleClassClient myListNotificationsClient = new ListNotifications.coreSampleClassClient();
            //myListNotificationsClient.ClientCredentials.UserName.UserName = "nlcagent";
            //myListNotificationsClient.ClientCredentials.UserName.Password = "Agent@1234";
            ListNotifications.addValues myValues = new ListNotifications.addValues();
            ListNotifications.generateStrRequest myListNotificationRequest = new ListNotifications.generateStrRequest();
            ListNotifications.addValuesResponse myListNotificationResponse = new ListNotifications.addValuesResponse();
            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myListNotificationRequest.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myListNotificationRequest);
            string xmlstring = requestwriter.ToString();
            ListNotificationQuery.Text = xmlstring;
            log.Info("List Notification XML: " + xmlstring);

            myListNotificationResponse = myListNotificationsClient.addValues(myValues);
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myListNotificationResponse.GetType());

            StringWriter resultwriter = new StringWriter();
            result.Serialize(resultwriter, myListNotificationResponse);
            xmlstring = resultwriter.ToString();
            ListNotificationResulttxt.Text = xmlstring;
            }
            catch(Exception ex)
        {
            log.Error(ex.Message,ex);
            DisplayException(ex);
                MessageBox.Show(ex.Message);
            }
            

            }

        private void RegisterCitizenOffline_Click(object sender, EventArgs e)
        {
            ServiceReference1.RegisterOfflineServiceClient myRegisterOfflineService = new ServiceReference1.RegisterOfflineServiceClient();
            ServiceReference1.registerOffline myRegisterOffline = new ServiceReference1.registerOffline();
            myRegisterOffline.registerOfflineRequest = new ServiceReference1.RegisterOfflineRequest();
            myRegisterOffline.registerOfflineRequest.RequestBody= new ServiceReference1.RequestBody();
            ServiceReference1.RequestBody myRequestBody = new ServiceReference1.RequestBody();
            myRequestBody.Contact = new ServiceReference1.Contact();
            myRequestBody.Contact.EmailAddress   =  "dave.ball2@virgin.net";
            myRequestBody.Contact.LandlineNumber = "01414182552";
            ServiceReference1.CitizenDetails myCitizenDetials = new ServiceReference1.CitizenDetails();
            ServiceReference1.AddressInput myAddressInput = new ServiceReference1.AddressInput();
            ServiceReference1.AddressLine myAddresLine = new ServiceReference1.AddressLine();
            myAddresLine.AddressLine1 = "Crissburn Cottage";
            myAddresLine.AddressLine2 = "59";
            myAddresLine.AddressLine3 = "Goreburn Rd";
            myAddressInput.AddressLine = myAddresLine;
            myAddressInput.PostCode = "G65TF";
            myAddressInput.Town="Glasgow";
            myAddressInput.LACode = 9073;


            myCitizenDetials.DateOfBirth = new DateTime(1971 ,4,26);
            ServiceReference1.Name myName = new ServiceReference1.Name();
            myName.FirstName = "David";
            myName.LastName = "Ball";
            myCitizenDetials.Name = myName;

            myRequestBody.Item = myCitizenDetials;
            myRequestBody.Item1 = myAddressInput;
            myRegisterOffline.registerOfflineRequest.RequestBody = myRequestBody;
            myRegisterOffline.CallerToken = "testsp@cas.com";
            ServiceReference1.registerOfflineRequest1 myRequest = new ServiceReference1.registerOfflineRequest1( myRegisterOffline);
            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myRequest);
            string xmlstring = requestwriter.ToString();
            RegOfflineRequest.Text = xmlstring;
            log.Info("Registration off line request XML: " + xmlstring);
            ServiceReference1.registerOfflineResponse1 myResponse = myRegisterOfflineService.registerOffline(myRequest);
            System.Xml.Serialization.XmlSerializer response = new System.Xml.Serialization.XmlSerializer(myResponse.GetType());
            StringWriter responsewriter = new StringWriter();
            response.Serialize(responsewriter, myResponse);
            xmlstring = responsewriter.ToString();
            RegOfflineResponse.Text = xmlstring;
            RegOfflineResponse.Update();
            log.Info("Registration offline Response XML: " + xmlstring);
          

        }

        private void QueryUCRNUsingWapperBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyGovScot.MyAccount.QueryUCRNService.queryUCRN myQueryUCRNRequest = new MyGovScot.MyAccount.QueryUCRNService.queryUCRN("sp_super_admin", UCRNtxt.Text);
                MyGovScot.MyAccount.QueryUCRNService.QueryUCRNServiceClient myQueryUCRNService = new MyGovScot.MyAccount.QueryUCRNService.QueryUCRNServiceClient();
                myQueryUCRNService.ClientCredentials.UserName.UserName = "sp_super_admin";
                myQueryUCRNService.ClientCredentials.UserName.Password = "FFfwsf2cAIp8aow6MHT9Ow==";

                MyGovScot.MyAccount.QueryUCRNService.queryUCRNResponse myQueryUCRNResponse = new MyGovScot.MyAccount.QueryUCRNService.queryUCRNResponse();

                System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myQueryUCRNRequest.GetType());
                StringWriter requestwriter = new StringWriter();
                request.Serialize(requestwriter, myQueryUCRNRequest);
                string xmlstring = requestwriter.ToString();
                log.Info("UCRN Query :" + xmlstring);
                QueryUCRNRequestMessagetxt.Text = xmlstring;

                myQueryUCRNResponse = myQueryUCRNService.queryUCRN(myQueryUCRNRequest);
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myQueryUCRNResponse.GetType());

                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myQueryUCRNResponse);
                xmlstring = resultwriter.ToString();
                UCRNResultstxt.Text = xmlstring;
            }
            catch(Exception ex)
            {
                DisplayException(ex);
                MessageBox.Show(ex.Message);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UCRNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryUCRNRequestMessagetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCRNResultstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void RegisterNoCredentials_Click(object sender, EventArgs e)
        {
            
        }

       

        

        

       

    }
}
