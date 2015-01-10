<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecieveOrder.aspx.cs" Inherits="IMS_v1.RecieveOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <%-- <div class="wrapper">
         <div class="left">
			
					<div class="left-form-body">
						<label class="login-lab">Order Number</label><br />
                         <asp:Panel ID="panel" runat="server" DefaultButton="btnSubmit">
						<asp:TextBox ID="txtorder" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUPC" runat="server" ControlToValidate="txtorder"
                        Display="Dynamic" ErrorMessage="Enter Order Number" SetFocusOnError="True" ValidationGroup="Insertion">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="reUPC" runat="server" Display="Dynamic" ErrorMessage="Enter Numeric Value for Order Number :"
                        SetFocusOnError="True" ValidationExpression="[0-9]+$"
                        ValidationGroup="Insertion" ControlToValidate="txtorder"></asp:RegularExpressionValidator>


                        <asp:Button ID="btnSubmit" CssClass="blue" Text="Submit" ValidationGroup="Insertion" runat="server" OnClick="btnSubmit_Click" />
                             <br /> 
                        </asp:Panel>
                        </div>
             </div>
          <div class="right">
               <asp:Label ID="lblheading" runat="server" CssClass="login-lab" Text="Order Receiving" Font-Bold="true" Font-Size="Large"></asp:Label>
               <br />
               <br />
               <asp:Label ID="lblMessage" runat="server" CssClass="login-lab" Text="" Font-Bold="true" Font-Size="Large" Visible="false"></asp:Label>
               <asp:GridView ID="gVAutoPurchasing" runat="server" CssClass="grid" PageSize="15" AutoGenerateColumns="false"  AllowPaging="True" OnPageIndexChanging="gVAutoPurchasing_PageIndexChanging">
               </asp:GridView>

               <br />
               <br />
               <asp:Button ID="btnaccept" runat="server"  class="btn btn-primary" Text="Recieve Order" OnClick="btnaccept_Click"/>
               <asp:Button ID="btnCancel" runat="server" Text="Cancel Order" OnClick="btnCancel_Click" CssClass="btn btn-default" BorderWidth="0px" />

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
	</script>--%>
</asp:Content>
