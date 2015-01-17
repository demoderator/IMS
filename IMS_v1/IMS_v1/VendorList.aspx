<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendorList.aspx.cs" Inherits="IMS_v1.VendorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">

        <div class="right full">
            <a href="AddEditVendor.aspx"> add New vendor</a>
            <asp:GridView ID="gdvVendor" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid"
                AutoGenerateColumns="false" OnSelectedIndexChanged="gVStoreInfo_SelectedIndexChanged"
                OnRowDataBound="gVStoreInfo_RowDataBound" AllowPaging="True" PageSize="10"
                OnPageIndexChanging="gVStoreInfo_PageIndexChanging" OnRowCommand="gdvVendor_RowCommand" AllowSorting="true" OnSorting="gdvVendor_Sorting">
                <Columns>
                    <asp:TemplateField HeaderText="Vendor Name" SortExpression="SupName">
                        <ItemTemplate>
                            <asp:Label ID="lblVendor" runat="server" Text='<%# Eval("SupName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="lblSubCat" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="lblDept" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>
                            <asp:Label ID="lblCat" runat="server" Text='<%# Eval("Country") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label ID="lblProduct" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>


                            <asp:Label ID="Label1" runat="server" Text=''> 

                                 <a href="AddEditVendor.aspx?Id=<%# Eval("Supp_ID")%>">
                                     Edit</asp:Label>

                            <asp:Label ID="Label2" runat="server" Text=''>

                                <asp:LinkButton ID="lnkDelete" runat="server" CommandName="del" CommandArgument='<%# Eval("Supp_ID")%>' OnClientClick="return ConfirmDelete();">
                             Delete </asp:LinkButton></asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

    </div>
    <script language="javascript" type="text/javascript">

        function ConfirmDelete() {
            var val = confirm("Are you sure you want to delete this Vendor?");
            if (val) {
                return true;
            }
            else {
                return false;
            }
        }
    </script>
</asp:Content>
