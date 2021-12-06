<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Balmer peak</div>
        Weight:<asp:TextBox ID="tb_weight" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Button ID="Btn_calc" runat="server" Text="Button" OnClick="Btn_calc_Click" />
        <p>
            <asp:Label ID="Lb_result1" runat="server" Text="cognac"></asp:Label>
        </p>
        <asp:Label ID="Lb_result2" runat="server" Text="port wine"></asp:Label>
        <p>
            <asp:Label ID="Lb_result3" runat="server" Text="dry wine"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Lb_result4" runat="server" Text="Beer"></asp:Label>
        </p>
    </form>
</body>
</html>
