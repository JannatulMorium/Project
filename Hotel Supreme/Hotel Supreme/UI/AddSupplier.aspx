




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSupplier.aspx.cs" Debug="true" Inherits="UI_AddSupplier" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
              <asp:Label ID="lblAddSupplier" runat="server" Text="Add Supplier" Width="182px" BackColor="Transparent" Font-Bold="True"></asp:Label><br />
        <br />
        <table>
            
            
          
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtName" runat="server" MaxLength="50" ></asp:TextBox></td>
                
                
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtPhone" runat="server" MaxLength="10" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPhone"
                        ErrorMessage="Numeric Values only" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ></asp:TextBox>
                    </td>
                   
            </tr>
			 	
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label8" runat="server" Text="CellNo"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtCell" runat="server" MaxLength="11" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCell"
                        ErrorMessage="Numeric values only" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator></td>
               
            </tr>
            <tr>
                <td valign="top">
                </td>
                <td valign="top" style="width: 498px">
                    <asp:Button ID="btnAdd" runat="server" Text="Save" OnClick="btnAdd_Click" /></td>
                
            </tr>
        </table>

            
</asp:Content>           
	
