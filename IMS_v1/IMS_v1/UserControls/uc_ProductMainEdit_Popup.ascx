<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_ProductMainEdit_Popup.ascx.cs" Inherits="IMS_v1.UserControls.uc_ProductMainEdit_Popup" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<div id="Div1" style="width:100%; overflow:auto; background-color: #ece9ec">
    <table border="0" >
                <%--style="background-color:white"--%>
    <tr>
        <th colspan="3">Add/Edit Product</th>

    </tr>
    <tr runat="server" id="prodID">
        <td>Product Name</td>
        <td>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox></td>
    </tr>
    <tr runat="server" id="ProdName">
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
        <td>Product Threshold</td>
        <td>
             <asp:TextBox ID="txtThreshold" runat="server"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td>UPC</td>
        <td>
             <asp:TextBox ID="txtUPC" runat="server"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td>Product Code</td>
        <td>
             <asp:TextBox ID="txtProdCode" runat="server"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td>SubCategory</td>
        <td>
            <asp:DropDownList ID="drpcategory" runat="server">
            </asp:DropDownList>
        </td>

    </tr>
   
    <tr>
     <td colspan="2"> 
                        <asp:Button ID="SaveVal" runat="server" OnClick="SaveVal_Click" Text="Update" />
                        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click"  Text="Close" />
                        <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" />
                    </td>
                </tr>
</table>
</div>
             
