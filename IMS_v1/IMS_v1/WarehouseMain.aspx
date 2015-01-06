<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WarehouseMain.aspx.cs" Inherits="IMS_v1.WarehouseMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont-ho">
			
			<div class="icons-header">
				Warehouse Services
			</div>
			
	    <div class="icons-body">
                <asp:Button ID="btnManageOrders" CssClass="manage-orders" runat="server" Text="Manage Orders"/>
                &nbsp;<asp:Button ID="btnManageInventory" CssClass="manage-inventorywarehouse" runat="server" Text="Manage Inventory"/>
                &nbsp;<asp:Button ID="btnManageStores" CssClass="manage-stores" runat="server" Text="Manage Stores" />
                &nbsp;<asp:Button ID="btnManageVendors" CssClass="manage-vendor" runat="server" Text="Manage Vendors"/>
               
        </div>
            
			
		</div>
       
	</div>
</asp:Content>
