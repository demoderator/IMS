<%@ Page Title="manage Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditProducts.aspx.cs" Inherits="IMS_v1.AddEditProducts" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="uc" TagName="prodEdit_uc" Src="~/UserControls/uc_ProductMainEdit_Popup.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4/jquery.min.js"></script>
    <script src="fancybox/jquery.easing-1.3.pack.js" type="text/javascript"></script>
    <link href="fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" type="text/css" />
    <script src="fancybox/jquery.fancybox-1.3.4.js" type="text/javascript"></script>
    <script src="fancybox/jquery.fancybox-1.3.4.pack.js" type="text/javascript"></script>
    <script src="fancybox/jquery.mousewheel-3.0.4.pack.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {


            $("a.popup").fancybox({
                'overlayShow': false,
                'transitionIn': 'elastic',
                'transitionOut': 'elastic'
            });

        });
    </script>
    
    <style type="text/css">
        .modalBackground
        {
             background-color: gray;
             filter: alpha(opacity=50);
             opacity: 0.7;
        }
        .popup
        {
            background-color: #ddd;
            margin: 0px auto;
            width: 330px;
            position: relative;
            border: Gray 2px inset;
        }
    </style>
     <style type="text/css">
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
        <div class="right full">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="updatePanel" runat="server"></asp:UpdatePanel>
                <table>
                    <tr>
                        <th colspan="2">Search</th>
                    </tr>

                    <tr>
                        <td>Search by Product</td>
                        <td>
                           
                             <div id="container1">


                            <div class="side-by-side clearfix">

                                <div>

                                    <asp:DropDownList data-placeholder="select a Product..." ID="drpSerchProduct" runat="server" class="chzn-select" >
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

                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />
                        <asp:Button ID="BtnAddNew" runat="server" Text="AddNew" OnClick="BtnAddNew_Click"  />
                        </td></tr>
               
                </table>
                
                 
                <asp:GridView ID="ProdDisplayGrid" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" PageSize="10"
                    AutoGenerateColumns="false" OnPageIndexChanging="ProdDisplayGrid_PageIndexChanging" OnRowDeleting="ProdDisplayGrid_RowDeleting"
                    OnRowCommand="ProdDisplayGrid_RowCommand" OnSorting="ProdDisplayGrid_Sorting" AllowSorting="true">
                    <Columns>
                        <asp:TemplateField HeaderText="Product Id">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_org_id" runat="server" Text='<%# Eval("org_ID") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Name" SortExpression="ProductName">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Name" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>
                                                
                       <asp:TemplateField HeaderText="Unit Cost">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_CP" runat="server" Text='<%# Eval("costPrice") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Sale Price">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_SP" runat="server" Text='<%# Eval("salePrice") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Maximum Discount">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Disc" runat="server" Text='<%# Eval("discount") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                       <asp:TemplateField HeaderText="Sub Category">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_SubCat" runat="server" Text='<%# Eval("subCatName") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Category">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Cat" runat="server" Text='<%# Eval("catName") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Department">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Dep" runat="server" Text='<%# Eval("DepName") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>
                                               

                        <%-- Hidden fields used for update --%>
                        <asp:TemplateField HeaderText="Product Id Internal" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_id" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Description" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Desc" runat="server" Text='<%# Eval("prodDesc") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                         <asp:TemplateField HeaderText="Manufacturer" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Man" runat="server" Text='<%# Eval("man") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Generic Name" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Gen" runat="server" Text='<%# Eval("genName") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="Last Updated Date" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_LUD" runat="server" Text='<%# Eval("luDate") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Code" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Code" runat="server" Text='<%# Eval("prodCode") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Product Selection" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_sel" runat="server" Text='<%# Eval("prodSel") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Measuring Quantity" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_mQTY" runat="server" Text='<%# Eval("measQty") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Measuring Type " Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_mType" runat="server" Text='<%# Eval("measType") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Line ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_line" runat="server" Text='<%# Eval("line_ID") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Quantity Unit" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_qUnit" runat="server" Text='<%# Eval("qUnit") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Control" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_con" runat="server" Text='<%# Eval("control") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Thresh-Hold" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_tsh" runat="server" Text='<%# Eval("ThreshHold") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Bin Number" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_bNum" runat="server" Text='<%# Eval("binNum") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Exipry " Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_exp" runat="server" Text='<%# Eval("exp") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Sub Category ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_subCatID" runat="server" Text='<%# Eval("SubCategoryID") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Type" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Type" runat="server" Text='<%# Eval("ProductType") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                               <asp:LinkButton ID="lnkDisplay" runat="server" Text="Details" CommandName="displayPopup" CommandArgument='<%# Eval("ProductID")%>'></asp:LinkButton>
                               <asp:LinkButton ID="lnkEdit" runat="server" Text = "Edit" CommandName="EditVal"></asp:LinkButton>
                                <span onclick="return confirm('Are you sure you want to delete this record?')">
                                <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete"></asp:LinkButton>
                                </span>
                            </ItemTemplate>

                        </asp:TemplateField>
                     
                    </Columns>
                </asp:GridView>
          
                <asp:Button ID="_editPopupButton" runat="server" Style="display: none" />
                
                <cc1:ModalPopupExtender ID="mpeEditProduct" runat="server" BackgroundCssClass="modalBackground" RepositionMode="RepositionOnWindowResizeAndScroll" 
                    DropShadow="true" PopupDragHandleControlID="_prodEditPanel" TargetControlID="_editPopupButton" PopupControlID="_prodEditPanel" BehaviorID="EditModalPopupMessage">
                </cc1:ModalPopupExtender>
                
                <asp:Panel ID="_prodEditPanel" runat="server" Width="100%" Style="display: none">
                    <asp:UpdatePanel ID="_prodEdit" runat="server">
                        <ContentTemplate>
                            <uc:prodEdit_uc ID="ucProdEdit" runat="server" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>

        </div>
    </div>
    
    <script language="javascript" type="text/javascript">

        function ConfirmDelete() {
            var val = confirm("Are you sure you want to delete this Product?");
            if (val) {
                return true;
            }
            else {
                return false;
            }
        }
    </script>

</asp:Content>
