/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 06/02/2014
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CASRefreshWebserviceSampleApplication
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void QueryUPRNBtnClick(object sender, EventArgs e)
		{
			//Create the query service
			
			
			CAS.QueryUPRN.QueryUPRNService myQueryUPRNService  = new CAS.QueryUPRN.QueryUPRNServiceClient();
			
			//Create a queryResponse1
			CAS.QueryUPRN.queryUPRNResponse1 myQueryUPRNresponse = new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.queryUPRNResponse1();
			// Create a queryUPRN
			CAS.QueryUPRN.queryUPRN myQueryUPRN = new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.queryUPRN();
	
			CAS.QueryUPRN.QueryUPRNRequest	myQueryUPRNRequest = new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.QueryUPRNRequest();
			CAS.QueryUPRN.RequestBody myRequestBody = new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.RequestBody();
			//myRequestBody.Item myItem = new CAS.QueryUPRN.RequestBody.Item();
			
			CAS.QueryUPRN.UPRNType myUPRNType =  new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.UPRNType();
			myUPRNType.UPRNType1= "P";
			myUPRNType.Value= UPRNtxt.Text;
			myQueryUPRNRequest.RequestBody = myRequestBody;
			myRequestBody.Item= myUPRNType;
			
			//myUPRNType.UPRNType1.Insert(0,UPRNtxt.ToString());
			//myQueryUPRN.queryUPRNRequest.RequestBody = myRequestBody;
			
		//Create a queryUPRNRequest1 usign the QueryUPRN define earlier
			
			CAS.QueryUPRN.queryUPRNRequest1 myQueryUPRNRequest1 = new CASRefreshWebserviceSampleApplication.CAS.QueryUPRN.queryUPRNRequest1("101",myQueryUPRN);
			
				//Send  query message to webservice and save results in a queryUPRNResposne1
			myQueryUPRNresponse=	myQueryUPRNService.queryUPRN(myQueryUPRNRequest1);
				
				
		}
	}
}
