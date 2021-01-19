<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="KabezaWebApplication_New.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <asp:Label runat="server" Text="Label"></asp:Label>
    <title></title>
</head>
    <body>
        <h1>
            Welcome to my site......!
        </h1>
    </body>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" ForeColor="Green" Text="Type Your FullName"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
    </form>
</body>
</html>
