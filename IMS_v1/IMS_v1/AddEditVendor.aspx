<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditVendor.aspx.cs" Inherits="IMS_v1.AddEditVendor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="wrapper">
        <div class="right">
            <table width="50%" cellpadding="1" cellspacing="1">
                <tr>
                    <th colspan="4">Add/Eidt Vendor</th>

                </tr>
                <tr>
                    <td>Vendor Name</td>
                    <td>
                        <asp:TextBox ID="txtVendorName" runat="server"></asp:TextBox></td>


                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>City</td>
                    <td>
                        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>


                    <td>State</td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Country</td>
                    <td>
                        <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox></td>


                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox></td>


                    <td>Fax</td>
                    <td>
                        <asp:TextBox ID="txtfax" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>Mobile</td>
                    <td>
                        <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox></td>


                    <td>Pager</td>
                    <td>
                        <asp:TextBox ID="txtpager" runat="server"></asp:TextBox></td>
                </tr>
                <tr>

                    <td>ConPerson</td>
                    <td>
                        <asp:TextBox ID="txtConPerson" runat="server"></asp:TextBox>
                    </td>



                    <td>Discount</td>
                    <td>
                        <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                    </td>

                </tr>

                <tr>

                    <td>Credit</td>
                    <td>
                        <asp:TextBox ID="txtCredit" runat="server"></asp:TextBox>
                    </td>



                    <td>Pincode</td>
                    <td>
                        <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>

                    <td>LineID</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtLineIdk" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>


                    <td colspan="4">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
