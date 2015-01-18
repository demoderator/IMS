<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetExpiryDetails.aspx.cs" Inherits="IMS_v1.GetExpiryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       <div class="wrapper">
        <div class="right full">

    <asp:GridView ID="gdvDetails" runat="server" CellSpacing="0" CellPadding="0" border="0" Width="100%"
        CssClass="grid" AllowPaging="True" PageSize="10"
        AutoGenerateColumns="false"
        OnPageIndexChanging="gdvDetails_PageIndexChanging"
        OnSorting="gdvDetails_Sorting" AllowSorting="true">
         <Columns>
                     <asp:TemplateField HeaderText="Product Name" SortExpression="productName">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ID" runat="server" Text='<%# Eval("productName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

               


                    <asp:TemplateField HeaderText="Assigned To"  SortExpression="AssignedTo">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_Quan" runat="server" Text='<%# Eval("AssignedTo") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="quantity">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_CP" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
              <asp:TemplateField HeaderText="ExpiryDate">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_CP" runat="server" Text='<%# Eval("ExpiryDate") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                 

                    <asp:TemplateField HeaderText="Sale Price">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_ExD" runat="server" Text='<%# Eval("salePrice") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cost Price">
                        <ItemTemplate>
                            <asp:Label ID="lblProd_man" runat="server" Text='<%# Eval("costPrice") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                        </Columns>
    </asp:GridView>
            </div>
           </div>
</asp:Content>
