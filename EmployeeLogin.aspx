<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeLogin.aspx.cs" Inherits="LoginEntityFramework.CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUName" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUName" runat="server"></asp:TextBox> <br/><br/>

            <asp:Label ID="lblPwd" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox> <br/><br/>

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
