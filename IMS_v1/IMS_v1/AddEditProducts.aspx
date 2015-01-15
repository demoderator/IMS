<%@ Page Title="manage Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditProducts.aspx.cs" Inherits="IMS_v1.AddEditProducts" %>

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
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
        <div class="right">
            <asp:Label ID="lblProd_ScI2" runat="server" Text=''> 
                                    
                                    <a href="WebForm1.aspx"  class="popup"> add New Product</a>
                                    
            </asp:Label>
            <asp:GridView ID="ProdDisplayGrid" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" PageSize="10"
                AutoGenerateColumns="false" OnPageIndexChanging="ProdDisplayGrid_PageIndexChanging" OnRowCommand="ProdDisplayGrid_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Product ID">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ID" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Product Name">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Name" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Quan" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_CP" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Manufacturer">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_SP" runat="server" Text='<%# Eval("Manufacturer") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="GreenRainCode">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ExD" runat="server" Text='<%# Eval("GreenRainCode") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Pack">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_man1" runat="server" Text='<%# Eval("Pack") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="UnitSize">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_man2" runat="server" Text='<%# Eval("UnitSize") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="WUnit">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ScI" runat="server" Text='<%# Eval("WUnit") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>

                            <asp:Label ID="Label1" runat="server" Text=''> 

                                 <a href="AddEditMasterProduct.aspx?Id=<%# Eval("ProductID")%>">
                                     Edit</asp:Label>

                            <asp:Label ID="Label2" runat="server" Text=''>

                                <asp:LinkButton ID="lnkDelete" runat="server" CommandName="del" CommandArgument='<%# Eval("ProductID")%>' OnClientClick="return ConfirmDelete();">
                             Delete </asp:LinkButton></asp:Label>

                             <asp:Label ID="Label3" runat="server" Text=''> 

                                 <a href="ListProductDetail.aspx?ProMasid=<%# Eval("ProductID")%>">Detail</a>
                                 </asp:Label>

                        </ItemTemplate>

                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <%--onrowcancelingedit="DepDisplayGrid_RowCancelingEdit" ShowFooter="true"
            onrowcommand="DepDisplayGrid_RowCommand" onrowdeleting="DepDisplayGrid_RowDeleting" onrowediting="DepDisplayGrid_RowEditing" onrowupdating="DepDisplayGrid_RowUpdating">--%>
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
