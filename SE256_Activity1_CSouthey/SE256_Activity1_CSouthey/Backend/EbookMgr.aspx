<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EbookMgr.aspx.cs" Inherits="SE256_Activity1_CSouthey.Backend.EbookMgr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">

    <a href="~/Backend/ControlPanel.aspx" runat="server">Return to Control Panel</a>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <table>

        <%-- BookID ID --%>
        <tr>
            <td>Book ID</td>
            <td><asp:Label ID="lblBookID" runat="server" /></td>
        </tr>

        <%-- Book Title --%>
        <tr>
            <td>Book Title</td>
            <td><asp:TextBox ID="txtTitle" runat="server" MaxLength="255"/></td>
        </tr>

        <%-- Author First --%>
        <tr>
            <td>Author First Name</td>
            <td><asp:TextBox ID="txtAuthorFirst" runat="server" MaxLength="30"/></td>
        </tr>

        <%-- Author Last --%>
        <tr>
            <td>Author Last Name</td>
            <td><asp:TextBox ID="txtAuthorLast" runat="server" MaxLength="40"/></td>
        </tr>

         <%-- Author Email --%>
        <tr>
            <td>Author Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" MaxLength="40"/></td>
        </tr>

         <%-- Date Published --%>
        <tr>
            <td>Date Published</td>
            <td><asp:Calendar ID="calDatePublished" runat="server" /></td>
        </tr>

         <%-- Pages --%>
        <tr>
            <td>Pages</td>
            <td><asp:TextBox ID="txtPages" runat="server" MaxLength="5"/></td>
        </tr>

         <%-- Price --%>
        <tr>
            <td>Price</td>
            <td>$<asp:TextBox ID="txtPrice" runat="server" MaxLength="10"/></td>
        </tr

        <%-- Rental Expires --%>
        <tr>
            <td>Date Rental Expires</td>
            <td><asp:Calendar ID="calDateRentalExpires" runat="server" /></td>
        </tr>

        <%-- Bookmark Page --%>
        <tr>
            <td>Bookmar Page</td>
            <td><asp:TextBox ID="txtBookmarkPage" runat="server" MaxLength="5"/></td>
        </tr>

    </table>

    <asp:Button ID="btnAdd" runat="server" Text="Add a Book" OnClick="btnAdd_Click" />

    <br />
    <br />

    <asp:Label ID="lblFeedback" runat="server" />


</asp:Content>
