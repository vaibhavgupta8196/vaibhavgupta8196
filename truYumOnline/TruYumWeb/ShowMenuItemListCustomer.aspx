<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMenuItemListCustomer.aspx.cs" Inherits="TruYumWeb.ShowMenuItemListCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TruYum Online</title>
    
    <link href="styles/style.css" rel="stylesheet" />
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
   
     <p>
&nbsp;<asp:Label ID="Label1"  runat="server" Text="Menu Items" Font-Size="30pt"></asp:Label>
        </p>
     <p>
         &nbsp;</p>
        <div>

            <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" OnRowCommand="grid1_RowCommand1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Menu Item Id" >
                    <HeaderStyle CssClass="gridview-hidden-coloumn" />
                    <ItemStyle CssClass="gridview-hidden-coloumn" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Active" HeaderText="Active" />
                    <asp:BoundField DataField="DateOfLaunch" HeaderText="Date Of Launch" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="FreeDelivery" HeaderText="Free Delivery" />
                    <asp:ButtonField HeaderText="Action" Text="Add To Cart" CommandName="Add" />
                </Columns>
            </asp:GridView>




            

        </div>
         <footer><p id="foot">Copyright &#169; 2019; 2019r></footer>
    </form>
    
</body>
</html>
