/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 24/01/2014
 * Time: 11:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.IO;
using System.Net;
using System.Xml;
using DotNetCasClient;

namespace ASP_WEBFORM
{
	/// <summary>
	/// Description of login
	/// </summary>
	public class login : Page
	{	
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Data

		protected	HtmlInputButton		_Button_Ok;
		protected	HtmlInputText		_Input_Name;
        private const string CASHOST = "http://is-jasig-cas:8080";
 
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Page Init & Exit (Open/Close DB connections here...)

		protected void PageInit(object sender, System.EventArgs e)
		{
		}
		//----------------------------------------------------------------------
		protected void PageExit(object sender, System.EventArgs e)
		{
		}

		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Page Load
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Look for the "ticket=" after the "?" in the URL
			   //string AuthorisationTicket = Request.QueryString["ticket"];
 
			  string tkt = Request.QueryString["ticket"];
			 
			  // This page is the CAS service=, but discard any query string residue
			  string service = Request.Url.GetLeftPart(UriPartial.Path);
			 
			  // First time through there is no ticket=, so redirect to CAS login
			  if (tkt == null || tkt.Length == 0)
			  {
			    string redir = CASHOST + "login?" +
			      "service=" + service;
			    Response.Redirect(redir);
			    return;
			  }
			 
			  // Second time (back from CAS) there is a ticket= to validate
			  string validateurl = CASHOST + "serviceValidate?" +
			    "ticket=" + tkt + "&"+
			    "service=" + service;
			  StreamReader Reader = new StreamReader( new WebClient().OpenRead(validateurl));
			  string resp = Reader.ReadToEnd();
			  // I like to have the text in memory for debugging rather than parsing the stream
			 
			  // Some boilerplate to set up the parse.
			  NameTable nt = new NameTable();
			  XmlNamespaceManager nsmgr = new XmlNamespaceManager(nt);
			  XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.None);
			  XmlTextReader reader = new XmlTextReader(resp, XmlNodeType.Element, context);
			 
			  string netid = null;
			 
			  // A very dumb use of XML. Just scan for the "user". If it isn't there, its an error.
			  while (reader.Read())
			  {
			    if (reader.IsStartElement()) {
			      string tag = reader.LocalName;
			      if (tag=="user")
			        netid = reader.ReadString();
			    }
			  }
			  // if you want to parse the proxy chain, just add the logic above
			  reader.Close();
			  // If there was a problem, leave the message on the screen. Otherwise, return to original page.
			  if (netid == null)
			  {
			    //Label1.Text = "CAS returned to this application, but then refused to validate your identity.";
			  }
			  else
			  {
			    //Label1.Text = "Welcome " + netid;
			    FormsAuthentication.RedirectFromLoginPage(netid, false); // set netid in ASP.NET blocks
			  }
			//.Write(@"Hello #Develop<br>");
			//------------------------------------------------------------------
			//if(IsPostBack)
			//{
			//}
			//------------------------------------------------------------------
		}
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Click_Button_OK

		//----------------------------------------------------------------------
		protected void Click_Button_Ok(object sender, System.EventArgs e)
		{
			Response.Write( _Button_Ok.Value + " was cklicked!<br>");
		}

		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Change_Input_Name

		//----------------------------------------------------------------------
		protected void Changed_Input_Name(object sender, System.EventArgs e)
		{
			Response.Write( _Input_Name.Value + " has changed!<br>");
		}

		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Add more events here...

		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Initialize Component

		protected override void OnInit(EventArgs e)
		{	InitializeComponent();
			base.OnInit(e);
		}
		//----------------------------------------------------------------------
		private void InitializeComponent()
		{	//------------------------------------------------------------------
			this.Load	+= new System.EventHandler(Page_Load);
			this.Init   += new System.EventHandler(PageInit);
			this.Unload += new System.EventHandler(PageExit);
			//------------------------------------------------------------------
			_Button_Ok.ServerClick	 += new EventHandler(Click_Button_Ok);
			_Input_Name.ServerChange += new EventHandler(Changed_Input_Name);
			//------------------------------------------------------------------
		}
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}
}
