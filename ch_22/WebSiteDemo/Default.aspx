﻿<%@ Page Title="Home" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="jumbotron">
        <h1><%: Title %>.</h1>
        <h2>WELCOME TO ASP.NET!</h2>

        <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="ส่งข้อมูล" CssClass="btn btn-primary" />
        <br />
        วันและเวลาปัจจุบันของเครื่องคือ
            <asp:Label ID="lblCurrentDateTime" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        <br />
        ข้อความที่คุณป้อนลงในเท็กซ์บ็อกซ์คือ
            <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>
    </section>
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol>
        <li>
            <h5>Getting Started</h5>
            ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Learn more…</a>
        </li>
        <li>
            <h5>Add NuGet packages and jump-start your coding</h5>
            NuGet makes it easy to install and update free libraries and tools.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Learn more…</a>
        </li>
        <li>
            <h5>Find Web Hosting</h5>
            You can easily find a web hosting company that offers the right mix of features and price for your applications.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
        </li>
    </ol>
</asp:Content>