<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerPanel/ManagerLogin.Master" AutoEventWireup="true" CodeBehind="PublicationList.aspx.cs" Inherits="PatilesmeDernegi.ManagerPanel.PublicationList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="lv_publist" runat="server">
        <LayoutTemplate>
            <table class="publist" border="1" cellspacing="0">
                <thead>
                        <th>İlan Numarası</th>
                        <th>Başlık</th>
                        <th>İçerik</th>
                        <th>Resim</th>
                        <th>Tarih</th>
                        <th>Saat</th>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("ID") %></td>
                
                <td><%#Eval("Title") %></td>
                <td><%#Eval("Content") %></td>
                <td><img src =" ../ManagerPanel/Assets/Images" /><%#Eval("Images") %> </td>
                <td><%#Eval("DateStr") %></td>
                <td><%#Eval("TimeStr") %></td>
                 <td>
                        <a href='PublicationEdit.aspx?pid=<%#Eval("ID")%>' class="duzenle">Düzenle</a>
                        

                    </td
            </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
