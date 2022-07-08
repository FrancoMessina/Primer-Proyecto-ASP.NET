<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Unidad4.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <asp:GridView ID="dgvAutos" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                </Columns>
            </asp:GridView>
            <a href="AutoForm.aspx">Agregar</a>
        </div>
    </div>



</asp:Content>
