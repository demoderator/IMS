<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditMasterProduct.aspx.cs" Inherits="IMS_v1.AddEditMasterProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="wrapper">
        <div class="right">
            <table width="50%" cellpadding="1" cellspacing="1">
                <tr>
                    <th colspan="2">Add/Eidt Product</th>

                </tr>
                <tr>

                    <td>Product Name</td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Description</td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Status</td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Manufacturer</td>
                    <td>
                        <asp:TextBox ID="txtManufacturer" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>GreenRainCode</td>
                    <td>
                        <asp:TextBox ID="txtGreenRainCode" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Pack</td>
                    <td>
                        <asp:TextBox ID="txtPack" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>UnitSize</td>
                    <td>
                        <asp:TextBox ID="txtUnitSize" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>WUnit</td>
                    <td>
                        <asp:TextBox ID="txtWunit" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>ProductType</td>
                    <td>
                        <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>ProductSelection</td>
                    <td>
                        <asp:TextBox ID="txtProductSelection" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>SubCategoryID</td>
                    <td>

                        <asp:DropDownList ID="drpcategory" runat="server">

                       
                    </asp:DropDownList>
                       
                </tr>
                <tr>
                    

                    <td colspan="2"> <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
