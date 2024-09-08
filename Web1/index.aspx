<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TÌM MAX MIN</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="color:darkgoldenrod"> Chương Trình Tìm Max Min </h1>
        <h4>Hãy nhập 5 phần tử bất kỳ</h4>
        <asp:Label ID="Label1" runat="server" Height="20" Width="200" Text="Số thứ 1"></asp:Label>
        <asp:TextBox ID="txt_1" runat="server" Height="28" Width="100"></asp:TextBox>
        <asp:Button ID="btn_timkiem" Height="50" Width="70" runat="server" Text="Tìm kiếm" OnClick="btn_timkiem_Click" />

        <br /><br />
        <asp:Label ID="Label2" runat="server" Height="20" Width="200" Text="Số thứ 2"></asp:Label>
        <asp:TextBox ID="txt_2" runat="server" Height="28" Width="100"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Height="20" Width="200" Text="Số thứ 3"></asp:Label>
        <asp:TextBox ID="txt_3" runat="server" Height="28" Width="100"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label4" runat="server" Height="20" Width="200" Text="Số thứ 4"></asp:Label>
        <asp:TextBox ID="txt_4" runat="server" Height="28" Width="100"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label5" runat="server" Height="20" Width="200" Text="Số thứ 5"></asp:Label>
        <asp:TextBox ID="txt_5" runat="server" Height="28" Width="100"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        <br /><br />
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
