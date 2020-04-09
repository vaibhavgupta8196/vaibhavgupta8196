<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emp.aspx.cs" Inherits="Dept_Practice.emp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 885px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" Height="374px" OnPageIndexChanging="FormView1_PageIndexChanging" Width="281px">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox9" runat="server" ></asp:TextBox>
            </EditItemTemplate>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="Emp No"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="empno" runat="server" Text='<%#Bind("EmpNo")  %>' AutoPostBack="True"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="EName"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ename" runat="server" Text='<%# Bind("EName") %>' ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Job"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="job" runat="server"  Text='<%#Bind("Job")  %>'  ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Mgr"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="mgr" runat="server" Text='<%#Bind("Mgr")  %>' ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="HireDate"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="hiredate" runat="server" Text='<%#Bind("HireDate")  %>'></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Sal"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="sal" runat="server" Text='<%#Bind("Sal")  %>' ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Comm"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="comm" runat="server" Text='<%#Bind("Comm")  %>'  ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="DeptNo"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="deptno" runat="server" Text='<%#Bind("DeptNo")  %>' ></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Insert" runat="server" Height="23px" OnClick="Button3_Click" Text="Insert" Width="62px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Update" runat="server" OnClick="Button1_Click" Text="Update" />
                &nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Delete" runat="server" OnClick="Button2_Click" Text="Delete" />
                <br />
            </ItemTemplate>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
