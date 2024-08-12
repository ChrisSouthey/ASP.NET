<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuitarStock.aspx.cs" Inherits="SE256_Lab1_CSouthey.Backend.GuitarStock" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <a href="ControlPanel.aspx" runat="server">Return to Control Panel</a>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table>

        <!--Guitar ID-->
        <tr>
            <td>Guitar ID</td>
            <td><asp:Label ID="lblGuitar_ID" runat="server" /></td>
        </tr>

        <!--Guitar Brand-->
        <tr>
            <td>Guitar Brand</td>
            <td><asp:TextBox ID="txtBrand" runat="server" MaxLength="20"/></td>
        </tr>

        <!--Guitar Model-->
        <tr>
            <td>Guitar Model</td>
            <td><asp:TextBox ID="txtModel" runat="server" MaxLength="50"/></td>
        </tr>

        <!--Guitar Color-->
        <tr>
            <td>Guitar Color</td>
            <td><asp:TextBox ID="txtColor" runat="server" MaxLength="20"/></td>
        </tr>

        <!--Guitar Price-->
        <tr>
            <td>Guitar Price</td>
            <td><asp:TextBox ID="txtPrice" runat="server" MaxLength="10"/></td>
        </tr>

        <!--Guitar Strings-->
        <tr>
            <td># of Strings</td>
            <td><asp:TextBox ID="txtStrings" runat="server" MaxLength="30"/></td>
        </tr>


    </table>

    <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add Guitar" OnClick="btnAdd_Click" />

    <br />
    <asp:Label ID="lblFeedback" runat="server" />


</asp:Content>
