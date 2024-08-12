<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lesson1_WebCalc_CS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top: 2rem">
        <table>
            <!--LCD screen-->
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="textLCD" runat="server" Columns="20"></asp:TextBox>
                    <asp:Button ID="btnStore" Text="MS" runat="server" OnClick="btnStore_Click" />
                    <asp:Button ID="btnRestore" Text="MR" runat="server" OnClick="btnRestore_Click" />
                    <asp:Button ID="btnClear" Text="MC" runat="server" OnClick="btnClear_Click" />
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Button ID="btn1" Text="1" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn2" Text="2" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn3" Text="3" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btnEquals" Text="=" runat="server" OnClick="btnEquals_Click" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btn4" Text="4" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn5" Text="5" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn6" Text="6" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btnAdd" Text="+" runat="server" OnClick="btnAdd_Click" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btn7" Text="7" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn8" Text="8" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btn9" Text="9" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btnSub" Text="-" runat="server" OnClick="btnSub_Click" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button Text="  " runat="server" />
                    <asp:Button ID="btn0" Text="0" runat="server" OnClick="NumButtons_Click" />
                    <asp:Button ID="btnDiv" Text="/ " runat="server" OnClick="btnDiv_Click" />
                    <asp:Button ID="btnMult" Text="*" runat="server" OnClick="btnMult_Click" />
                </td>
            </tr>










        </table>
    </div>

</asp:Content>
