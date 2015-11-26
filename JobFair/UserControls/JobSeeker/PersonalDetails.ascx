<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.PersonalDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<table>
    <tr>
        <td>&nbsp;</td>
        <td colspan="2">
            <h1>Personal Details</h1>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPhoto" runat="server" Text="Photo"></asp:Label>
        </td>
        <td colspan="2">
            <asp:FileUpload ID="FileUploadPhoto" runat="server" Visible="true" />
            <asp:Image ID="imgPersonalPhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" />
            <asp:LinkButton ID="lnkbtnEdit" runat="server" OnClick="lnkbtnEdit_Click">Edit Photo</asp:LinkButton>
            <asp:LinkButton ID="lnkbtnCancel" runat="server" Visible="false" OnClick="lnkbtnCancel_Click">Cancel</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td rowspan="6">
            <asp:Label ID="lblPresentAdd" runat="server" Text="Present Address"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPresentAddress" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPresentAddress" runat="server" ControlToValidate="txtPresentAddress" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Country</td>

        <td rowspan="4">
            <asp:UpdatePanel ID="pnlPresentAddress" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountryPresent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCountryPresent" runat="server" ControlToValidate="ddlCountryPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlStatePresent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStatePresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvStatePresent" runat="server" ControlToValidate="ddlStatePresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlCityPresent" runat="server" OnSelectedIndexChanged="ddlCityPresent_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCityPresent" runat="server" ControlToValidate="ddlCityPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlAreaPresent" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvAreaPresent" runat="server" ControlToValidate="ddlAreaPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Area</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPinCode" runat="server" Text="Pincode"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPincodePresent" runat="server" onblur="return CheckIsNum(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPincodePresent" runat="server" ControlToValidate="txtPincodePresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td rowspan="6">
            <asp:Label ID="lblPermAddress" runat="server" Text="Permanent Adrress"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblAddressPerm" runat="server" Text="Address"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtAddressPerm" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddressPerm" runat="server" ControlToValidate="txtAddressPerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Country</td>
        <td rowspan="4">
            <asp:UpdatePanel ID="pnlPermanentAddress" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountryPerm" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPerm_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCountryPerm" runat="server" ControlToValidate="ddlCountryPerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlStatePerm" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatePerm_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvStatePerm" runat="server" ControlToValidate="ddlStatePerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlCityPerm" runat="server" OnSelectedIndexChanged="ddlCityPerm_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCityPerm" runat="server" ControlToValidate="ddlCityPerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlAreaPerm" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvAreaPerm" runat="server" ControlToValidate="ddlAreaPerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStatePerm" runat="server" Text="State"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCityPerm" runat="server" Text="City"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Area</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPincodePerm" runat="server" Text="Pincode"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtPincodePerm" runat="server" onblur="return CheckIsNum(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPincodePerm" runat="server" ControlToValidate="txtPincodePerm" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtDOB" runat="server" onblur="return IsValidDate(this.id);"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDOB" PopupButtonID="txtDOB" Format="yyyy/MM/dd" />
           <%-- <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="*" ForeColor="Red" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
        </td>
        <td colspan="2">
            <asp:RadioButtonList ID="rbtGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="rbtGender"></asp:RequiredFieldValidator>
            <%-- <asp:RadioButton ID="rbtMale" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="rbtFemale" runat="server" GroupName="gender" Text="Female" />--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMaritalStatus" runat="server" Text="Marital Status"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="ddlMaritalStatus" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Married</asp:ListItem>
                <asp:ListItem>Single</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvMaritalStatus" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="ddlMaritalStatus"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPassport" runat="server" Text="Passport Issued "></asp:Label>
        </td>
        <td colspan="2">
            <asp:UpdatePanel ID="pnlPassport" runat="server">
                <ContentTemplate>
                    <%--<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal"  ValidationGroup="RadioButtonList1">
                            <asp:ListItem Value="Yes">Yes</asp:ListItem>
                            <asp:ListItem Value="No">No</asp:ListItem>
                        </asp:RadioButtonList>--%>
                    <asp:RadioButton ID="rbtPassportYes" runat="server" AutoPostBack="true" OnCheckedChanged="rbtPassportYes_CheckedChanged" Text="Yes" ValidationGroup="Passport" GroupName="Passport" />
                    <asp:RadioButton ID="rbtPassportNo" runat="server" AutoPostBack="true" OnCheckedChanged="rbtPassportNo_CheckedChanged" Text="No" ValidationGroup="Passport" GroupName="Passport" />

                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="lblpass" runat="server" Text="Passport Number" Visible="false"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassportNo" runat="server" Visible="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblPassportValidity" runat="server" Text="Validity" Visible="false"></asp:Label>
                            </td>
                            <td>
                                <%--<asp:TextBox ID="txtValidity" runat="server" Visible="false"></asp:TextBox>
                                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtValidity" PopupButtonID="txtValidity" Format="yyyy/MM/dd" />--%>
                                <asp:DropDownList ID="ddlMonth" runat="server" Visible="false">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlYear" runat="server" Visible="false">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>

    <tr>
        <td>&nbsp;</td>
        <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>