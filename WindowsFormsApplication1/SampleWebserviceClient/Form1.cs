using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Windows;
using System.Diagnostics;
using System.Collections;
using System.ServiceModel;

namespace SampleWebserviceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QueryUCRNUsingWapperBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyGovScot.MyAccount.QueryUCRNService.queryUCRN myQueryUCRNRequest = new MyGovScot.MyAccount.QueryUCRNService.queryUCRN("cecagent", UCRNtxt.Text);
                MyGovScot.MyAccount.QueryUCRNService.QueryUCRNServiceClient myQueryUCRNService = new MyGovScot.MyAccount.QueryUCRNService.QueryUCRNServiceClient();
               
                myQueryUCRNService.ClientCredentials.UserName.UserName = "cecagent";
                myQueryUCRNService.ClientCredentials.UserName.Password = "Agent@1234";

                MyGovScot.MyAccount.QueryUCRNService.queryUCRNResponse myQueryUCRNResponse = new MyGovScot.MyAccount.QueryUCRNService.queryUCRNResponse();

                System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myQueryUCRNRequest.GetType());
                StringWriter requestwriter = new StringWriter();
                request.Serialize(requestwriter, myQueryUCRNRequest);
                string xmlstring = requestwriter.ToString();
              
                QueryUCRNRequestMessagetxt.Text = xmlstring;

                myQueryUCRNResponse = myQueryUCRNService.queryUCRN(myQueryUCRNRequest);
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myQueryUCRNResponse.GetType());

                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myQueryUCRNResponse);
                xmlstring = resultwriter.ToString();
                UCRNResultstxt.Text = xmlstring;
            }
            catch (Exception ex)
            {
                //DisplayException(ex);
                MessageBox.Show(ex.Message);

            }
        }

        private void QueryUCRNBtn_Click(object sender, EventArgs e)
        {
            try{
                ServiceReference2.QueryUCRNServiceUnsignedClient myQueryUCRNService =  new ServiceReference2.QueryUCRNServiceUnsignedClient();
            //ServiceReference1.QueryUCRNServiceClient  myQueryUCRNService = new ServiceReference1.QueryUCRNServiceClient();
                ServiceReference2.queryUCRNResponse1 myResponse = new ServiceReference2.queryUCRNResponse1();
                //ServiceReference1.queryUCRNResponse1 myResponse = new ServiceReference1.queryUCRNResponse1();
                //myQueryUCRNService.ClientCredentials = new System.ServiceModel.Description.ClientCredentials();
                myQueryUCRNService.ChannelFactory.Endpoint.Behaviors.Remove<System.ServiceModel.Description.ClientCredentials>();
                myQueryUCRNService.ChannelFactory.Endpoint.Behaviors.Add(new CustomCredentials());

                myQueryUCRNService.ClientCredentials.UserName.UserName = "testsp@cas.com";
                myQueryUCRNService.ClientCredentials.UserName.Password = "Agent@1234";
                //myQueryUCRNService.ClientCredentials.UserName.UserName = "cecagent";
                //myQueryUCRNService.ClientCredentials.UserName.Password = "Agent@1234";
            
                 ServiceReference2.queryUCRNResponse myQueryUCRNResponse = new   ServiceReference2.queryUCRNResponse();
            ServiceReference2.QueryUCRNRequest myQueryUCRNRequest = new   ServiceReference2.QueryUCRNRequest();
              ServiceReference2.queryUCRN myqueryUCRN = new   ServiceReference2.queryUCRN();
             ServiceReference2.RequestBody myRequestBody = new    ServiceReference2.RequestBody();
           
              ServiceReference2.UCRNType myUCRNType = new   ServiceReference2.UCRNType();
            myUCRNType.UCRNType1Specified = false;
            //myUCRNType.UCRNType1 = QueryUCRNService.UCRNTypeUCRNType.P;
            myUCRNType.Value = UCRNtxt.Text;


           
            myQueryUCRNRequest.RequestBody = new   ServiceReference2.RequestBody();
            
           
            myQueryUCRNRequest.RequestBody.Item = myUCRNType;
            myqueryUCRN.queryUCRNRequest = myQueryUCRNRequest;

            ServiceReference2.queryUCRNRequest1 myqueryUCRNRequest1 = new ServiceReference2.queryUCRNRequest1("testsp@cas.com", myqueryUCRN);
            System.Xml.Serialization.XmlSerializer request = new System.Xml.Serialization.XmlSerializer(myqueryUCRNRequest1.GetType());
            StringWriter requestwriter = new StringWriter();
            request.Serialize(requestwriter, myqueryUCRNRequest1);
            string xmlstring = requestwriter.ToString();
               
            QueryUCRNRequestMessagetxt.Text = xmlstring;

            myQueryUCRNResponse = myQueryUCRNService.queryUCRN("testsp@cas.com", myqueryUCRN);
                System.Xml.Serialization.XmlSerializer result = new System.Xml.Serialization.XmlSerializer(myQueryUCRNResponse.GetType());

                StringWriter resultwriter = new StringWriter();
                result.Serialize(resultwriter, myQueryUCRNResponse);
                xmlstring = resultwriter.ToString();
                UCRNResultstxt.Text = xmlstring;
            }
            catch(Exception se)
            {
                MessageBox.Show(se.Message);
               
            }
        }
    }
}
