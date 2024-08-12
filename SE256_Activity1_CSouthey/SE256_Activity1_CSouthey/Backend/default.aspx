<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SE256_Activity1_CSouthey.Backend._default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        USERNAME: <asp:TextBox ID="txtUsername" runat="server" />
        <br />
        <br />
        PASSWORD: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblFeedback" runat="server" Text="" />
                  

    </div>



</asp:Content>
