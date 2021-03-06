﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecivedOrder.aspx.cs" Inherits="IMS_v1.RecivedOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="wrapper">
        <div class="right full">
            
                  <table>
                <tr>
                    <th colspan="2">Search By Order Number</th>
                </tr>

                <tr>
                    <td>Order Number</td>
                    <td>

                        <asp:TextBox ID="txtSearch" runat="server"> </asp:TextBox>
                    </td>
                </tr>

                <tr><td colspan="2">

                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td></tr>
               
            </table>
            <asp:GridView ID="gdvReceived" runat="server" AutoGenerateColumns="false"
                CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True"
                PageSize="10" OnPageIndexChanging="gdvReceived_PageIndexChanging"
                OnRowEditing="gdvReceived_RowEditing" OnRowCancelingEdit="gdvReceived_RowCancelingEdit"
                OnRowCommand="gdvReceived_RowCommand" OnRowDataBound="gdvReceived_RowDataBound">

                <Columns>
                    <asp:TemplateField HeaderText="Request by">
                        <ItemTemplate>

                            <%#Eval("FromUser") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Request To">
                        <ItemTemplate>

                            <%#Eval("ToUser") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Order Date">
                        <ItemTemplate>

                            <%# Convert.ToDateTime( Eval("OrderDate")).ToString("MMM dd ,yyyy") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Order Number">
                        <ItemTemplate>

                            <%#Eval("OrderID") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Product">
                        <ItemTemplate>

                            <%#Eval("ProductName") %>
                            
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>

                            <%#Eval("OrderedQuantity") %>

                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ReceivedQuantity">
                        <ItemTemplate>

                            <%#Eval("ReceivedQuantity") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtOrderedQuantity" runat="server" Text='<%#Eval("ReceivedQuantity") %>'></asp:TextBox>

                        </EditItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SalePrice">
                        <ItemTemplate>

                            <%#Eval("SalePrice") %>
                        </ItemTemplate>


                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Order Status">
                        <ItemTemplate>

                            <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("StatusDetails")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>

                            <%#Eval("DetailDescription") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEdit" Text='Received' runat="server" CommandName="Edit">
                            </asp:LinkButton>

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Upd" CommandArgument='<%#Eval("orderDetailID")%>'></asp:LinkButton>
                            <br />
                            <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
