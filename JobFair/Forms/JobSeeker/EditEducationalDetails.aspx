<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditEducationalDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.EditEducationalDetails" %>

<link href="../../Css/Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="EditEducationalDetails" runat="server">

<div id="divMain" runat="server">
    
    <h1><center>Edit Educational Details</center></h1>
    <br /><hr />
        <asp:Panel ID="pnlCollapsableEdit" runat="server" Visible="true" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblHead" runat="server" CssClass="label"></asp:Label>
            <caption>
                <br />
                <br />
                <tr>
                    <td>
                        <asp:Label ID="lblMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMedium" runat="server" AutoPostBack="true">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvMedium" runat="server" ControlToValidate="ddlMedium" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                            <asp:ListItem>Appeared</asp:ListItem>
                            <asp:ListItem>Completed</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="rfvStat" runat="server" ControlToValidate="rblStat" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSpecialization" runat="server" AutoPostBack="True" Height="16px" Width="100px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvSpecialization" runat="server" ControlToValidate="ddlSpecialization" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                        <%--<br />
                    <asp:TextBox ID="txtAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" Visible="False" CssClass="button" />--%></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblYearFrom" runat="server" CssClass="label" Text="From"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMonthFrom" runat="server" AutoPostBack="true">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlYearFrom" runat="server" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblYearTo" runat="server" CssClass="label" Text="To"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMonthTo" runat="server" AutoPostBack="true">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlYearTo" runat="server" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCollege" runat="server" onblur="return CheckOnlyChar(this.id);" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCollege" runat="server" ControlToValidate="txtCollege" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUniversity" runat="server" CssClass="label" Text="Board/University"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUniversity" runat="server" onblur="return CheckOnlyChar(this.id);" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUniversity" runat="server" ControlToValidate="txtUniversity" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPercentage" runat="server" onblur="return CheckIsNum(this.id);" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPercentage" runat="server" ControlToValidate="txtPercentage" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgEditEducationalDetails"></asp:RequiredFieldValidator>
                        <%--<asp:RangeValidator ID="rvPercentage" runat="server" ErrorMessage="Please Enter Percentage Between 35 to 100" MaximumValue="100" MinimumValue="35" ForeColor="Red" ControlToValidate="txtPercentage"></asp:RangeValidator>--%></td>
                </tr>
            </caption>
        </table>
     <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" ValidationGroup="vgEditEducationalDetails" Visible="false" OnClick="btnUpdate_Click"/>
    </asp:Panel>
    <br />

    </div>
    </form>
</body>
</html>
