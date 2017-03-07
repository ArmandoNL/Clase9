<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Clase9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="cargar"/>
    </div>

    <asp:GridView ID="grvReporte" runat="server" AllowPaging="true" AllowSorting="true" Style="font: 16px arial; color: grey; border-color: gainsboro; margin-top: 2%; margin-bottom: 2%">

                <SelectedRowStyle BackColor="#7BC143"
                    ForeColor="Black"
                    Font-Bold="true" BorderStyle="Dotted" BorderWidth="1px" />

            </asp:GridView>

</asp:Content>
