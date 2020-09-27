




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageEmployees.aspx.cs" Debug="true" Inherits="UI_ManageEmployees" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
             <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Employee Management"></asp:Label><br />
        <br />
    <asp:Button ID="cmdMan" runat="server" Text="View Managers" OnClick="cmdMan_Click" />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <asp:Button ID="cmdRep" runat="server" Text="View Receptionists" OnClick="cmdRep_Click" />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <asp:Button ID="cmdMain" runat="server" Text="View Maintenance Workers" OnClick="cmdMain_Click" /><br />
        <br />
      
        <asp:GridView ID="grdEmployees" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="EmployeeID" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdUsers_SelectedIndexChanged">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="User ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Role" HeaderText="Role" />
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
	
