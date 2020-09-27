




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierInfo.aspx.cs" Debug="true" Inherits="UI_SupplierInfo" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
              <asp:Label ID="lblEmployeeDtls" runat="server" Text="Supplier Details" Width="182px" BackColor="Transparent" Font-Bold="True"></asp:Label><br />
        <br />
        <table>
            <tr>
                <td style="height: 21px">
                    <asp:Label ID="Label2" runat="server" Text="Supplier ID"></asp:Label></td>
                <td style="width: 498px; height: 21px">
                    <asp:Label ID="lblSupplierID" runat="server" BorderColor="Black"></asp:Label></td>
                
            </tr>
            
            
            
			 	
			 	
			
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtName" runat="server" MaxLength="50" ></asp:TextBox></td>
                
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtPhone" runat="server" MaxLength="10" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Numeric values only"
                        ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]" ControlToValidate="txtPhone"></asp:RegularExpressionValidator></td>
                
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ></asp:TextBox>
                    </td>
                   
            </tr>
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label6" runat="server" Text="Cell"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtCell" runat="server" MaxLength="11" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Numeric Values only"
                        ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]" ControlToValidate="txtCell"></asp:RegularExpressionValidator></td>
               
            </tr>
            
            <tr>
                <td valign="top">
                </td>
                <td valign="top" style="width: 498px">
                    <asp:Button ID="cmdUpdate" runat="server" Text="Update" OnClick="cmdUpdate_Click" />
                    <asp:Button ID="cmdProd" runat="server" Text="View Products Supplied" OnClick="cmdProd_Click" /></td>
                
            </tr>
        </table>

            
</asp:Content>           
	
