




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInfo.aspx.cs" Debug="true" Inherits="UI_ProductInfo" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
              <asp:Label ID="lblProductDtls" runat="server" Text="Product Details" Width="182px" BackColor="Transparent" Font-Bold="True"></asp:Label><br />
        <br />
        <table>
            <tr>
                <td style="height: 21px">
                    <asp:Label ID="Label2" runat="server" Text="Product ID"></asp:Label></td>
                <td style="width: 498px; height: 21px">
                    <asp:Label ID="lblProductID" runat="server" BorderColor="Black"></asp:Label></td>
                
            </tr>
            
            
            
			 	
			 	
			
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtName" runat="server" ></asp:TextBox></td>
                
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox></td>
                
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label5" runat="server" Text="Unit Price"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtUnitPrice" runat="server" ></asp:TextBox>
                    </td>
                   
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSupplier" runat="server" Text="Supplier"></asp:Label></td>
                <td style="width: 498px">
                    <asp:DropDownList ID="lstSupplier" runat="server" 
                    DataSourceID="SqlDataSource1" 
                    DataTextField="Name" 
                    DataValueField="SupplierId">
                </asp:DropDownList>
                    <asp:SqlDataSource 
                     ConnectionString="<%$ ConnectionStrings:HMSConnectionString %>"
                        ID="SqlDataSource1" 
                        runat="server" 
                        SelectCommand="SELECT [supplierId], [Name] FROM [Supplier]">
                 </asp:SqlDataSource></td>
               
            </tr>
            
            <tr>
                <td valign="top">
                    <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label></td>
                <td valign="top">
                    <asp:TextBox ID="txtDescription" runat="server" Height="276px" TextMode="MultiLine"
                        Width="481px"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            
            <tr>
                <td valign="top">
                </td>
                <td valign="top" style="width: 498px">
                    <asp:Button ID="cmdUpdate" runat="server" Text="Update" OnClick="cmdUpdate_Click" />
                    <asp:Button ID="cmdDelete" runat="server" Text="Delete" OnClick="cmdDelete_Click" /></td>
                
            </tr>
        </table>

            
</asp:Content>           
	
