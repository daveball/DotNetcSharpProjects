<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="WebApplication1.login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <script type="text/javascript" src="Scripts/porthole.js"></script>
<script type="text/javascript" src="Scripts/json2.js"></script>
<script type="text/javascript" src="Scripts/message.js"></script>

 
     
    <div>  <iframe id="loginFrame" name="loginFrame" width="280px" height="400px"  frameborder="0" src="https://is-jasig-cas:8443/cas-server-webapp-3.5.2/login?service=HTTP://pb6bdmv/WebApplication1/*&ViewType=pluginView" style="overflow: hidden;padding:0; "></iframe>
    </div>
    </form>
</body>
</html>
