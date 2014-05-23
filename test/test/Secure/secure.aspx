<%@ Page
	Language           = "C#"
	AutoEventWireup    = "false"
	Inherits           = "test.Secure.secure"
	ValidateRequest    = "false"
	EnableSessionState = "false"
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>secure</title>

		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta http-equiv="CACHE-CONTROL" content="NO-CACHE" />
		<meta http-equiv="PRAGMA" content="NO-CACHE" />

		<link href="test.Secure.css" type="text/css" rel="stylesheet" />
		
	</head>
	<body>
		<form id="Form_secure" method="post" runat="server">

			<H2 align="center">Shibboleth Test Page</H2> 
        <BR>
        <BR>
         <I>Authenticated User Information </I>
        (information received from your IdP, if any, will be populated below):<BR><BR>
         <TABLE> 
             <TR>
                 <TD><B>First name:</B></TD>
                 <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_GIVENNAME")%>"></TD>

             </TR>
              <TR>
                  <TD><B>Last name:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_SN")%>"></TD>

              </TR> <TR><TD><B>Email address:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_MAIL")%>"></TD>

                    </TR>
              <TR>
                  <TD><B>eduPersonPrincipalName:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_EPPN")%>"></TD>

              </TR> 
             <TR>
                 <TD><B>REMOTE_USER:</B></TD>
                 <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_REMOTEUSER")%>"></TD>

             </TR>

         </TABLE>
         <BR>
        <BR>
        <BR>
         <HR> <H2>Raw HTTP Server Variables</H2> 
        <TABLE BORDER=1> 
            <TR>
                <TD VALIGN=TOP><B>Variable</B></TD>
                <TD VALIGN=TOP><B>Value</B></TD>

            </TR> <% For Each key in Request.ServerVariables %> <%If Trim(key) <> "HTTP_SHIBSPOOFCHECK" Then%> 
            <TR> <TD><% = key %></TD>
                <TD> <% if Request.ServerVariables(key) = "" Then Response.Write "&nbsp" ' To force border around table cell else Response.Write Request.ServerVariables(key) end if Response.Write "</TD>" %> </TR>
             <%End IF Next %>

        </TABLE>

		</form>
	</body>
</html>
