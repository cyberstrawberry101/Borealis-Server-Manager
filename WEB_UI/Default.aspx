<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_UI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h5>List performance metrics at a glance.</h5>
    <address>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="220px">
            <asp:ListItem>Test1</asp:ListItem>
            <asp:ListItem>Test2</asp:ListItem>
            <asp:ListItem>Test3</asp:ListItem>
            <asp:ListItem>Test4</asp:ListItem>
            <asp:ListItem>Test5</asp:ListItem>
            <asp:ListItem>Test6</asp:ListItem>
            <asp:ListItem>Test7</asp:ListItem>
        </asp:DropDownList>
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
