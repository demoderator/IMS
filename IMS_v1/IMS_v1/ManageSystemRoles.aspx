<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageSystemRoles.aspx.cs" Inherits="IMS_v1.ManageSystemRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="wrapper">
             <div class="right full">
                <asp:GridView ID="roleDepGrid" runat="server" cellspacing="0" cellpadding="0" border="0" width="100%" CssClass="grid" AllowPaging="True" PageSize="10" 
                AutoGenerateColumns="false" ShowFooter="true" OnPageIndexChanging="roleDepGrid_PageIndexChanging"   onrowcancelingedit="roleDepGrid_RowCancelingEdit"
            onrowcommand="roleDepGrid_RowCommand" OnRowDataBound="roleDepGrid_RowDataBound" onrowdeleting="roleDepGrid_RowDeleting" onrowediting="roleDepGrid_RowEditing" onrowupdating="roleDepGrid_RowUpdating">
                    <Columns>
                        <asp:TemplateField HeaderText="Role ID">
                        <ItemTemplate>
                            <asp:Label ID="lblRole_ID" runat="server"  Text='<%# Eval("RoleId") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:Label ID="lblAdd" runat="server"></asp:Label>
                        </FooterTemplate>
                    </asp:TemplateField>

                        <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblRole_Name" runat="server" Text='<%# Eval("RoleName") %>'></asp:Label>
                        </ItemTemplate>
                        
                        <EditItemTemplate>

                            <asp:TextBox ID="txtname" runat="server"  Text='<%#Eval("RoleName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="txtAddname" runat="server"></asp:TextBox>
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
