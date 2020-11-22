<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="$safeprojectname$.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Purple" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Blue" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Pink" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Green" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Red" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Yellow" />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Black" />
    </form>
</body>
</html>
