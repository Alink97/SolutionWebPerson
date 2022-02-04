<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebPerson.Paginas.Index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Listado de personas</h1>

    <div>Lista de personas que me he inventado.</div>

    <hr />

    <div>
        <asp:Button ID="btnNew" runat="server" Text="Agregar" Width="93px" OnClick="btnNew_Click" />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" Width="93px" OnClick="btnActualizar_Click" />
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" Width="93px" OnClick="btnBorrar_Click" />
    </div>

    <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
        </Columns>

    </asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [persona]"></asp:SqlDataSource>

</asp:Content>
