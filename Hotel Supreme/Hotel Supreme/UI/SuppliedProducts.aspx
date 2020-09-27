




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliedProducts.aspx.cs" Debug="true" Inherits="UI_SuppliedProducts" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
             <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Supplied Products"></asp:Label><br />
        <br />
    &nbsp; &nbsp;
    <br />
        <br />
      
        <asp:GridView ID="grdProducts" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="ProductID" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdProducts_SelectedIndexChanged">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="User ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Quantity" HeaderText="Phone" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Role" />
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
	
