<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerPanel/ManagerLogin.Master" AutoEventWireup="true" CodeBehind="PublicationEdit.aspx.cs" Inherits="PatilesmeDernegi.ManagerPanel.PublicationEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Titleekle">
        <h3>İLAN DÜZENLE</h3>
    </div>
    <div class="row">
        <label>Kategori</label><br />
        <asp:DropDownList ID="ddl_Publication" runat="server" CssClass="inputBox" AppendDataBoundItems="true" Style="width: 415px">
            <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="Contentekle">

        <div class="row">
            <asp:TextBox ID="tb_title" runat="server" CssClass="textbox" placeholder="Başlık Giriniz"></asp:TextBox>

        </div>
        <div class="row">
            <asp:TextBox ID="tb_content" runat="server" CssClass="textbox" placeholder="İçerik Giriniz"></asp:TextBox>

        </div>
        <div class="row">
            <asp:Image ID="img_resim" runat="server" Width="100" />
            <br />
            
            <asp:FileUpload ID="fu_resim" runat="server" style="margin-top:30px; "></asp:FileUpload>
        </div>
        <div class="row">
            <asp:LinkButton ID="lbtn_duzenle" runat="server" Text="Düzenle" style="margin-top:30px;" CssClass="formbutton" OnClick="lbtn_duzenle_Click"></asp:LinkButton>
        </div>
        <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarili" Visible="false">
            İlan Düzenleme Başarılı
        </asp:Panel>
        <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisiz" Visible="false">
            <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
        </asp:Panel>
        <div style="clear: both"></div>
    </div>
</asp:Content>
