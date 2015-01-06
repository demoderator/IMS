<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StoreTransfer.aspx.cs" Inherits="IMS_v1.StoreTransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
        <div class="left">
            <div class="left-form-body">
						<label class="login-lab">FROM :</label><br />
						<asp:DropDownList ID ="ddlStoreFrom" runat="server" Font-Size="14pt" Width="100%"  />
                        <br />
                        <label class="login-lab">TO :</label><br />
						<asp:DropDownList ID ="ddlStoreTo" runat="server" Font-Size="14pt" Width="100%"  />
                        <br />
                        <asp:Button ID="btnSearch" CssClass="blue" Text="Submit" runat="server" OnClick="btnSearch_Click2" />
                        <asp:Button ID="Button1" runat="server" Text="Go Back" CssClass="blue" OnClick="Button1_Click2" BorderWidth="0px"/>
                
                        <br />
                    
                        <asp:RadioButton ID="rdOption1" runat="server" Text="By Vendor" Visible="False" OnCheckedChanged="rdOption1_CheckedChanged" />
                        <asp:RadioButton ID="rdOption2" runat="server" Text="By Product" Visible="False" />

                        <br />
                        <br />

                        <asp:Label ID="lblVendor" runat="server" CssClass="login-lab" Text="Vendor Name: " Visible="false"></asp:Label>
                
                        <asp:DropDownList ID ="ddlVendorName" runat="server" class="cp-in" OnSelectedIndexChanged="ddlVendorName_SelectedIndexChanged" AutoPostBack="True" Width="100%" Font-Size="14pt" Visible="false"/>
		
                        <asp:Label ID="lblDepartment" runat="server" CssClass="login-lab" Text="Department Name: " Visible="false"></asp:Label>
		
                        <asp:DropDownList ID ="ddlDpeartmentName" runat="server" class="cp-in" OnSelectedIndexChanged="ddlDpeartmentName_SelectedIndexChanged" AutoPostBack="True" Width="100%" Font-Size="14pt" Visible="false"/>
		
                        <asp:Label ID="lblCategory" runat="server" CssClass="login-lab" Text="Category Name: " Visible="false"></asp:Label>
		
                        <asp:DropDownList ID ="ddlCategoryName" runat="server" class="cp-in" OnSelectedIndexChanged="ddlCategoryName_SelectedIndexChanged" AutoPostBack="True" Width="100%" Font-Size="14pt" Visible="false"/>
		
                        <asp:Label ID="lblSubcategory" runat="server" CssClass="login-lab" Text="SubCategory Name: " Visible="false"></asp:Label>
		
                        <asp:DropDownList ID ="ddlSubCategoryName" runat="server" class="cp-in" OnSelectedIndexChanged="ddlSubCategoryName_SelectedIndexChanged" AutoPostBack="True" Width="100%" Font-Size="14pt" Visible="false"/>
		
                        <asp:Label ID="lblProduct" runat="server" CssClass="login-lab" Text="Product Name: " Visible="false"></asp:Label>
		
                        <asp:DropDownList ID ="ddlProductName" runat="server" class="cp-in" AutoPostBack="True" Width="100%" Font-Size="14pt" Visible="false"/>
		
                        <asp:Label ID="lblQuantity" runat="server" CssClass="login-lab" Text="Quantity: " Visible="false"></asp:Label>
		
                        <asp:TextBox ID ="txtQuanity" runat="server" class="cp-in" Visible="false" />
		
                        <asp:Button ID="btnSbmitCode" runat="server"  CssClass="blue" Text="Make Transfer" OnClientClick="javascript:alert('Transfer Completed');"  OnClick="btnSbmitCode_Click" Visible="false"/>
		

        </div>

        <div class="right">
        
            </div>
    </div>
     <script type="text/javascript">
         $(document).ready(function (e) {

             var docheight = $(document).height();
             $('.left').height(docheight - 70);
             $('.right').height(docheight - 70);


             $('input:checkbox').click(function () {
                 if ($(this).is(':checked')) {
                     $(this).closest('tr').addClass('highlighted');
                 }
                 else {
                     // Stuff to do every *even* time the element is clicked;
                     $(this).closest('tr').removeClass('highlighted');
                 }
             });


             $(document).on('click change', 'input[name="check_all"]', function () {
                 var checkboxes = $('.tr-check');
                 if ($(this).is(':checked')) {
                     checkboxes.attr("checked", true);
                     checkboxes.closest('tr').addClass('highlighted');
                 } else {
                     checkboxes.attr("checked", false);
                     checkboxes.closest('tr').removeClass('highlighted');
                 }
             });

         });
	</script>
</asp:Content>
