<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_ProductMainEdit_Popup.ascx.cs" Inherits="IMS_v1.UserControls.uc_ProductMainEdit_Popup" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<script>
    window.onunload = refreshParent;
    function refreshParent() {
        window.opener.location.reload();
    }
</script>
<div id="Div1" style="width:100%; overflow:auto; background-color: #ece9ec">
    <table border="0">
                <%--style="background-color:white"--%>
    <tr>
        <th colspan="5">Add/Edit Product</th>

    </tr>
    <tr runat="server" id="prodID">
        <td>Product internal ID</td>
        <td>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox></td>
    </tr>

    <tr runat="server" id="IDName">
        <td >Product ID</td>
        <td>
        <asp:TextBox ID="txtProdOrgID" runat="server"></asp:TextBox>

        </td>
        <td >Product Name</td>
        <td>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>

        </td>
        
    </tr>

    <tr id="GBName">
        <td>Generic Name</td>
        <td>
            <asp:TextBox ID="txtGName" runat="server"></asp:TextBox>

        </td>
        <td>Brand Name</td>
        <td>
            <asp:TextBox ID="txtBrndName" runat="server"></asp:TextBox>

        </td>

    </tr>
    
    <tr id="drgTypePrdCode">
        <td>Product Code</td>
        <td>
             <asp:TextBox ID="txtProdCode" runat="server"></asp:TextBox>
        </td>
        <td>Product Type </td>
        <td>
            <asp:TextBox ID="txtProdType" runat="server"></asp:TextBox>

        </td>
    </tr>

    <tr id="SCPrice" runat="server">
        <td>Cost Price</td>
        <td>
            <asp:TextBox ID="txtCP" runat="server"></asp:TextBox>
        </td>
        <td>Sale Price</td>
        <td>
            <asp:TextBox ID="txtSP" runat="server"></asp:TextBox>
        </td>
    </tr>
    
    <tr id="meas">
        <td> Quantity Measure </td>
        <td>
            <asp:TextBox ID="txtMeasQty" runat="server"></asp:TextBox>

        </td>
        <td> Measure Type </td>
        <td>
            <asp:TextBox ID="txtMeasType" runat="server"></asp:TextBox>

        </td>
    </tr>
   
    <tr id="qtUnitDis">
        <td>Quantity Unit</td>
        <td>
             <asp:TextBox ID="txtQUnit" runat="server"></asp:TextBox>
        </td>
        <td>Maximum Discount</td>
        <td>
             <asp:TextBox ID="TxtDisc" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr id="TrExp" runat="server">
        <td>Product Threshold</td>
        <td>
             <asp:TextBox ID="txtThreshold" runat="server"></asp:TextBox>
        </td>
        <td>Expiry</td>
        <td>
             <asp:TextBox ID="TextExp" runat="server"></asp:TextBox>
        </td>
    </tr>
    
    <tr id="Description" runat="server">
        <td>Description</td>
        <td colspan="3">
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>

        </td>

    </tr>

    <tr id="subCategory" runat="server">
        <td>SubCategory</td>
        <td colspan="3">
            <asp:DropDownList ID="drpcategory" runat="server">
            </asp:DropDownList>
        </td>

    </tr>
   
    <tr id="Actions">
     <td colspan="2"> 
                        <asp:Button ID="SaveVal" runat="server" OnClick="SaveVal_Click" Text="Update" />
                        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click"  Text="Close" />
                        <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" />
                    </td>
                </tr>
</table>
</div>
             
