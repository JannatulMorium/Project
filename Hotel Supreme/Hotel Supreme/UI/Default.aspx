<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Debug="true" Inherits="UI_Default" MasterPageFile="~/UI/HMS.master" Title="HMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
             <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Login"></asp:Label><br />
    <br />
    <asp:Login ID="loginControl" runat="server" OnAuthenticate="loginControl_Authenticate">
    </asp:Login>
            
</asp:Content>    
