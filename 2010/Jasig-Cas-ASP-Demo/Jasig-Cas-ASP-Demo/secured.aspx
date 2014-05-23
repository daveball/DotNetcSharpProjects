<%@ Page Language="C#" %>
<html>
<head>
  <title>Forms Authentication - Default Page</title>
</head>

<script runat="server">


  void Page_Load(object sender, EventArgs e)
  {



  

     
      
    //Welcome.Text = "Hello, " + Context.User.Identity.Name;
      FormsAuthenticationTicket formsAuthTicket = DotNetCasClient.CasAuthentication.GetFormsAuthenticationTicket();

      DotNetCasClient.CasAuthenticationTicket myCasTicket = DotNetCasClient.CasAuthentication.ServiceTicketManager.GetTicket(formsAuthTicket.UserData);
      

    

      System.Security.Principal.IPrincipal iprinci = (System.Security.Principal.IPrincipal)HttpContext.Current.User;
      
if (iprinci != null) {

    DotNetCasClient.Security.ICasPrincipal icasprinci = (DotNetCasClient.Security.ICasPrincipal)iprinci;
    
    if (icasprinci != null)
    {
        
        String attrs = icasprinci.Assertion.PrincipalName +"( ";
        Dictionary<string, IList<string>> list = icasprinci.Assertion.Attributes;
        Response.Write("********************************************************************<BR>");
        Response.Write("******************        Attributes       *************************<BR>");
        Response.Write("********************************************************************<BR>");
  

        foreach (KeyValuePair<string, IList<string>> pair in list)
        {
                
                Response.Write(pair.Key.ToString() + ":" + pair.Value[0].ToString()  +"<br>");
                   
                    
                    
            Console.WriteLine(pair.Key+": "+pair.Value);
            attrs += "," + pair.Key + ": " + pair.Value[0];
            Label1.Text =" entered loop";

        }
            attrs += " )";
            Welcome.Text = attrs;
     
      
    }    
  }



  }

  
</script>

<body>
  <h3>
    Using Forms Authentication</h3>
  <asp:Label ID="Welcome" runat="server" />
  <asp:Label ID="Label1" runat="server" />
</body>
</html>