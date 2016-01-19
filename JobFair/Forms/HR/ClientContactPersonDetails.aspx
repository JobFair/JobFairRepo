<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientContactPersonDetails.aspx.cs" Inherits="JobFair.Forms.HR.ClientContactPersonDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <link href="../../Style.css" rel="stylesheet" />
    <link href="../../Css/Common.css" rel="stylesheet" />
</head>
<body>
    <form id="frmClientContactPersonDetails" runat="server">

    
        
    <div id="divView" style="margin-top: 20px; margin-left: 10px;">
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField Visible="false" HeaderText="HrId" DataField="HrId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Contact Person Name" DataField="ContactPersonName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Designation" DataField="Designation" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="E-mail Id" DataField="EmailId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Contact No" DataField="ContactNo" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Active/Inactive" DataField="IsActive" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>

        
<div id="divMain" runat="server" style="min-height: 500px; padding: 10px">
    
<center>
<asp:Label ID="lblAddWork" runat="server" Text=" Add Client Contact Person " Font-Bold="true"></asp:Label>
</center>
<hr />
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="lblName" runat="server" Text="Contact Person Name"></asp:Label></td>
        <td>
              <asp:TextBox ID="txtName" runat="server" ></asp:TextBox><%--onblur="return CheckAlphaNumeric(this.id);"--%>
              <%--<asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ValidationGroup="vgClientContactPersonDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtDesignation" runat="server" ></asp:TextBox><%--onblur="return CheckOnlyChar(this.id);"--%>
            <%--<asp:RequiredFieldValidator ID="rfvDesignation" runat="server" ControlToValidate="txtDesignation" ValidationGroup="vgClientContactPersonDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblEmail" runat="server" Text="E-mail Id"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><%-- onblur="return CheckAlphaNumeric(this.id);"--%>
            <%--<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="vgClientContactPersonDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblContactNo" runat="server" Text="Contact No." CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtContactNo" runat="server" ></asp:TextBox><%--onblur="return CheckAlphaNumeric(this.id);"--%>
            <%--<asp:RequiredFieldValidator ID="rfvContactNo" runat="server" ControlToValidate="txtContactNo" ValidationGroup="vgClientContactPersonDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActive" runat="server" Text=" Status "></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblistIsActive" runat="server" AutoPostBack="true">
                <asp:ListItem Text="InActive"></asp:ListItem>
                <asp:ListItem Text="Active"></asp:ListItem>
            </asp:RadioButtonList>
            <%--<asp:TextBox ID="txtActive" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>--%>
            <%--<asp:RequiredFieldValidator ID="rfvActive" runat="server" ControlToValidate="txtActive" ValidationGroup="vgClientContactPersonDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            <br />
        </td>
        </tr>
          <tr>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add Details" ValidationGroup="vgClientContactPersonDetails" OnClick ="btnAdd_Click" style="margin-top: 10px; margin-left: 150px" />
        </td>
    </tr>
    </table>
     <div id="divAddMore" style="margin-top: 20px; margin-left: 10px;">
            <asp:HiddenField ID="hfHrId" runat="server" />
            <asp:GridView ID="grvAddMore" AutoGenerateColumns="false" runat="server" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField Visible="false" HeaderText="HrId" DataField="HrId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Contact Person Name" DataField="ContactPersonName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Designation" DataField="Designation" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="E-mail Id" DataField="EmailId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Contact No" DataField="ContactNo" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Active/Inactive" DataField="IsActive" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <div style="margin-top: 10px; margin-left: 150px">
            <asp:Button ID="btnSaveDetails" runat="server" Style="color: White"
                Text="Save Contact Person Details" BackColor="#999966" OnClick="btnSaveDetails_Click"/>
        </div>

<div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>
    </div>
    </form>
</body>
</html>
