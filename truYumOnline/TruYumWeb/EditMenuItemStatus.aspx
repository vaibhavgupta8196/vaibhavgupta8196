<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditMenuItemStatus.aspx.cs" Inherits="TruYumWeb.EditMenuItemStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Menu Item Status</title>
    <link href="styles/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 58px;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
		<h3 id="tru">
            <asp:HyperLink ID="tru" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListAdmin.aspx">truYum</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp; </h3>
		<img id="img" src="images/download.png" class="auto-style1">&nbsp;
        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="ShowMenuItemsListAdmin.aspx"><u id="menu">&nbsp;</u><asp:HyperLink ID="Menu" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListAdmin.aspx">Menu</asp:HyperLink>
            </a>&nbsp;&nbsp;&nbsp;&nbsp; </h3>
	</header>&nbsp;<br></br>
<br</br><h1 id="item1">Edit Menu Item Status</h1>
<p id="success"> <b>Menu Item Details Saved Successfully</b></p>
<footer><p id="foot">Copyright &#169; 2019</p>
</footer>
    </form>
</body>
</html>
