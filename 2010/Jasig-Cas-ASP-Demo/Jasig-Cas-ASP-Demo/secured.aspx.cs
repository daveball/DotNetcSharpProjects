using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;
using DotNetCasClient.Validation.Schema.Saml11;

public partial class secured_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //FormsAuthenticationTicket formsAuthTicket = DotNetCasClient.CasAuthentication.GetFormsAuthenticationTicket();


        //DotNetCasClient.Security.IAssertion myAssertion;
        //DotNetCasClient.CasAuthenticationTicket casTicket = new DotNetCasClient.CasAuthenticationTicket("myticket", "MyDemo", "PB6BDMV", myAssertion);
        //casTicket = DotNetCasClient.CasAuthentication.ServiceTicketManager.GetTicket(formsAuthTicket.UserData);
        //DotNetCasClient.CasAuthenticationTicket myticket;



        //foreach (System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IList<string>> myticketAssertion in casTicket.Assertion.Attributes)
        //{
        //    Response.Write(myticketAssertion.Key.ToString() + " : " + myticketAssertion.Value.ToString() + "<br>");
        //}
      
    }
}