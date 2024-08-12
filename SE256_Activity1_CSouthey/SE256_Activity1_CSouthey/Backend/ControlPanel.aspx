<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="SE256_Activity1_CSouthey.Backend.ControlPanel" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <h2>Conrol Panel</h2>
        <ul>
            <li><a href="EbookMgr.aspx" runat="server">Add an Ebook</a></li>
            <li><asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click" /></li>
        </ul>

    </div>



</asp:Content>
