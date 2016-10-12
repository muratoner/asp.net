<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MHG.AspNet.Smtp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Text="Sunucu" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbHost" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Port" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbPort" TextMode="Number" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Kullanıcı Adı" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbUsername" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Şifre" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbPasword" Text=""></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Konu" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbSubject" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox runat="server" ID="cbSsl" Text="SSL Kullan" Checked="true"></asp:CheckBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Alıcılar" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbTo" Text=""></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Mesaj" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox TextMode="MultiLine" runat="server" ID="tbMessage" Text=""></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnSend" OnClick="btnSend_Click" Text="Gönder" />
    </div>
    </form>
</body>
</html>
