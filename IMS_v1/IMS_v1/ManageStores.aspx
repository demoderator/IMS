<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageStores.aspx.cs" Inherits="IMS_v1.ManageStores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="wrapper">
             <div class="right full">
                <asp:GridView ID="storeDepGrid" runat="server" runat="server" cellspacing="0" cellpadding="0" border="0" width="100%" CssClass="grid" AllowPaging="True" PageSize="10" 
                AutoGenerateColumns="false" ShowFooter="true" OnPageIndexChanging="storeDepGrid_PageIndexChanging"   onrowcancelingedit="storeDepGrid_RowCancelingEdit"
            onrowcommand="storeDepGrid_RowCommand" OnRowDataBound="storeDepGrid_RowDataBound" onrowdeleting="storeDepGrid_RowDeleting" onrowediting="storeDepGrid_RowEditing" onrowupdating="storeDepGrid_RowUpdating">
                     <Columns>
                        <asp:TemplateField HeaderText="Store ID">
                            <ItemTemplate>
                                <asp:Label ID="lblUserRole_ID" runat="server"  Text='<%# Eval("userRoleID") %>'></asp:Label>
                            </ItemTemplate>
                        
                            <FooterTemplate>
                                <asp:Label ID="lblAdd" runat="server"></asp:Label>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Store Name">
                            <ItemTemplate>
                                <asp:Label ID="lblUserRole_Name" runat="server" Text='<%# Eval("userRoleName") %>'></asp:Label>
                            </ItemTemplate>
                        
                            <EditItemTemplate>

                                <asp:TextBox ID="txtname" runat="server"  Text='<%#Eval("userRoleName") %>'></asp:TextBox>
                            </EditItemTemplate>
                        
                            <FooterTemplate>
                                <asp:TextBox ID="txtAddname" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Role Name">
                            <ItemTemplate>
                                <asp:Label ID="lblRole_Name" runat="server" Text='<%# Eval("SystemRoleName") %>'></asp:Label>
                            </ItemTemplate>
                        
                            <EditItemTemplate>

                                <asp:DropDownList ID="ddlRoleName" runat="server">
                                </asp:DropDownList>
                            </EditItemTemplate>
                        
                            <FooterTemplate>
                                <asp:DropDownList ID="ddlAddRoleName" runat="server">

                             </asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Store Description">
                            <ItemTemplate>
                                <asp:Label ID="lblRole_Desc" runat="server" Text='<%# Eval("roleDescription") %>'></asp:Label>
                            </ItemTemplate>
                        
                            <EditItemTemplate>

                                <asp:TextBox ID="txtRDes" runat="server"  Text='<%#Eval("roleDescription") %>'></asp:TextBox>
                            </EditItemTemplate>
                        
                            <FooterTemplate>
                                <asp:TextBox ID="txtAddRDesc" runat="server"></asp:TextBox>
                            </FooterTemplate>
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

                            <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" />
                            <br />
                            <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:Button ID="btnAddRecord" runat="server" Text="Add" CommandName="Add"></asp:Button>
                        </FooterTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
             </div>
     </div>
</asp:Content>
