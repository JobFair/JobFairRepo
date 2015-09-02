<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.PersonalDetails" %>
<link href="../../Style.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table >
        <tr>
            <td >&nbsp;</td>
            <td colspan="10">
                <h1>Personal Details</h1>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="lblPhoto" runat="server" Text="Photo"></asp:Label>
            </td>
            <td colspan="10">
                <asp:FileUpload ID="FileUploadPhoto" runat="server" />
            </td>
        </tr>
        <tr>
            <td  rowspan="6">
                <asp:Label ID="lblPresentAdd" runat="server" Text="Present Address"></asp:Label>
            </td>
            <td  colspan="5">
                <asp:Label ID="Label10" runat="server" Text="Address"></asp:Label>
            </td>
            <td  colspan="5">
                <asp:TextBox ID="txtPresentAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  colspan="5">
                Country</td>

            <td  colspan="5" rowspan="3">
                <asp:UpdatePanel ID="pnlPresentAddress" runat="server">
                    <ContentTemplate>
                         <asp:DropDownList ID="ddlCountryPresent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPresent_SelectedIndexChanged">
                </asp:DropDownList><br />
                <asp:DropDownList ID="ddlStatePresent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStatePresent_SelectedIndexChanged">
                </asp:DropDownList><br />
                <asp:DropDownList ID="ddlCityPresent" runat="server">
                </asp:DropDownList>

                        </ContentTemplate>
                    </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td  colspan="5">
                <asp:Label ID="Label11" runat="server" Text="State"></asp:Label>
            </td>

        </tr>
        <tr>
            <td  colspan="5">
                <asp:Label ID="Label12" runat="server" Text="City"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  colspan="5">
                Area</td>
            <td  colspan="5">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  colspan="5">
                <asp:Label ID="Label13" runat="server" Text="Pincode"></asp:Label>
            </td>
            <td  colspan="5">
                <asp:TextBox ID="txtPincodePresent" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  rowspan="6">
                <asp:Label ID="Label3" runat="server" Text="Permanent Adrress"></asp:Label>
            </td>
            <td colspan="5">
                <asp:Label ID="Label14" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="auto-style6" colspan="5">
                <asp:TextBox ID="txtAddressPerm" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                Country</td>
            <td class="auto-style6" colspan="5" rowspan="3">
                <asp:UpdatePanel ID="pnlPermanentAddress" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlCountryPerm" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPerm_SelectedIndexChanged"></asp:DropDownList><br />
                <asp:DropDownList ID="ddlStatePerm" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatePerm_SelectedIndexChanged">
                </asp:DropDownList><br />
                <asp:DropDownList ID="ddlCityPerm" runat="server">
                </asp:DropDownList></ContentTemplate>
                    </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td  colspan="5">
                <asp:Label ID="Label15" runat="server" Text="State"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="Label16" runat="server" Text="City"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                Area</td>
            <td class="auto-style6" colspan="5">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="Label17" runat="server" Text="Pincode"></asp:Label>
            </td>
            <td class="auto-style6" colspan="5">
                <asp:TextBox ID="txtPincodePerm" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label4" runat="server" Text="Date of Birth"></asp:Label>
            </td>
            <td colspan="10">
                <asp:TextBox ID="txtDOB" runat="server" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
            </td>
            <td colspan="10">
                <asp:RadioButtonList ID="rdoblGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label6" runat="server" Text="Marital Status"></asp:Label>
            </td>
            <td colspan="10">
                <asp:DropDownList ID="ddlMaritalStatus" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                    <asp:ListItem>Unmarried</asp:ListItem>
                    <asp:ListItem>Widow</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label7" runat="server" Text="Passport Issued "></asp:Label>
            </td>
            <td colspan="10">
                <asp:UpdatePanel ID="pnlPassport" runat="server">
                    <ContentTemplate>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:RadioButtonList>
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
                                    <asp:TextBox ID="txtValidity" runat="server" Visible="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td  rowspan="4">
                <asp:Label ID="Label8" runat="server" Text="Languages Known "></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label18" runat="server" Text="Languages"></asp:Label>
            </td>
            <td colspan="2" >
                <asp:Label ID="Label19" runat="server" Text="Proficiency"></asp:Label>
            </td>
            <td colspan="4" >
                <asp:Label ID="Label20" runat="server" Text="Speak"></asp:Label>
            </td>
            <td colspan="2" >
                <asp:Label ID="Label21" runat="server" Text="Read"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label22" runat="server" Text="Write"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2"">
                <asp:TextBox ID="txtLanguage1" runat="server"></asp:TextBox>
            </td>
            <td colspan="2" >
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Beginner</asp:ListItem>
                    <asp:ListItem>Intermediate</asp:ListItem>
                    <asp:ListItem>Expert</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox4" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox7" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" >
                <asp:TextBox ID="txtLanguage2" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Beginner</asp:ListItem>
                    <asp:ListItem>Intermediate</asp:ListItem>
                    <asp:ListItem>Expert</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox2" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox5" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox8" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style8">
                <asp:TextBox ID="Language3" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>Beginner</asp:ListItem>
                    <asp:ListItem>Intermediate</asp:ListItem>
                    <asp:ListItem>Expert</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox3" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox6" runat="server" />
            </td>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox9" runat="server" />
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label9" runat="server" Text="Update Work Status "></asp:Label>
            </td>
            <td colspan="10">
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Working</asp:ListItem>
                    <asp:ListItem>On Notice Period</asp:ListItem>
                    <asp:ListItem>Fresher</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td colspan="10">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
