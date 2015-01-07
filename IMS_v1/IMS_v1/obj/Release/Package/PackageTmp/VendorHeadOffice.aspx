<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendorHeadOffice.aspx.cs" Inherits="IMS_v1.VendorHeadOffice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont">
			
			<div class="icons-header">
				Manage Vendor
			</div>
			
			<div class="icons-body">
                <asp:Button ID ="btnadd" runat="server" CssClass="anch-blocks add-edit-vendors"  BorderWidth="0px" OnClick="btnadd_Click"/>
				<asp:Button ID ="btnVendor" runat="server" CssClass="anch-blocks vendor-products" BorderWidth="0px" OnClick="btnVendor_Click"/>
				<asp:Button ID ="btnback" runat="server"  CssClass=" anch-blocks go-back" BorderWidth="0px" OnClick="btnback_Click"/>
				
			</div>
			
		</div>
	

	</div>
</asp:Content>
