<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderPurchasing.aspx.cs" Inherits="IMS_DPS.OrderPurchasing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="services-cont">
	
	<div class="icons-cont">
			
			<div class="icons-header">
				Order Purchasing Options
			</div>
			
			<div class="icons-body">
                <asp:Button ID ="btnAutoPurchaseOrder" runat="server"  class="anch-blocks auto-purchase"  BorderWidth="0px" OnClick="btnAutoPurchaseOrder_Click"/>
				
				
                
                 <asp:Button ID ="btnManualPurchaseOrder" runat="server" class="anch-blocks manual-purchase-order" BorderWidth="0px" OnClick="btnManualPurchaseOrder_Click"/>
			
				 
                
                 <asp:Button ID ="btnBack" runat="server" class=" anch-blocks go-back"  BorderWidth="0px" OnClick="btnBack_Click"/>
				
			</div>
			
		</div>
		<br />
		
		
		
       
      

        <div class="clear"></div>	
	</div>
</asp:Content>
