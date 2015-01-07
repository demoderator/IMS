<%@ Page Title="Store Main" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StoreMain.aspx.cs" Inherits="IMS_v1.StoreMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
	
	
		<asp:Label ID="lblheading" runat="server" CssClass="screen-heading" Text="Store Services"></asp:Label>
		<br />
		<div class="icons-cont">
			
			<div class="icons-header">
				Store Services
			</div>
			
			<div class="icons-body">
				<asp:Button ID ="btnStoreInventory" runat="server" CssClass="anch-blocks store-inventory" BorderWidth="0px"  OnClick="btnStoreInventory_Click"/>
				<asp:Button ID ="btnPicking" runat="server" CssClass="anch-blocks store-receivings" BorderWidth="0px" OnClick="btnPicking_Click"/>
				<asp:Button ID ="btnVendors" runat="server" CssClass=" anch-blocks store-transfers" BorderWidth="0px" OnClick="btnVendors_Click"/>
			</div>
			
		</div>
		
		
        
       

        <div class="clear"></div>	
	</div>
</asp:Content>
