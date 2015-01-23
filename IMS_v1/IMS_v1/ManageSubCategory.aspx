<%@ Page Title="Manage Sub-Category" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageSubCategory.aspx.cs" Inherits="IMS_v1.ManageSubCategory" %>
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

     <style>
        a img {
            border: none;
        }

        ol li {
            list-style: decimal outside;
        }

        div#container {
            width: 780px;
            margin: 0 auto;
            padding: 1em 0;
        }

        div.side-by-side {
            width: 100%;
            margin-bottom: 1em;
        }

            div.side-by-side > div {
                float: left;
                width: 50%;
            }

                div.side-by-side > div > em {
                    margin-bottom: 10px;
                    display: block;
                }

        .clearfix:after {
            content: "\0020";
            display: block;
            height: 0;
            clear: both;
            overflow: hidden;
            visibility: hidden;
        }
    </style>
    <link rel="stylesheet" href="Style/chosen.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="wrapper">
         <%--<asp:DropDownList ID ="ddlSubCatName" runat="server" class="cp-in"  AutoPostBack="True" OnSelectedIndexChanged="ddlSubCatName_SelectedIndexChanged"  Font-Size="14pt" Width="50%"/>--%>
      
         <div class="right full">
                <table>
                <tr>
                    <th colspan="2">Search</th>
                </tr>

                <tr>
                    <td>Search by SubCategory</td>
                    <td>
                        <div id="container">


                            <div class="side-by-side clearfix">

                                <div>

                                    <asp:DropDownList data-placeholder="select a Sub-Category..." ID="ddlSubCatName" runat="server" class="chzn-select" >
                                        <asp:ListItem Text="" Value=""></asp:ListItem>
                                        <asp:ListItem Value=''> ------------------- Select ------------------ </asp:ListItem>

                                    </asp:DropDownList>

                                </div>
                            </div>

                        </div>
                        <script src="Scripts/jquery.min.js" type="text/javascript"></script>
                        <script src="Scripts/chosen.jquery.js" type="text/javascript"></script>
                        <script type="text/javascript"> $(".chzn-select").chosen(); $(".chzn-select-deselect").chosen({ allow_single_deselect: true }); </script>


                    </td>
                   
                </tr>

                <tr><td colspan="2">

                    <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="btnSubmit_Click"  />
                    </td></tr>
               
            </table>
             <asp:GridView ID="SubCategoryDisplayGrid" runat="server" cellspacing="0" cellpadding="0" border="0" width="100%" CssClass="grid" AllowPaging="True" PageSize="10" 
                AutoGenerateColumns="false" OnPageIndexChanging="SubCategoryDisplayGrid_PageIndexChanging"   onrowcancelingedit="SubCategoryDisplayGrid_RowCancelingEdit" ShowFooter="true"
            onrowcommand="SubCategoryDisplayGrid_RowCommand" OnRowDataBound="SubCategoryDisplayGrid_RowDataBound" onrowdeleting="SubCategoryDisplayGrid_RowDeleting" onrowediting="SubCategoryDisplayGrid_RowEditing" >
                 <Columns>
                     <asp:TemplateField HeaderText="Sub-Category ID">
                        <ItemTemplate>
                            <asp:Label ID="lblSubCat_ID" runat="server" Text='<%# Eval("subCatID") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:Label ID="lblAdd" runat="server"></asp:Label>
                        </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblSubCat_Name" runat="server" Text='<%# Eval("subCatName") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <EditItemTemplate>
                            <asp:TextBox ID="txtname" runat="server" Text='<%#Eval("subCatName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="txtAddname" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Category Name">
                        <ItemTemplate>
                            <asp:Label ID="lblCat_Id" runat="server" Text='<%# Eval("categoryName") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <EditItemTemplate>
                            <%--<asp:TextBox ID="txtCatID" runat="server" Text='<%#Eval("categoryName") %>'></asp:TextBox>--%>
                             <asp:DropDownList ID="ddlCategoryName" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCategoryName_SelectedIndexChanged">

                             </asp:DropDownList>
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <%--<asp:TextBox ID="txtAddCatID" runat="server"></asp:TextBox>--%>
                             <asp:DropDownList ID="ddlAddCategoryName" AutoPostBack="true" runat="server"  OnSelectedIndexChanged="ddlAddCategoryName_SelectedIndexChanged">

                             </asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Department Name">
                        <ItemTemplate>
                            <asp:Label ID="lblDep_Id"  runat="server" Text='<%# Eval("DepartmentName") %>'></asp:Label>
                        </ItemTemplate>
                        
                         <EditItemTemplate>
                            <%--<asp:TextBox ID="txtCatID" runat="server" Text='<%#Eval("categoryName") %>'></asp:TextBox>--%>
                             <asp:DropDownList ID="ddlDepName" runat="server" >

                             </asp:DropDownList>
                        </EditItemTemplate>                   
                        <FooterTemplate>
                            <%--<asp:TextBox ID="txtAddCatID" runat="server"></asp:TextBox>--%>
                             <asp:DropDownList ID="ddlAddDepName" runat="server">

                             </asp:DropDownList>
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

                            <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="UpdateSubCategory" />
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
</asp:Content>
