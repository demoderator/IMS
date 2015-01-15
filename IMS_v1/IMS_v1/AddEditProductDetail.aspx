<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditProductDetail.aspx.cs" Inherits="IMS_v1.AddEditProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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

                        <asp:DropDownList ID="drpProductMaster" runat="server">
                        </asp:DropDownList>
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
