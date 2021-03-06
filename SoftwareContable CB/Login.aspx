﻿<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SoftwareContable_CB.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">

        <div class="d-flex justify-content-center h-100" ">

            <div class="card">

                <div class="card-header " style="background-color:forestgreen">

                    <h3>Log In</h3>

                    <div class="d-flex justify-content-end social_icon">

                        <span><i class="fab fa-facebook-square"></i></span>

                        <span><i class="fab fa-google-plus-square"></i></span>

                        <span><i class="fab fa-twitter-square"></i></span>

                    </div>

                </div>

                <div class="card-body">

                    <form>

                        <div class="input-group form-group">

                            <div class="input-group-prepend">

                                <span  style="background-color:forestgreen" class="input-group-text"><i class="fas fa-user"></i></span>

                            </div>
                            <asp:TextBox class="form-control" ID="TextBoxenterUsuario"  placeholder="Usuario" runat="server"></asp:TextBox>

                            
                        </div>

                        <div class="input-group form-group">

                            <div class="input-group-prepend">

                                <span style="background-color:forestgreen" class="input-group-text"><i class="fas fa-key"></i></span>

                            </div>
                            <asp:TextBox   placeholder="Contraseña" class="form-control" type="password" ID="TextBoxcontrasena" runat="server"></asp:TextBox>
                            
                        </div>



                        <div class="form-group">
                            <asp:Button style="background-color:forestgreen" ID="ButtonLogin" runat="server" Text="Login" class="btn float-right login_btn" OnClick="ButtonLogin_Click"    />
                          
                        </div>

                    </form>

                </div>

                <div class="card-footer" style="background-color:forestgreen">

                    <div class="d-flex justify-content-center links">
                        ¿No tienes una cuenta?<a href="http://localhost:57890/Informacion/Informacion.aspx">¿Como Registrarte?</a>

                    </div>

                    <div class="d-flex justify-content-center">

                        <a href="http://localhost:57890/Informacion/Informacion.aspx">¿Olvidaste tu contraseña?</a>

                    </div>

                </div>

            </div>

        </div>

    </div>
</asp:Content>
