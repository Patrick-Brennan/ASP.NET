<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="session_one.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="height: 22px">
                <asp:Label ID="lblStudentName" Width="80" runat="server" Text="Student Name" Font-Italic="True"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblGender" runat="server" Text="Sex"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RbtnGender" runat="server">
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCourses" runat="server" Text="Select course"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpDownCourses" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSubmit" Text="SUBMIT feedback" OnClick="btnSubmit_Click"/>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</asp:Content>
