<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerLogin.aspx.cs" Inherits="PatilesmeDernegi.ManagerPanel.ManagerLogin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patileşme Derneği Panel</title>
    <link href="Assets/CSS/ManagerLoginCSS.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="height: 100%">
        <div class="container">
            <div class="background">
                <img src="Assets/Images/arkaplan.jpg" />
            </div>
            <div class="loginbox">
                <div class="loginContainer">
                    <div style="margin-top: 20px;">
                        <h2>Admin Paneli Giriş</h2>
                    </div>
                    <asp:Panel ID="pnl_hata" runat="server" CssClass="messageBox" Visible="false">
                        <asp:Label ID="lbl_hata" runat="server">Deneme Mesaj İçeriği</asp:Label>
                    </asp:Panel>
                    <div style="margin-top: 15px;">
                        <asp:TextBox ID="tb_mail" runat="server" CssClass="inputBox" placeholder="Mail Adresiniz"></asp:TextBox>
                    </div>
                    <div style="margin-top: 15px;">
                        <asp:TextBox ID="tb_password" runat="server" CssClass="inputBox" placeholder="Şifreniz" TextMode="Password"></asp:TextBox>
                    </div>
                    <div style="margin-top: 15px;">
                        <asp:LinkButton ID="lbtn_giris" runat="server" Text="Giriş Yap" CssClass="loginButton" OnClick="lbtn_giris_Click"> </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
