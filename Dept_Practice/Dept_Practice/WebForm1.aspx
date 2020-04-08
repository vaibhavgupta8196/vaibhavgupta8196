<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Dept_Practice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="DName" HeaderText="Dname" />
                <asp:BoundField DataField="DeptNo" HeaderText="Dno" />
                <asp:BoundField DataField="Loc" HeaderText="LOC" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:FormView ID="FormView1" runat="server">
        </asp:FormView>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextField="DName" DataValueField="DName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
