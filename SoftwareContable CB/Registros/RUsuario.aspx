<%@ Page Title="Registro Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="SoftwareContable_CB.Registros.RUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group container">


        <h2 class="control-label" style="text-align: center">Registro de Usuario</h2>

    </div>

    <div class="form-group container">

        <label for="usuarioid">UsuarioId :</label>
        <div class="row container">

            <div style="width: 380px">

                <asp:TextBox Width="350" ID="usuarioid" runat="server" placeholder="0" class="form-control" type="number"></asp:TextBox>
            </div>

            <div class="col-md-5">

                <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="ButtonBuscar_Click" />

            </div>

            <asp:TextBox ID="FechaTextbox" runat="server" class="form-control" type="date" Width="200px"> </asp:TextBox>



        </div>

    </div>


    <div class="form-group container">

        <div class="columns" style="width: 355px">

            <label for="nombreTextbox">Nombre :</label>
            <asp:TextBox ID="nombreTextbox" runat="server" class="form-control" type="text" Width="350px"></asp:TextBox>
            <label for="cedulatextbox">Cedula :</label>
            <asp:TextBox class="form-control" runat="server" ID="cedulatextbox" type="text" Width="350px"></asp:TextBox>

            <label for="Telefonoinput">Telefono :</label>
            <asp:TextBox runat="server" class="form-control" ID="Telefonoinput" type="tel" Width="350px"></asp:TextBox>


            <label for="celularinput">Celular :</label>
            <asp:TextBox runat="server" class="form-control" ID="celularinput" type="tel" Width="350px"></asp:TextBox>

            <label for="Usuarioinput">Nombre Usuario :</label>
            <asp:TextBox runat="server" class="form-control" ID="Usuarioinput" type="text" Width="350px"></asp:TextBox>

            <label for="email">E-Mail :</label>
            <asp:TextBox runat="server" class="form-control" ID="email" type="text" Width="350px"></asp:TextBox>


            <label for="TipodeAccesodrop">TipodeAcceso :</label>
            <asp:DropDownList class="form-control" ID="TipodeAccesodrop" runat="server" for="TipodeAccesolb" Width="350px">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Usuario</asp:ListItem>

            </asp:DropDownList>

            <label for="pwd">Contraseña:</label>
            <asp:TextBox runat="server" type="password" class="form-control" ID="pwd" placeholder="Digite Contraseña" Width="350px"></asp:TextBox>

            <label for="confirmarpwd">Confirmar Contraseña:</label>

            <asp:TextBox type="password" runat="server" class="form-control" ID="confirmarpwd" placeholder="Digite Contraseña" Width="350px"></asp:TextBox>

        </div>
    </div>

    <div class="panel">
        <div class="container" style="width: 350px">
            <asp:Label class="text-center " ID="ErrorLabel" runat="server" Text=""></asp:Label>
            <div class="form-group text-center " style="width: 350px">

                <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" class="btn btn-info" OnClick="ButtonNuevo_Click" />

                <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" class="btn btn-success" OnClick="ButtonGuardar_Click" />

                <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="ButtonEliminar_Click" />


            </div>
        </div>

    </div>




</asp:Content>

