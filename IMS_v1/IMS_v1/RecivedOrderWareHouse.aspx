<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecivedOrderWareHouse.aspx.cs" Inherits="IMS_v1.RecivedOrderWareHouse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
       

    <div class="wrapper">
        <div class="right full">
            <a href="ReceivedFromVendor.aspx"> Received From Vendor</a>

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

                          <asp:Label ID="lblOrderQuantity" runat="server" Text=' <%#Eval("OrderedQuantity") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>


                       <asp:TemplateField HeaderText="Available Quantity">
                        <ItemTemplate>
                            
                            
                            <asp:Label ID="lblAvailable" runat="server" Text='<%#Eval("QuantityUnit")%> '></asp:Label>
                          <asp:Label ID="lblExpiry" runat="server" Text='<%#Eval("DateExpired")%> '></asp:Label>
                            
                          
                              <asp:Label ID="lblProductDetail" runat="server" Text='<%#Eval("ProductDetail_ID")%>' Visible="false"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Order Status">
                        <ItemTemplate>

                            <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("StatusDetails")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="SalePrice">
                        <ItemTemplate>

                            <%# Convert.ToInt32( Eval("SalePrice"))  %>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSalePrice" runat="server" Text='<%# Convert.ToInt32( Eval("SalePrice")) %>'></asp:TextBox>

                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>

                            <%#Eval("DetailDescription") %>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtDetailDescription" runat="server" Text='<%#Eval("DetailDescription") %>'></asp:TextBox>

                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEdit" Text='Approved' runat="server" CommandName="Edit">
                            </asp:LinkButton>

                            <asp:LinkButton ID="lbldiscard" Text='Discard ' runat="server" CommandName="discard" CommandArgument='<%#Eval("orderDetailID")%>'>

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
