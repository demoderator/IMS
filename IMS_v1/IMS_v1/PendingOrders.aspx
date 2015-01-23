<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PendingOrders.aspx.cs" Inherits="IMS_v1.PendingOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper">
        <div class="right full">

          <asp:GridView ID="gdvPendding" runat="server" AutoGenerateColumns="false"
                CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True"
                PageSize="10" OnPageIndexChanging="gdvPendding_PageIndexChanging">
                

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

                   
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
