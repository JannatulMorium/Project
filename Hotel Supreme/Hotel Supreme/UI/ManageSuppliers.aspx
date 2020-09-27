




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageSuppliers.aspx.cs" Debug="true" Inherits="UI_ManageSuppliers" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
             <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Supplier Management"></asp:Label><br />
        <br />
        <br />
        <br />
      
        <asp:GridView ID="grdSuppliers" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="SupplierID" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdSuppliers_SelectedIndexChanged">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="SupplierID" HeaderText="Supplier ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Cell" HeaderText="Cell" />
                <asp:CommandField SelectText="Edit/Delete" ShowSelectButton="True" />
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <br />
        &nbsp;
            
</asp:Content>           
	
