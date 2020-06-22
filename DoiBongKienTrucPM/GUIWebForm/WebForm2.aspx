<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="GUIWebForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Ma Doi Bong"></asp:Label>
        <asp:TextBox ID="txtMaDoiBong" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ten Doi Bong"></asp:Label>
            <asp:TextBox ID="txtTenDoiBong" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnThemDoi" runat="server" OnClick="btnThemDoi_Click" Text="Them" />
        <asp:Button ID="btnThoat" runat="server" OnClick="btnThoat_Click" Text="Thoat" />
    </form>
</body>
</html>
