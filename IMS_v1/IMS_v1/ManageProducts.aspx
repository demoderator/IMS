<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="IMS_v1.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont">
			
			<div class="icons-header">
				Warehouse Services
			</div>
			
	    <div class="icons-body">
                <asp:Button ID="btnAddEditInventory" CssClass="anch-blocks add-edit-inventory" runat="server" BorderWidth="0px" OnClick="btnAddEditInventory_Click" />
                <asp:Button ID="btnCheckInventory" CssClass="anch-blocks all-stores" runat="server" BorderWidth="0px" />
                <asp:Button ID="btnGoBack" CssClass="anch-blocks go-back" runat="server" BorderWidth="0px"  />
               
        </div>
            
			
		</div>
       
	</div>
</asp:Content>
