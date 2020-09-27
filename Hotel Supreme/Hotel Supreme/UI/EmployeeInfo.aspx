




<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Debug="true" Inherits="UI_EmployeeInfo" MasterPageFile="~/UI/HMSSecure.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
              <asp:Label ID="lblEmployeeDtls" runat="server" Text="Employee Details" Width="182px" Font-Bold="true"></asp:Label><br />
        <br />
        <table>
            <tr>
                <td style="height: 21px">
                    <asp:Label ID="Label2" runat="server" Text="Employee ID"></asp:Label></td>
                <td style="width: 498px; height: 21px">
                    <asp:Label ID="lblEmployeeID" runat="server" BorderColor="Black"></asp:Label></td>
                
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
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone"
                        ErrorMessage="Only Numerical Values are accepted" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator></td>
                
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ></asp:TextBox>
                    </td>
                   
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label></td>
                <td style="width: 498px">
                    <asp:DropDownList ID="lstRole" runat="server" 
                    DataSourceID="SqlDataSource1" 
                    DataTextField="Role" 
                    DataValueField="JobId" Enabled="false">
                </asp:DropDownList>

                <asp:SqlDataSource 
                     ConnectionString="<%$ ConnectionStrings:HMSConnectionString %>"
                        ID="SqlDataSource1" 
                        runat="server" 
                        SelectCommand="SELECT [JobId], [Role] FROM [JobTitle]">
                 </asp:SqlDataSource></td>
               
            </tr>
            
			 	<tr>
                <td style="height: 26px">
                    <asp:Label ID="Label7" runat="server" Text="Salary"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtSalary" runat="server" MaxLength="8" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSalary"
                        ErrorMessage="Please enter employee Salary"></asp:RequiredFieldValidator></td>
               
            </tr>
			 	
            
            
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label1" runat="server" Text="ManagerId"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                     <asp:DropDownList ID="lstManager" runat="server" 
                    DataSourceID="SqlDataSource2" 
                    DataTextField="EmployeeId" 
                    DataValueField="EmployeeId"
                    AppendDataBoundItems="True">
                    <asp:ListItem Selected="True" Value="0" Text="None">
                        None
                    </asp:ListItem>

                </asp:DropDownList>

                <asp:SqlDataSource 
                     ConnectionString="<%$ ConnectionStrings:HMSConnectionString %>"
                        ID="SqlDataSource2" 
                        runat="server" 
                        SelectCommand="SELECT [EmployeeId], [Name] FROM [Employee] WHERE [JobId] =1">
                 </asp:SqlDataSource>
                 </td>
               
            </tr>
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label6" runat="server" Text="Cell"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtCell" runat="server" MaxLength="11" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCell"
                        ErrorMessage="Only Numerical Values are accepted" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator></td>
               
            </tr>
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtPassword" runat="server" MaxLength="6" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Please enter password"></asp:RequiredFieldValidator></td>
               
            </tr>
            
            <tr>
                <td valign="top">
                </td>
                <td valign="top" style="width: 498px">
                    <asp:Button ID="cmdUpdate" runat="server" Text="Update" OnClick="cmdUpdate_Click" />
                    <asp:Button ID="cmdSuper" runat="server" Text="View Supervised Employees" Visible="false" Enabled="true" OnClick="cmdSuper_Click" /></td>
                
            </tr>
        </table>

            
</asp:Content>           
	
