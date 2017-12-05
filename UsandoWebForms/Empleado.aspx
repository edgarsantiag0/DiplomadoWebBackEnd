<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="UsandoWebForms.Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 23px;
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        

    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2">La hora es:
                    <asp:Label ID="LabelHora" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxPrimerNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server" ControlToValidate="TextBoxPrimerNombre" ErrorMessage="Debe introducir un nombre"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido</td>
                <td>
                    <asp:TextBox ID="TextBoxApellido" runat="server" OnTextChanged="ApellidoTextBox_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxApellido" ErrorMessage="Debe introducir un apellido"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Fecha de nacimiento</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxFechaNacimiento" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxFechaNacimiento" ErrorMessage="Debe introducir una fecha"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Curso ITLA</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Seleccionar</asp:ListItem>
                        <asp:ListItem>Programacion Web</asp:ListItem>
                        <asp:ListItem>Base de datos</asp:ListItem>
                        <asp:ListItem>Programacion Movil</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Debe introducir un curso"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonEnviar" runat="server" OnClick="ButtonEnviar_Click" Text="Enviar" Width="92px" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="LabelDatosSalida" runat="server"></asp:Label>
        <br />
        <br />
        

    
        </div>
    </form>
</body>
</html>
