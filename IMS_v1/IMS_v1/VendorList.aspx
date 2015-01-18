<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendorList.aspx.cs" Inherits="IMS_v1.VendorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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

        <div class="right full">


            <table>
                <tr>
                    <th colspan="2">Search</th>
                </tr>

                <tr>
                    <td>Search by Product</td>
                    <td>
                        <div id="container">


                            <div class="side-by-side clearfix">

                                <div>

                                    <asp:DropDownList data-placeholder="select a Vendor..." runat="server" ID="drpVendor" class="chzn-select" >
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

                <tr>
                    <td colspan="2">

                        <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="btnSubmit_Click" />
                    </td>
                </tr>

            </table>
            <a href="AddEditVendor.aspx">add New vendor</a>
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
