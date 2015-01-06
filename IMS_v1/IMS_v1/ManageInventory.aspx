<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageInventory.aspx.cs" Inherits="IMS_v1.ManageInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="wrapper">
	
		<div class="icons-cont-ho">
			
			<div class="icons-header">
				ManageInventory
			</div>
			
	    <div class="icons-body">
                <asp:Button ID="btnManageProduct" CssClass="anch-blocks manage-product" runat="server" BorderWidth="0px" OnClick="btnManageOrders_Click" />
                <asp:Button ID="btnManageSubCategory" CssClass="anch-blocks manage-subcategory" runat="server" BorderWidth="0px" />
                <asp:Button ID="btnManageCategory" CssClass="anch-blocks manage-category" runat="server" BorderWidth="0px"  />
                <asp:Button ID="btnManageDepartment" CssClass="anch-blocks manage-department" runat="server" BorderWidth="0px" />
                <asp:Button ID="btnGoBack" CssClass="anch-blocks go-back" runat="server" BorderWidth="0px" />
               
        </div>
            
			
		</div>
       
	</div>
</asp:Content>
