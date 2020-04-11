<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEditMenuItem.aspx.cs" Inherits="TruYumWeb.ShowEditMenuItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Menu Item</title>
    <link href="styles/style.css" rel="stylesheet" />
    <script src="js/script.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
		<h3 id="tru">
            <asp:HyperLink  ID="HyperLink_truyum" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListAdmin.aspx">truYum</asp:HyperLink>
            </h3>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<img id="img" src="images/download.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <u >
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListAdmin.aspx">Products</asp:HyperLink>
            </u>
        </header>
        <h id="item">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Size="30pt" Text="Edit Menu Items"></asp:Label>
        </h>
        <br><b><asp:Label ID="name" runat="server" Text="Name"></asp:Label></b>
        <br>
    <asp:TextBox ID="text"   runat="server" ViewStateMode="Enabled" ></asp:TextBox>
&nbsp;<br />
        <table id="table">
	<tr><th class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Price(₹)"></asp:Label>
        </th>
		<th class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Active"></asp:Label>
        </th>
	`	<th class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Date Of Launch"></asp:Label>
        </th>
		<th class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
        </th></tr>
	<tr><td>&nbsp;<asp:TextBox ID="price" runat="server" Width="97px"></asp:TextBox>
        </td>
		<td>
            <asp:RadioButton ID="yes" runat="server" GroupName="g" Text="Yes" checked />
            <asp:RadioButton ID="no" runat="server" GroupName="g" Text="No" />
        </td>
	<td>
        <asp:TextBox ID="dateOfLaunch" runat="server" TextMode="Date" ></asp:TextBox>
        </td>
	<td>
        <asp:DropDownList ID="category" runat="server">
            <asp:ListItem Selected="True">Starters</asp:ListItem>
            <asp:ListItem>Dessert</asp:ListItem>
            <asp:ListItem>Main Course</asp:ListItem>
            <asp:ListItem>Drinks</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
	<tr><td>
        <asp:CheckBox ID="freeDelivery" runat="server" Text="Free Delivery" />
        </td>
	</tr>
	<tr><td>
        <asp:Button ID="save" runat="server" BackColor="Blue" OnClientClick ="return callme()" ForeColor="White" Text="Save" OnClick="save_Click" />
        </td>
	</tr>

</table>
        
    <footer><p id="foot">Copyright &#169; 2019</p>
</footer>
    </form>
</body>
</html>
