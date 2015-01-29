<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceivedFromVendor.aspx.cs" Inherits="IMS_v1.ReceivedFromVendor" %>
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
                <tr runat="server" id="orderDet">
                    <td>Invoice #</td>
                    <td colspan="1">
                        <asp:TextBox ID="txtInvoiceNum" runat="server"></asp:TextBox>
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
                    <asp:TemplateField HeaderText="Product Name">
                        <ItemTemplate>

                            <%#Eval("ProductName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Vendor">
                        <ItemTemplate>

                            <%#Eval("VendorID") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Order Date">
                        <ItemTemplate>

                            <%# Convert.ToDateTime( Eval("OrderDate")).ToString("MMM dd ,yyyy") %>
                        </ItemTemplate>
                       
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Receive Date">
                        <ItemTemplate>

                            <%#Eval("ReceivedDate")==DBNull.Value? "":Convert.ToDateTime( Eval("ReceivedDate")).ToString("MMM dd ,yyyy") %>
                           
                        </ItemTemplate>
                         <EditItemTemplate>
                               <asp:TextBox ID="txtDateRec" runat="server" Text='<%#Eval("ReceivedDate")%>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ordered Quantity">
                        <ItemTemplate>

                            <%#Eval("OrderedQuantity") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Received Quantity">
                        <ItemTemplate>

                            <%#Eval("ReceivedQuantity") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRecQuantity" runat="server" Text='<%#Eval("ReceivedQuantity") %>'></asp:TextBox>

                        </EditItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="SalePrice">
                        <ItemTemplate>
                        <asp:Label ID="lblSP" runat="server" Text=' 
                            <%#Eval("SalePrice")==DBNull.Value?0:float.Parse( Eval("SalePrice").ToString())  %>'>

                        </asp:Label>
                           
                        </ItemTemplate>
                                                
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cost Price">
                        <ItemTemplate>

                            <%#Eval("CostPrice")==DBNull.Value?0:float.Parse( Eval("CostPrice").ToString())  %>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Bonus">
                        <ItemTemplate>

                            <%#Eval("Bonus")==DBNull.Value?0:float.Parse( Eval("Bonus").ToString())  %>
                        </ItemTemplate>
                         <EditItemTemplate>
                              <asp:TextBox ID="txtBonus" runat="server" 
                                  Text='<%#Eval("Bonus")==DBNull.Value?0:float.Parse( Eval("Bonus").ToString())  %>'>

                              </asp:TextBox>
                         </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Expiry date">
                        <ItemTemplate>
                             <asp:Label ID="lblExpiry" runat="server" Text='<%#Eval("DateExpired")%> '></asp:Label>
                           
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtDateExpired" runat="server" Text='<%#Eval("DateExpired") %>'></asp:TextBox>

                        </EditItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Order Status">
                        <ItemTemplate>

                            <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("StatusDetails")%>'></asp:Label>
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
