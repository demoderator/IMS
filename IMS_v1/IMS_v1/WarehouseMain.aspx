<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WarehouseMain.aspx.cs" Inherits="IMS_v1.WarehouseMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont-ho-warehouse">
			
			<div class="icons-header">
				Warehouse Services
			</div>
			
	    <div class="icons-body">
                <asp:Button ID="btnManageOrders" CssClass="anch-blocks manage-orders" runat="server" BorderWidth="0px" OnClick="btnManageOrders_Click" />
                <asp:Button ID="btnManageInventory" CssClass="anch-blocks manage-inventorywarehouse" runat="server" BorderWidth="0px" OnClick="btnManageInventory_Click" />
                <%--<asp:Button ID="btnManageStores" CssClass="anch-blocks manage-stores" runat="server" BorderWidth="0px" OnClick="btnManageStores_Click"  />--%>
                <asp:Button ID="btnManageVendors" CssClass="anch-blocks manage-vendor" runat="server" BorderWidth="0px" OnClick="btnManageVendors_Click" />
               
        </div>
            
			
		</div>
       
	</div>
</asp:Content>
