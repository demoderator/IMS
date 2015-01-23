<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SendToStore.aspx.cs" Inherits="IMS_v1.SendToStore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
        <div class="right">
            <asp:PlaceHolder ID="plhMaster" runat="server">


                <table width="50%" cellpadding="1" cellspacing="1">
                    <tr>
                        <th colspan="2">Place Order </th>

                    </tr>
                    <tr>

                        <td>Order Type</td>
                        <td>
                            <asp:DropDownList ID="drpOrderType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drpOrderType_SelectedIndexChanged">

                             

                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>Order To</td>
                        <td>

                            <asp:DropDownList ID="drpOrderTo" runat="server" AutoPostBack="true">
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>

                        <td>Product List</td>
                        <td>
                            <asp:DropDownList ID="drpSerchProduct" runat="server"></asp:DropDownList>

                        </td>
                    </tr>
                    <tr>

                        <td>Quantity
                        </td>
                        <td>
                            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                    </tr>

                      <tr>

                        <td>Sale Prize
                        </td>
                        <td>
                            <asp:TextBox ID="txtPrize" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                    </tr>
                </table>
            </asp:PlaceHolder>

            <asp:PlaceHolder ID="plsChilde" runat="server">


                <asp:GridView ID="gdvOrderDetail" runat="server" CellSpacingss="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" PageSize="10"
                    AutoGenerateColumns="false" ShowFooter="true" OnRowEditing="gdvOrderDetail_RowEditing" OnRowCancelingEdit="gdvOrderDetail_RowCancelingEdit"
                    OnRowCommand="gdvOrderDetail_RowCommand" OnRowDataBound="gdvOrderDetail_RowDataBound">

                    <Columns>

                        <asp:TemplateField HeaderText="Order Palace Name">
                            <ItemTemplate>
                                <asp:Label ID="lblTouser" runat="server" Text='<%# Eval("ToUser") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Order Number">
                            <ItemTemplate>
                                <asp:Label ID="lblNumber" runat="server" Text='<%# Eval("OrderID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="ProductName">

                            <ItemTemplate>
                                <asp:Label ID="lblProName" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:Label ID="lblProductName_Id" runat="server" Text='<%#Eval("ProductID") %>'></asp:Label>
                                <asp:DropDownList ID="drpOrderDetail" runat="server">
                                </asp:DropDownList>
                            </EditItemTemplate>

                            <FooterTemplate>
                                <asp:DropDownList ID="drpAddOrderDetail" runat="server">
                                </asp:DropDownList>

                            </FooterTemplate>

                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OrderedQuantity">
                            <ItemTemplate>
                                <asp:Label ID="lblQuantity" runat="server" Text='<%# Eval("OrderedQuantity") %>'></asp:Label>
                            </ItemTemplate>

                            <EditItemTemplate>
                                <asp:TextBox ID="txtquantity" runat="server" Text='<%#Eval("OrderedQuantity") %>'></asp:TextBox>

                            </EditItemTemplate>

                            <FooterTemplate>
                                <asp:TextBox ID="txtAddquantity" runat="server" Text='<%#Eval("OrderedQuantity") %>'></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="SalePrice">
                            <ItemTemplate>
                                <asp:Label ID="lblSalePrice" runat="server" Text='<%#Convert.ToInt32( Eval("SalePrice")) %>'></asp:Label>
                            </ItemTemplate>

                            <EditItemTemplate>
                                <asp:TextBox ID="txtSalePrice" runat="server" Text='<%#Convert.ToInt32(Eval("SalePrice")) %>'></asp:TextBox>

                            </EditItemTemplate>

                            <FooterTemplate>
                                <asp:TextBox ID="txtAddSalePrice" runat="server" Text='<%#Eval("SalePrice") %>'></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit"></asp:LinkButton>
                                <br />
                                <span onclick="return confirm('Are you sure you want to delete this record?')">
                                    <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Del" CommandArgument='<%#Eval("orderDetailID")%>'></asp:LinkButton>
                                </span>
                            </ItemTemplate>

                            <EditItemTemplate>

                                <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Upd" CommandArgument='<%#Eval("orderDetailID")%>'></asp:LinkButton>
                                <br />
                                <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel"></asp:LinkButton>
                            </EditItemTemplate>

                            <FooterTemplate>
                                <asp:Button ID="btnAddRecord" runat="server" Text="Add" CommandName="Add"></asp:Button>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <asp:Button ID="btnFinal" runat="server" Text="Submit" OnClick="btnFinal_Click" />

            </asp:PlaceHolder>

        </div>
    </div>
</asp:Content>
