<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMenuItemListAdmin.aspx.cs" Inherits="TruYumWeb.ShowMenuItemListAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" >
    <title>TruYum Online</title>
    <link href="styles/style.css" rel="stylesheet" />    
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
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListAdmin.aspx">Menu</asp:HyperLink>
            </u>
        </header><br></br>
        <asp:Label ID="Label1" runat="server" Font-Size="30pt" Text="Menu Items"></asp:Label>
    <br</br>
        <h >
        <br />
        <br /></h>
        <div style="width: 648px">
            <asp:GridView ID="gridMenuItemList" runat="server" AutoGenerateColumns="False" OnRowEditing="gridMenuItemList_RowEditing" OnRowUpdating="gridMenuItemList_RowUpdating" OnSelectedIndexChanged="gridMenuItemList_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Menu Item Id" >
                    <HeaderStyle CssClass="gridview-hidden-coloumn" />
                    <ItemStyle CssClass="gridview-hidden-coloumn" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Active" HeaderText="Active" />
                    <asp:BoundField DataField="DateOfLaunch" HeaderText="DateOfLaunch" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="FreeDelivery" HeaderText="Free Delivery" />
                    <asp:CommandField HeaderText="Action" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    <footer><p id="foot">Copyright &#169; 2019</p>
</footer>
        
    </form>
    </body>
</html>
