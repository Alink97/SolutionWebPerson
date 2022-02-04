<%@ Page Title="Crear" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="WebPerson.Paginas.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Nueva Persona</h1>
    <div>
        Nombre: <asp:TextBox ID="tbName" runat="server" ToolTip="Nombre*" MaxLength="30" />
    </div>
    <div>
        Apellidos: <asp:TextBox ID="tbSurname" runat="server" ToolTip="Apellidos*" MaxLength="60" />
    </div>
    <div>
        Edad: <asp:TextBox ID="tbAge" runat="server" ToolTip="Edad*" MaxLength="3" TextMode="Number" />
    </div>
    <div>
        <asp:Button ID="btnCrearP" runat="server" Text="Crear" ToolTip="Crea la persona (Necesita todos los campos)" Width="85px" OnClick="btnCrearP_Click"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" ToolTip="Vuelve a la pagina inicial" Width="85px" OnClick="btnCancelar_Click"/>
    </div>

</asp:Content>