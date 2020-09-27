




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagement.aspx.cs" Debug="true" Inherits="UI_SupplierManagement" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
             <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Supplier Management"></asp:Label><br />
    <table style="width: 191px">
        <tr>
            <td style="width: 64px">
            </td>
            <td style="width: 30px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 64px">
                <asp:Button ID="cmdAdd" runat="server" Text="Create New Supplier" OnClick="cmdAdd_Click" /></td>
            <td style="width: 30px">
            </td>
            <td>
                <asp:Button ID="cmdView" runat="server" Text="View Existing Suppliers" OnClick="cmdView_Click" /></td>
        </tr>
        <tr>
            <td style="width: 64px">
            </td>
            <td style="width: 30px">
            </td>
            <td>
            </td>
        </tr>
    </table>
        <br />
        <br />
        <br />
    &nbsp;<br />
        &nbsp;
            
</asp:Content>           
	
