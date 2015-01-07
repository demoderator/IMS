<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendorList.aspx.cs" Inherits="IMS_v1.VendorList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
      <script type = "text/javascript">
          function Check_Click(objRef) {
              //Get the Row based on checkbox
              var row = objRef.parentNode.parentNode;
              if (objRef.checked) {
                  //If checked change color to Aqua
                  row.style.backgroundColor = "#4F7AD8";
              }
              else {
                  //If not checked change back to original color
                  if (row.rowIndex % 2 == 0) {
                      //Alternating Row Color
                      row.style.backgroundColor = "#191919";
                  }
                  else {
                      row.style.backgroundColor = "#191919";
                  }
              }

              //Get the reference of GridView
              var GridView = row.parentNode;

              //Get all input elements in Gridview
              var inputList = GridView.getElementsByTagName("input");

              for (var i = 0; i < inputList.length; i++) {
                  //The First element is the Header Checkbox
                  var headerCheckBox = inputList[0];

                  //Based on all or none checkboxes
                  //are checked check/uncheck Header Checkbox
                  var checked = true;
                  if (inputList[i].type == "checkbox" && inputList[i] != headerCheckBox) {
                      if (!inputList[i].checked) {
                          checked = false;
                          break;
                      }
                  }
              }
              headerCheckBox.checked = checked;

          }
    </script>

    <script type = "text/javascript">
        function checkAll(objRef) {
            var GridView = objRef.parentNode.parentNode.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                //Get the Cell To find out ColumnIndex
                var row = inputList[i].parentNode.parentNode;
                if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                    if (objRef.checked) {
                        //If the header checkbox is checked
                        //check all checkboxes
                        //and highlight all rows
                        row.style.backgroundColor = "#4F7AD8";
                        inputList[i].checked = true;
                    }
                    else {
                        //If the header checkbox is checked
                        //uncheck all checkboxes
                        //and change rowcolor back to original
                        if (row.rowIndex % 2 == 0) {
                            //Alternating Row Color
                            row.style.backgroundColor = "#191919";
                        }
                        else {
                            row.style.backgroundColor = "#191919";
                        }
                        inputList[i].checked = false;
                    }
                }
            }
        }
   </script> 

    <script type = "text/javascript">
        function MouseEvents(objRef, evt) {
            var checkbox = objRef.getElementsByTagName("input")[0];
            if (evt.type == "mouseover") {
                objRef.style.backgroundColor = "orange"; //66CC00
            }
            else {
                if (checkbox.checked) {
                    objRef.style.backgroundColor = "#4F7AD8";
                }
                else if (evt.type == "mouseout") {
                    if (objRef.rowIndex % 2 == 0) {
                        //Alternating Row Color
                        objRef.style.backgroundColor = "#191919";
                    }
                    else {
                        objRef.style.backgroundColor = "#191919";
                    }
                }
            }
        }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="wrapper">
        <div class="left">
			
					<div class="left-form-body">
                        <label class="login-lab">Vendor Name:</label><br />
						<asp:DropDownList ID ="ddlStoreName" runat="server" class="cp-in"  AutoPostBack="True" OnSelectedIndexChanged="ddlStoreName_SelectedIndexChanged"  Font-Size="14pt" Width="100%"/>
						<asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="blue"  OnClick="btnSubmit_Click" />  
                        <asp:Button ID="btnGoBack" runat="server" Text="Go Back" CssClass="blue" OnClick="btnGoBack_Click" BorderWidth="0px"/>
					</div>
					
		
		</div>
       
        <div class="right">
			

            <asp:GridView ID="gVStoreInfo" runat="server" cellspacing="0" cellpadding="0" border="0" width="100%" CssClass="grid" AutoGenerateColumns="false" OnSelectedIndexChanged="gVStoreInfo_SelectedIndexChanged" OnRowDataBound="gVStoreInfo_RowDataBound" AllowPaging="True" PageSize="10" OnPageIndexChanging="gVStoreInfo_PageIndexChanging">
                         <Columns>
                    <asp:TemplateField HeaderText="Vendor Name">
                    <ItemTemplate>
                        <asp:Label ID="lblVendor" runat="server" Text='<%# Eval("VendorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblProduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <asp:Label ID="lblDept" runat="server" Text='<%# Eval("DepartmentName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Category Name">
                    <ItemTemplate>
                        <asp:Label ID="lblCat" runat="server" Text='<%# Eval("CategoryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="SubCategory Name">
                    <ItemTemplate>
                        <asp:Label ID="lblSubCat" runat="server" Text='<%# Eval("SubCategoryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

             

                <asp:TemplateField HeaderText="Unit Quantity">
                    <ItemTemplate>
                        <asp:Label ID="lblQuantity" runat="server" Text='<%# Eval("UnitQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cost">
                    <ItemTemplate>
                        <asp:Literal ID="lblUPC" runat="server" Text='<%# Eval("CostPerWeek") %>'></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>

                

            </Columns>
            </asp:GridView>
			
            
			
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
 <!--  <div class="services-cont">
        <asp:Label ID="lblHeading" runat="server" Text="Vendor Detail List" CssClass="screen-heading"></asp:Label>
        <br />
        <br />

        <table border="0" cellspacing="0" cellpadding="3" class="cpw" style="float:left;" width="350">
        <tr>
				<td>Vendor Name:</td>
		</tr>
		<tr>
				<td><asp:DropDownList ID ="ddlStoreName1" runat="server" class="cp-in"  AutoPostBack="True" OnSelectedIndexChanged="ddlStoreName_SelectedIndexChanged" /></td>
		</tr>
       <tr>
				<td><asp:Button ID="btnSubmit1" runat="server"  class="submit-btn"  OnClick="btnSubmit_Click" />   
				</td>
		</tr>
        </table>


        <div style="float:left; width:750px; margin-left:50px; margin-top:75px;">
         <asp:GridView ID="gVStoreInfo1" runat="server" CssClass="grid" Width="751px" AutoGenerateColumns="false" OnSelectedIndexChanged="gVStoreInfo_SelectedIndexChanged" AllowPaging="True" PageSize="10" OnPageIndexChanging="gVStoreInfo_PageIndexChanging" PagerStyle-CssClass="paggination">
                         <Columns>

                              <asp:TemplateField HeaderText="Vendor Name">
                    <ItemTemplate>
                        <asp:Label ID="lblVendor" runat="server" Text='<%# Eval("VendorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblProduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <asp:Label ID="lblDept" runat="server" Text='<%# Eval("DepartmentName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Category Name">
                    <ItemTemplate>
                        <asp:Label ID="lblCat" runat="server" Text='<%# Eval("CategoryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="SubCategory Name">
                    <ItemTemplate>
                        <asp:Label ID="lblSubCat" runat="server" Text='<%# Eval("SubCategoryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               

                <asp:TemplateField HeaderText="Unit Quantity">
                    <ItemTemplate>
                        <asp:Label ID="lblQuantity" runat="server" Text='<%# Eval("UnitQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cost">
                    <ItemTemplate>
                        <asp:Literal ID="lblUPC" runat="server" Text='<%# Eval("CostPerWeek") %>'></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>

                

            </Columns>
            </asp:GridView>
            <br />
        <asp:Button ID="btnBack" runat="server" Text="Go Back" CssClass="portlet-p" BorderWidth="0px" OnClick="btnBack_Click"/>   
        </div>
   </div>
    -->
</asp:Content>
