<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emp.aspx.cs" Inherits="Dept_Practice.emp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 885px;
            height: 516px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" Height="374px" OnPageIndexChanging="FormView1_PageIndexChanging" Width="281px" OnModeChanging="FormView1_ModeChanging">
            <EditItemTemplate>
                <asp:Label ID="Label11" runat="server" Text="Emp No"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="eempno" runat="server" Text='<%# Bind("EmpNo") %>' ReadOnly="True"></asp:TextBox>
                <br />
                <asp:Label ID="Label12" runat="server" Text="EName"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="eename" runat="server" Text='<%# Bind("EName") %>'></asp:TextBox>
                <br />
                <asp:Label ID="Label13" runat="server" Text="Job"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ejob" runat="server" Text='<%# Bind("Job") %>'></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label14" runat="server" Text="Mgr"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="emgr" runat="server" Text='<%# Bind("Mgr") %>'></asp:TextBox>
                <br />
                <asp:Label ID="Label15" runat="server" Text="HireDate"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ehiredate" runat="server" Text='<%# Bind("HireDate") %>'></asp:TextBox>
                <br />
                <asp:Label ID="Label16" runat="server" Text="Sal"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="esal" runat="server" Text='<%#Bind("Sal")  %>'></asp:TextBox>
                <br />
                <asp:Label ID="Label17" runat="server" Text="Comm"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ecomm" runat="server" Text='<%#Bind("Comm")  %>'></asp:TextBox>
                <br />
                <asp:Label ID="Label18" runat="server" Text="DeptNo"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="edeptno" runat="server" Text='<%#Bind("DeptNo")  %>'></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Update" runat="server" OnClick="Button1_Click" Text="Update" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                <asp:Label ID="Label21" runat="server" Text="Emp No"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="iempno" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label22" runat="server" Text="EName"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="iename" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label23" runat="server" Text="Job"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ijob" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label24" runat="server" Text="Mgr"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="imgr" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label25" runat="server" Text="HireDate"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ihiredate" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label26" runat="server" Text="Sal"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="isal" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label27" runat="server" Text="Comm"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="icomm" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label28" runat="server" Text="DeptNo"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ideptno" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="insert2" runat="server" OnClick="insert2_Click" Text="Insert" />
                <br />
                <br />
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="Emp No"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="empno" runat="server" Text='<%# Bind("EmpNo") %>'></asp:TextBox>
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
                <asp:Button ID="Insert" runat="server" Height="23px" OnClick="Insert1_Click" Text="Insert" Width="62px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Edit" />
                <br />
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
