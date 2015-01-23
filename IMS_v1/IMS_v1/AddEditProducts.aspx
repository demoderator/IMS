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
                                <asp:Label ID="lblProd_id" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Name" SortExpression="ProductName">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Name" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Code" >
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Code" runat="server" Text='<%# Eval("prodCode") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Manufacturer">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Man" runat="server" Text='<%# Eval("man") %>'></asp:Label>
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

                        <asp:TemplateField HeaderText="Description" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Desc" runat="server" Text='<%# Eval("prodDesc") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="Generic Name" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_Gen" runat="server" Text='<%# Eval("genName") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="GreenRainCode" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_GRC" runat="server" Text='<%# Eval("GRC") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="Last Updated Date" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_LUD" runat="server" Text='<%# Eval("luDate") %>'></asp:Label>
                            </ItemTemplate>

                         </asp:TemplateField>

                        <asp:TemplateField HeaderText="Pack" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_pack" runat="server" Text='<%# Eval("pack") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="UnitSize" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_us" runat="server" Text='<%# Eval("US") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Selection" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_sel" runat="server" Text='<%# Eval("US") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Product Threshold" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_tsh" runat="server" Text='<%# Eval("TSH") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="UPC" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_upc" runat="server" Text='<%# Eval("upc") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="WUnit" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblProd_wunit" runat="server" Text='<%# Eval("wUnit") %>'></asp:Label>
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
                               <asp:LinkButton ID="lnkDisplay" runat="server" Text="Display" CommandName="displayPopup" CommandArgument='<%# Eval("ProductID")%>'></asp:LinkButton>
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
