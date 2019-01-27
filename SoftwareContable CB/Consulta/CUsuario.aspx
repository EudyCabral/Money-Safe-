<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CUsuario.aspx.cs" Inherits="SoftwareContable_CB.Consulta.CUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div class="form-group container">
            
                <h2 class="control-label" style=" text-align:center">Consulta de Usuario</h2>
       
               
       </div>

       
    
                            <div class="container align-content-center">

    <div class="row align-items-sm-center" style=" justify-content:center; height:70px;" >
                           
                <label for="TipodeFiltro" style="Width:50px">Filtro:</label>
                          <div style="width:220px">
                  <asp:DropDownList class="form-control" ID="TipodeFiltro" runat="server" for="TipodeFiltro" Width="200px" >
                    <asp:ListItem>ID</asp:ListItem>
                    <asp:ListItem>Usuario</asp:ListItem>
                      <asp:ListItem>Nombre</asp:ListItem>
                      <asp:ListItem>Cedula</asp:ListItem>
                      <asp:ListItem>Telefono</asp:ListItem>
                      <asp:ListItem>Celular</asp:ListItem>
                      <asp:ListItem>E-mail</asp:ListItem>
                      <asp:ListItem>Tipo de Acceso</asp:ListItem>
                      <asp:ListItem>Contraseña</asp:ListItem>
                    
                </asp:DropDownList>
                              
                              </div>
                      <asp:Label ID="LabelCriterio" runat="server" Text="Criterio:" style="width:60px"></asp:Label>
                    <div style="width:370px">
                        <asp:TextBox class="form-control" ID="TextCriterio" runat="server" style="width:350px"></asp:TextBox>
                
                        </div>
                          <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="ButtonBuscar_Click" />
                          
                
                        
    
                        
            </div>
                           
            </div> 

               <div class="container align-content-center">
    <div class="row align-items-sm-center" style=" justify-content:center;" >
      
              
      <asp:Label for="DesdeTextBox"  ID="Label1" runat="server" Text="Desde:"></asp:Label>
        <asp:TextBox class="form-control" ID="DesdeTextBox" runat="server" TextMode="Date" Width="200"></asp:TextBox>
       
        <asp:Label for="HastaTextBox" ID="Label2" runat="server" Text="Hasta:"></asp:Label>
        <asp:TextBox class="form-control" ID="HastaTextBox" runat="server" TextMode="Date"  Width="200"></asp:TextBox>

             </div>
                           
            </div> 

         <div class="container align-content-center">
    <div class="row align-items-sm-center" style=" justify-content:center;" >
      
                        <div class="container form-group "> 
                      <div class="row">
                          <div class="form-row justify-content-center">
            <asp:GridView ID="UsuarioGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="LightSkyBlue" />
                <Columns>
                    <asp:BoundField DataField="UsuarioId" HeaderText="UsuarioId"/>
                    
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha"/>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula"/>
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono"/>
                    <asp:BoundField DataField="Celular" HeaderText="Celular"/>
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario"/>
                    <asp:BoundField DataField="Email" HeaderText="Telefono"/>
                    <asp:BoundField DataField="TipodeAcceso" HeaderText="TipodeAcceso"/>
                    <asp:BoundField DataField="Contraseña" HeaderText="Contraseña"/>

                   
     
                    
                </Columns>
                <HeaderStyle BackColor="LightCyan" Font-Bold="True" />
            </asp:GridView>
        </div>
                           </div>
                           
            </div> 
    
                             
            </div>
                           
            </div> 

    
  


</asp:Content>
