<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="myloggedinaccount.aspx.vb" Inherits="WebApplication1.myloggedinaccount" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Authenticated User</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script language=javascript> 
     String username= request.getRemoteUser();
AttributePrincipal principal = (AttributePrincipal) request.getUserPrincipal();
Map attributes = principal.getAttributes();
    </script>
  

    
    </div>
    </form>
</body>
</html>
