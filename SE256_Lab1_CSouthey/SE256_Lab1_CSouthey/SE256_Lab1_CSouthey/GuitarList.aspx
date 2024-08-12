<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuitarList.aspx.cs" Inherits="SE256_Lab1_CSouthey.GuitarList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <div>
        <h2>New Guitars in stock!</h2>
        <p>Check out the new Les Paul Studio II, now in a new Sun Burst finish.</p>
    </div>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Guitar Brands</h2>
        <ul>
            <li>Fender</li>
            <li>Gibson</li>
            <li>Jackson</li>
            <li>Ibanez</li>
            <li>ESP</li>
            <li>Schecter</li>
            <li>Mitchell</li>
        </ul>
    </div>
</asp:Content>
