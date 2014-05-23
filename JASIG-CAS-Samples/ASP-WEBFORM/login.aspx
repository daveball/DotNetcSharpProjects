<%@ Page
	Language           = "C#"
	AutoEventWireup    = "false"
	Inherits           = "ASP_WEBFORM.login"
	ValidateRequest    = "false"
	EnableSessionState = "false"
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>login</title>

		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta http-equiv="CACHE-CONTROL" content="NO-CACHE" />
		<meta http-equiv="PRAGMA" content="NO-CACHE" />

		<link href="ASP_WEBFORM.css" type="text/css" rel="stylesheet" />
		
	    <style type="text/css">
            .style1
            {
                height: 71px;
            }
            .style2
            {
                width: 1027px;
            }
        </style>
		
	</head>
	<body>
		<form id="Form_login" method="post" runat="server">

			<table>

				<tr>
					<td colspan="2">
						Table
					</td>
				</tr>
				<tr>
					<td colspan="2" class="style1">
					
					</td>
				</tr>
				<tr>
				<td>
						Name:
					</td>
					<td class="style2">
						<input id="_Input_Name" runat="server" />
					</td>
				</tr>

				<tr>
					<td colspan="2">
						<input id="_Button_No" type="submit" value="Oh No!" runat="server" />
						<input id="_Button_Ok" type="submit" value="Ok" runat="server" />
					</td>
				</tr>

				<tr>
					<td colspan="2" align="center">
						<a href="?" >Click Here</a>
					</td>
				</tr>

			</table>

		</form>
	</body>
</html>
