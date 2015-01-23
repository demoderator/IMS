<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditProductDetail.aspx.cs" Inherits="IMS_v1.AddEditProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
        <div class="right">
            <table width="50%" cellpadding="1" cellspacing="1">
                <tr>
                    <th colspan="2">Add/Eidt Product</th>

                </tr>
                <tr>

                    <td>Product Name</td>
                    <td>
                        <div id="container">


                            <div class="side-by-side clearfix">

                                <div>

                                    <asp:DropDownList data-placeholder="select a Product..." ID="drpProductMaster" runat="server" class="chzn-select" >
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

                    <td>QuantityUnit</td>
                    <td>
                        <asp:TextBox ID="txtQuantityUnit" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Discount</td>
                    <td>
                        <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>SalePrice</td>
                    <td>
                        <asp:TextBox ID="txtSalePrice" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>CostPrice</td>
                    <td>
                        <asp:TextBox ID="txtCostPrice" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>DateExpired</td>
                    <td>
                        <asp:TextBox ID="txtDateExpired" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Status</td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
