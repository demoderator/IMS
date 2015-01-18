<%@ Page Title="View Inventory" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckInventory_Products.aspx.cs" Inherits="IMS_v1.CheckInventory_Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
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

    <script type="text/javascript">
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

    <script type="text/javascript">
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
        <div class="right full">
                

            <table>
                <tr>
                    <th colspan="2">Search</th>
                </tr>

                <tr>
                    <td>Search by Product</td>
                    <td>

                        <asp:DropDownList ID="drpSerchUser" runat="server" >
                            
                              <asp:ListItem Value=''> ------------------- Select ------------------ </asp:ListItem>
                        </asp:DropDownList></td>
                </tr>

                <tr><td colspan="2">

                    <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="btnSubmit_Click"  />
                    </td></tr>
               
            </table>
            <asp:GridView ID="ProdDisplayGrid" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" PageSize="10"
                AutoGenerateColumns="false" OnPageIndexChanging="ProdDisplayGrid_PageIndexChanging" OnSorting="ProdDisplayGrid_Sorting" AllowSorting="true">
                <Columns>
                    <asp:TemplateField HeaderText="Product Name" SortExpression="productName">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ID" runat="server" Text='<%# Eval("productName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Sub Category"  SortExpression="SubCategory">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Name" runat="server" Text='<%# Eval("SubCategory") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Assigned To"  SortExpression="AssignedTo">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Quan" runat="server" Text='<%# Eval("AssignedTo") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="quantity">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_CP" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                 

                    <asp:TemplateField HeaderText="Sale Price">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ExD" runat="server" Text='<%# Eval("salePrice") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cost Price">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_man" runat="server" Text='<%# Eval("costPrice") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>

                              <asp:Label ID="Label1" runat="server" Text=''> 

                                 <a href="GetExpiryDetails.aspx?uId=<%# Eval("UserRoleID")%>&Pid=<%# Eval("ProductID")%>">
                                     Details</asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <%--onrowcancelingedit="DepDisplayGrid_RowCancelingEdit" ShowFooter="true"
            onrowcommand="DepDisplayGrid_RowCommand" onrowdeleting="DepDisplayGrid_RowDeleting" onrowediting="DepDisplayGrid_RowEditing" onrowupdating="DepDisplayGrid_RowUpdating">--%>
        </div>
    </div>


    
</asp:Content>
