<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HeadOfficeMain.aspx.cs" Inherits="IMS_DPS.HeadOfficeMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont">
			
			<div class="icons-header">
				Head Office Services
			</div>
			
			<div class="icons-body">
                <asp:Button ID ="btnReports" runat="server" CssClass="anch-blocks reports"  BorderWidth="0px" OnClick="btnReports_Click"/>
				<asp:Button ID ="btnStoreInventory" runat="server" CssClass="anch-blocks all-stores" BorderWidth="0px" OnClick="btnStoreInventory_Click"/>
				<asp:Button ID ="btnVendors" runat="server"  CssClass=" anch-blocks vendor-list" BorderWidth="0px" OnClick="btnVendors_Click"/>
				<asp:Button ID ="btnManageRoles" runat="server"   Text="Manage Roles" CssClass=" anch-blocks vendor-list" BorderWidth="0px" OnClick="btnManageRoles_Click"/>
                <asp:Button ID ="btnManageStore" runat="server"  CssClass=" anch-blocks vendor-list" Text="Manage Store" BorderWidth="0px" OnClick="btnManageStore_Click"/>
			</div>
			
		</div>
	

	</div>
</asp:Content>
