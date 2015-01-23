<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayStockDetails.aspx.cs" Inherits="IMS_v1.DisplayStockDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <asp:GridView ID="gdvDetails" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" 
                OnRowCommand="gdvDetails_RowCommand" OnRowDeleting="gdvDetails_RowDeleting" OnRowCancelingEdit="gdvDetails_RowCancelingEdit" OnRowEditing="gdvDetails_RowEditing"
                PageSize="10" AutoGenerateColumns="false" OnPageIndexChanging="gdvDetails_PageIndexChanging" OnSorting="gdvDetails_Sorting" AllowSorting="true">
                <Columns>
                    <asp:TemplateField HeaderText="Product Name" SortExpression="ProductName">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Name" runat="server" Text='<%# Eval("productName") %>'></asp:Label>
                           
                        </ItemTemplate>
                        
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateExpired">

                        <ItemTemplate>
                            <asp:Label ID="lblProd_DE" runat="server" Text='<%#Eval("ExpiryDate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="SalePrice">

                        <ItemTemplate>
                              <asp:Label ID="lblProd_SP" runat="server" Text='<%#Eval("salePrice") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSP" runat="server" Text='<%#Eval("salePrice") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CostPrice">

                        <ItemTemplate>
                            <asp:Label ID="lblProd_CP" runat="server" Text='<%#Eval("costPrice") %>'></asp:Label>
                        </ItemTemplate>
                         <EditItemTemplate>
                            <asp:TextBox ID="txtCP" runat="server" Text='<%#Eval("costPrice") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Discount">

                        <ItemTemplate>
                            <asp:Label ID="lblProd_Discount" runat="server" Text='<%#Eval("discount") %>'></asp:Label>
                        </ItemTemplate>
                         <EditItemTemplate>
                            <asp:TextBox ID="txtDiscount" runat="server" Text='<%#Eval("discount") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="id" Visible="false">

                        <ItemTemplate>
                            <asp:Label ID="lblProd_Id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                        
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />
                            <br />
                            <span onclick="return confirm('Are you sure you want to delete this record?')">
                                <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete"/>
                            </span>
                        </ItemTemplate>

                        <EditItemTemplate>

                            <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="UpdateDep" />
                            <br />
                            <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />
                        </EditItemTemplate>
                        
                       
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
</asp:Content>
