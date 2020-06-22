<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GUIWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true">
            </asp:DropDownList>
            <asp:Button ID="btnThemDoiBong"   runat="server" Height="24px" OnClick="btnThemDoiBong_Click" Text="+" />
            <asp:Button ID="btnCauThu" runat="server" Text="Hien Thi Cau Thu" OnClick="btnCauThu_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Ma cau Thu"></asp:Label>
        <asp:TextBox ID="txtIDCauThu" runat="server" Width="129px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ten Cau Thu"></asp:Label>
            <asp:TextBox ID="txtTenCauThu" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="So Dien Thoat"></asp:Label>
            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="btnThem" runat="server" Text="Them" OnClick="btnThem_Click" />
            <asp:Button ID="btnLuu" runat="server" Text="Luu" OnClick="btnLuu_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnXoa" runat="server" Text="Xoa" OnClick="btnXoa_Click" />
        </p>
    </form>
</body>
</html>
