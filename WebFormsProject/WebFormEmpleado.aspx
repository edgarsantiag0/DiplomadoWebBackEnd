<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmpleado.aspx.cs" Inherits="WebFormsProject.WebFormEmpleado" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Empleado Web Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 134px;
        }
        .auto-style4 {
            width: 134px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

    <h1>Nuevo Estudiante
        <asp:Label ID="LabelHora" runat="server"></asp:Label>
        </h1>
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Nombre</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNombre" ErrorMessage="Nombre es requerido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxApellido" ErrorMessage="Apellido es requerido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Fecha de nacimiento</td>
                <td>
                    <asp:TextBox ID="TextBoxFecha" runat="server" Height="22px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxFecha" ErrorMessage="Fecha es requerido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Curso</td>
                <td>
                    <asp:DropDownList ID="DropDownListCursos" runat="server">
                        <asp:ListItem>Seleccionar</asp:ListItem>
                        <asp:ListItem>Programacion Web</asp:ListItem>
                        <asp:ListItem>Base de datos</asp:ListItem>
                        <asp:ListItem>Programacion Movil</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    <br />
                    <br />
                    <asp:GridView ID="GridViewListaEstudiantes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="403px">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" Width="81px" />
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
        <asp:Label ID="LabelMensajeSalida" runat="server"></asp:Label>
    </form>
</body>
</html>
