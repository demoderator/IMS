<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListProductDetail.aspx.cs" Inherits="IMS_v1.ListProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="wrapper">
        <div class="right">


            <asp:GridView ID="gdvlistProductDetail" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%" CssClass="grid" AllowPaging="True" PageSize="10"
                AutoGenerateColumns="false">
                <Columns>

                    <asp:TemplateField HeaderText="Product Name">

                        <ItemTemplate>
                            <%#Eval("ProductName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="QuantityUnit">

                        <ItemTemplate>
                            <%#Eval("QuantityUnit") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Discount">

                        <ItemTemplate>
                            <%#Eval("Discount") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SalePrice">

                        <ItemTemplate>
                            <%#Eval("SalePrice") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateExpired">

                        <ItemTemplate>
                            <%#Eval("DateExpired") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CostPrice">

                        <ItemTemplate>
                            <%#Eval("CostPrice") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">

                        <ItemTemplate>
                            <%#Eval("Status") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateCreated">

                        <ItemTemplate>
                            <%#Eval("DateCreated") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">

                        <ItemTemplate>
                            
                            <asp:Label ID="Label1" runat="server" Text=''> 

                                 <a href="AddEditProductDetail.aspx?detaiiId=<%# Eval("ProductDetail_ID")%>">
                                     Edit</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
