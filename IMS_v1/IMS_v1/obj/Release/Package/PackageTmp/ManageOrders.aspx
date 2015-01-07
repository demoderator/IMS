<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageOrders.aspx.cs" Inherits="IMS_v1.ManageOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
	
		<div class="icons-cont-ho-orders">
			
			<div class="icons-header">
				Manage Orders
			</div>
			
	    <div class="icons-body">
                <asp:Button ID="btnPlaceOrders" CssClass="anch-blocks place-order" runat="server" BorderWidth="0px" OnClick="btnPlaceOrders_Click" />
                <asp:Button ID="btnRecieveOrders" CssClass="anch-blocks recieve-orders" runat="server" BorderWidth="0px" OnClick="btnRecieveOrders_Click" />
                <asp:Button ID="btnSendOrderStores" CssClass="anch-blocks sendorder-store" runat="server" BorderWidth="0px"  />
                <asp:Button ID="btnPendingOrders" CssClass="anch-blocks view-pendingOrders" runat="server" BorderWidth="0px" OnClick="btnPendingOrders_Click" />
                <asp:Button ID="btnHisotryOrders" CssClass="anch-blocks view-historyOrders" runat="server" BorderWidth="0px" OnClick="btnHisotryOrders_Click" />
                <asp:Button ID="btnGoBack" CssClass="anch-blocks go-back" runat="server" BorderWidth="0px" OnClick="btnGoBack_Click" />
               
        </div>
            
			
		</div>
       
	</div>
</asp:Content>
