<%@ Page Title="Manage Departments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageDepartment.aspx.cs" Inherits="IMS_v1.ManageDepartment" %>
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
	  <%--  <div class="left">
		    <div class="left-form-body">
                <label class="login-lab">Department Name:</label><br />
				<asp:Button ID="ViewDepartment"  CssClass="anch-blocks manage-department" runat="server" BorderWidth="0px"  OnClick="ViewDepartment_Click" />
			</div>
	    </div>--%>
        <div class="right full">
            <asp:GridView ID="DepDisplayGrid" runat="server" cellspacing="0" cellpadding="0" border="0" width="100%" CssClass="grid" AllowPaging="True" PageSize="10" 
                AutoGenerateColumns="false" OnPageIndexChanging="DepDisplayGrid_PageIndexChanging"   onrowcancelingedit="DepDisplayGrid_RowCancelingEdit" ShowFooter="true"
            onrowcommand="DepDisplayGrid_RowCommand"  onrowdeleting="DepDisplayGrid_RowDeleting" onrowediting="DepDisplayGrid_RowEditing">
                <Columns>
                    <asp:TemplateField HeaderText="Department ID">
                        <ItemTemplate>
                            <asp:Label ID="lblDep_ID" runat="server"  Text='<%# Eval("DepId") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:Label ID="lblAdd" runat="server"></asp:Label>
                        </FooterTemplate>
                    </asp:TemplateField>
                   
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblDep_Name" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <EditItemTemplate>

                            <asp:TextBox ID="txtname" runat="server"  Text='<%#Eval("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="txtAddname" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Code">
                        <ItemTemplate>
                            <asp:Label ID="lblDep_Code" runat="server" Text='<%# Eval("Code") %>'></asp:Label>
                        </ItemTemplate>
                         <EditItemTemplate>
                            <asp:TextBox ID="txtCode" runat="server" Text='<%#Eval("Code") %>'></asp:TextBox>
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="txtAddCode" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />
                            <br />
                            <span onclick="return confirm('Are you sure you want to delete this record?')">
                                <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete"/>
                            </span>
                        </ItemTemplate>

                        <EditItemTemplate>

                            <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="UpdateDep" />
                            <br />
                            <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:Button ID="btnAddRecord" runat="server" Text="Add" CommandName="Add"></asp:Button>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
         </div>
       
	</div>

  <%--  <script type="text/javascript">
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
