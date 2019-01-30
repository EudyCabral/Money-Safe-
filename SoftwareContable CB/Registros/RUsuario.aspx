<%@ Page Title="Registro Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="SoftwareContable_CB.Registros.RUsuario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

    <div class="form-group container">


        <h2 class="control-label" style="text-align: center">Registro de Usuario</h2>

    </div>

    <div class="form-group container">

        <label for="usuarioid">UsuarioId :</label>
        <div class="row container">

            <div style="width: 380px">

                <asp:TextBox Width="350" ValidationGroup="ValidacionBE" ID="usuarioid" runat="server" placeholder="0" class="form-control" type="number">0</asp:TextBox>
            </div>

            <div class="col-md-5">

                <asp:Button ValidationGroup="ValidacionBE" ID="ButtonBuscar" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="ButtonBuscar_Click" CausesValidation="False" />

            </div>

            <asp:TextBox ID="FechaTextbox" runat="server" class="form-control" type="date" Width="200px"> </asp:TextBox>

        </div>

    </div>


    <div class="form-group container">

        <div class="columns" style="width: 355px">

            <label for="nombreTextbox">Nombre :</label>    
                    
               <asp:RequiredFieldValidator ErrorMessage="*" ID="RequiredFieldValidatorNombre" ControlToValidate="nombreTextbox" Display="Static" runat="server" ForeColor="Red" ValidationGroup="ValidacionGuardar" >*</asp:RequiredFieldValidator>
              <asp:TextBox ID="nombreTextbox" runat="server" class="form-control" type="text" Width="350px" ControlToValidate="nombreTextbox"></asp:TextBox>
        
            <label for="cedulatextbox">Cedula :</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatorCedula" ControlToValidate="cedulatextbox" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>    
            <asp:TextBox class="form-control" runat="server" ID="cedulatextbox" type="text" Width="350px" ></asp:TextBox>
            <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtenderced" runat="server" BehaviorID="cedulatextbox_MaskedEditExtender" MaskType="Number " ClearMaskOnLostFocus="true" Mask="999-9999999-9" TargetControlID="cedulatextbox"></ajaxToolkit:MaskedEditExtender>


            <label for="Telefonoinput">Telefono :</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatortel" ControlToValidate="Telefonoinput" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>
            <asp:TextBox runat="server" class="form-control" ID="Telefonoinput" type="tel" Width="350px"></asp:TextBox>
            <ajaxToolkit:MaskedEditExtender ID="Telefonoinput_MaskedEditExtender" runat="server" BehaviorID="Telefonoinput_MaskedEditExtender" MaskType="Number " ClearMaskOnLostFocus="true" Mask="(999)-999-9999" TargetControlID="Telefonoinput"></ajaxToolkit:MaskedEditExtender>

            <label for="celularinput">Celular :</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatorcel" ControlToValidate="celularinput" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>
            <asp:TextBox runat="server" class="form-control" ID="celularinput" type="tel" Width="350px"></asp:TextBox>
            <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtendercel" runat="server" BehaviorID="celularinput_MaskedEditExtender" MaskType="Number " ClearMaskOnLostFocus="true" Mask="(999)-999-9999" TargetControlID="celularinput"></ajaxToolkit:MaskedEditExtender>

            <label for="Usuarioinput">Nombre Usuario :</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatorUsuario" ControlToValidate="Usuarioinput" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>
            <asp:TextBox runat="server" class="form-control" ID="Usuarioinput" type="text" Width="350px"></asp:TextBox>

          <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatoremail" ControlToValidate="email" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>           
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="email" Text="Correo Incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="ValidacionGuardar" ForeColor="Red"></asp:RegularExpressionValidator>
            <label for="email">E-Mail :</label>
            <asp:TextBox runat="server" class="form-control" ID="email" type="text" Width="350px"></asp:TextBox>

            <label for="TipodeAccesodrop">TipodeAcceso :</label>
            <asp:DropDownList class="form-control" ID="TipodeAccesodrop" runat="server" for="TipodeAccesolb" Width="350px">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Usuario</asp:ListItem>
            </asp:DropDownList>

            <label for="pwd">Contraseña:</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatorpass" ControlToValidate="pwd" Display="Static" runat="server" ForeColor="Red" >*</asp:RequiredFieldValidator>
            <asp:TextBox runat="server" type="password" class="form-control" ID="pwd" placeholder="Digite Contraseña" Width="350px"></asp:TextBox>

            <label for="confirmarpwd">Confirmar Contraseña:</label>
            <asp:RequiredFieldValidator ValidationGroup="ValidacionGuardar" ID="RequiredFieldValidatorconfipass" ControlToValidate="confirmarpwd" Display="Static" runat="server" ForeColor="Red" ErrorMessage="*" >*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator" runat="server" ErrorMessage="Contraseña Invalida" ControlToValidate="confirmarpwd" ControlToCompare="pwd" ForeColor="Red" ValidationGroup="ValidacionGuardar">Contraseña Invalida</asp:CompareValidator>
            <asp:TextBox type="password" runat="server" class="form-control" ID="confirmarpwd" placeholder="Digite Contraseña" Width="350px"></asp:TextBox>

        </div>
    </div>

    <div class="panel">
        <div class="container" style="width: 350px">
            <asp:Label class="text-center " ID="ErrorLabel" runat="server" Text=""></asp:Label>
            <div class="form-group text-center " style="width: 350px">

                <asp:Button  ID="ButtonNuevo" runat="server" Text="Nuevo" class="btn btn-info" OnClick="ButtonNuevo_Click" CausesValidation="False" />

                <asp:Button ValidationGroup="ValidacionGuardar" ID="ButtonGuardar" runat="server" Text="Guardar" class="btn btn-success" OnClick="ButtonGuardar_Click" />

                <asp:Button ValidationGroup="ValidacionBE" ID="ButtonEliminar" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="ButtonEliminar_Click" CausesValidation="False" />


            </div>
        </div>

    </div>

</asp:Content>

