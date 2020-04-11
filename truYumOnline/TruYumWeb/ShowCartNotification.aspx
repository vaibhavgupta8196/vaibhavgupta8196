<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowCartNotification.aspx.cs" Inherits="TruYumWeb.ShowCartNotification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Menu Item</title>
    <link href="styles/style.css" rel="stylesheet" />
    <script src="js/script.js"></script>
    </head>
<body>
    <form id="form1" runat="server">
        <header>
		<h3 id="tru">
            <asp:HyperLink  ID="HyperLink_truyum" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListCustomer.aspx">truYum</asp:HyperLink>
            </h3>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<img id="img" src="images/download.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" NavigateUrl="~/ShowMenuItemListCustomer.aspx">Menu</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
             
             <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="White" NavigateUrl="~/ShowCart.aspx">Cart</asp:HyperLink>
             
        </header>
         <br />
         <h id="item">
        <br />
        Cart</h><br />
         <asp:GridView ID="gridcart" runat="server" AutoGenerateColumns="False" OnRowCommand="gridcart_RowCommand">
             <Columns>
                 <asp:BoundField DataField="Id" HeaderText="Menu Item Id" >
                 <HeaderStyle CssClass="gridview-hidden-coloumn" />
                 <ItemStyle CssClass="gridview-hidden-coloumn" />
                 </asp:BoundField>
                 <asp:BoundField DataField="Name" HeaderText="Name" />
                 <asp:BoundField DataField="FreeDelivery" HeaderText="Free Delivery" />
                 <asp:BoundField DataField="Price" HeaderText="Price" />
                 <asp:CommandField EditText="Delete" ShowDeleteButton="True" />
             </Columns>
         </asp:GridView>
&nbsp;<div>
             <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
             :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="Total" runat="server"></asp:TextBox>
        </div>
         <footer><p id="foot">Copyright &#169; 2019</p>
</footer>
    </form>
</body>
</html>
