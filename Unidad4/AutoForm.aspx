<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="Unidad4.AutoForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Modelo</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="ddlColores" class="form-label">Colores</label>
                <asp:DropDownList ID="ddlColores" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-select" TextMode="Date"></asp:TextBox>
            </div>
            <asp:CheckBox ID="ckbUsado" runat="server" Text="Usado" CssClass="custom-form-style" />
            <div class="mb-3">
                <asp:RadioButton ID="rdbImportado" Text="Importado" runat="server" groupName="Importado" AutoPostBack="true" OnCheckedChanged="rdbImportado_CheckedChanged" />
                <asp:RadioButton ID="rdbNacional" Text="Nacional" runat="server" groupName="Importado" AutoPostBack="true" Checked="true" OnCheckedChanged="rdbNacional_CheckedChanged"/>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnAceptar"  CssClass="btn btn-dark" Text="Aceptar" runat="server" OnClick="btnAceptar_Click"/>
                <a href="Default.aspx" >Cancelar</a>
            </div>
        </div>
    </div>


</asp:Content>
