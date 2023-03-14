<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerPanel/ManagerLogin.Master" AutoEventWireup="true" CodeBehind="PublicationAdd.aspx.cs" Inherits="PatilesmeDernegi.ManagerPanel.PublicationAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="eklesidebar">
        <div class="Titleekle">
            <h3>İLAN EKLE</h3>
        </div>
        <div class="Contentekle">
            <div class="row" style="margin-top: 30px; color: black; font-size: 18px;">
                <label>Kategori</label><br />
                <asp:DropDownList ID="ddl_AnimalKategory" runat="server" CssClass="inputBox" AppendDataBoundItems="true"  style="width:200px; background-color: palevioletred;height:30px;">
                    <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:TextBox ID="tb_title" runat="server" CssClass="textbox" placeholder="Başlık Giriniz"></asp:TextBox>
            <asp:TextBox ID="tb_content" runat="server" CssClass="textbox" placeholder="İçerik Giriniz"></asp:TextBox>

            <asp:FileUpload ID="fu_resim" runat="server" CssClass="resimEkle"></asp:FileUpload>
            <asp:LinkButton ID="lbtn_ekle" runat="server" Style="text-decoration: none; color: palevioletred; font-size: 18pt;"
                OnClick="lbtn_ekle_Click">EKLE </asp:LinkButton>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarili" Visible="false">
                İlan Ekleme Başarılı
            </asp:Panel>
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisiz" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </div>
    <div style="clear: both"></div>
</asp:Content>
