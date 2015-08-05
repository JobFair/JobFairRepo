<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PersonalDetails.ascx.cs" Inherits="JobSeeker_Forms_PersonalDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 119px;
    }
    .auto-style3 {
        width: 119px;
        height: 23px;
    }
    .auto-style4 {
        height: 23px;
    }
    .auto-style5 {
        height: 23px;
        width: 102px;
    }
    .auto-style6 {
        width: 102px;
    }
    .auto-style8 {
        width: 28px;
    }
    </style>
<p>
    <br />
</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblPhoto" runat="server" Text="Photo"></asp:Label>
        </td>
        <td colspan="10">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3" rowspan="4">
            <asp:Label ID="lblPresentAdd" runat="server" Text="Present Address"></asp:Label>
        </td>
        <td class="auto-style4" colspan="5">
            <asp:Label ID="Label10" runat="server" Text="Address"></asp:Label>
        </td>
        <td class="auto-style5" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
            <asp:Label ID="Label11" runat="server" Text="State"></asp:Label>
        </td>
        <td class="auto-style5" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
            <asp:Label ID="Label12" runat="server" Text="City"></asp:Label>
        </td>
        <td class="auto-style5" colspan="5"></td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
            <asp:Label ID="Label13" runat="server" Text="Pincode"></asp:Label>
        </td>
        <td class="auto-style5" colspan="5"></td>
    </tr>
    <tr>
        <td class="auto-style2" rowspan="4">
            <asp:Label ID="Label3" runat="server" Text="Permanent Adrress"></asp:Label>
        </td>
        <td colspan="5">
            <asp:Label ID="Label14" runat="server" Text="Address"></asp:Label>
        </td>
        <td class="auto-style6" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
            <asp:Label ID="Label15" runat="server" Text="State"></asp:Label>
        </td>
        <td class="auto-style5" colspan="5"></td>
    </tr>
    <tr>
        <td colspan="5">
            <asp:Label ID="Label16" runat="server" Text="City"></asp:Label>
        </td>
        <td class="auto-style6" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="5">
            <asp:Label ID="Label17" runat="server" Text="Pincode"></asp:Label>
        </td>
        <td class="auto-style6" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Date of Birth"></asp:Label>
        </td>
        <td colspan="10">
                            <asp:TextBox ID="txtDOB" runat="server" Visible="false"></asp:TextBox>
                        <asp:ImageButton ID="ImgbtnCalender" runat="server" Height="26px" ImageUrl="~/Images/calendar-list.jpg" style="margin-left: 23px" Width="44px" />
       <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDOB" PopupButtonID="ImgbtnCalender" PopupPosition="BottomLeft"  /> </td>
    </tr>
    
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
        </td>
        <td colspan="10">
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Marital Status"></asp:Label>
        </td>
        <td colspan="10">
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label7" runat="server" Text="Passport Issued "></asp:Label>
        </td>
        <td colspan="10"><asp:UpdatePanel ID="pnlPassport" runat="server">
            <ContentTemplate>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
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

                        </asp:UpdatePanel></td>
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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td colspan="2" >
            <asp:DropDownList ID="DropDownList1" runat="server">
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
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList2" runat="server">
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
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList3" runat="server">
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
        <td class="auto-style2">
            <asp:Label ID="Label9" runat="server" Text="Update Work Status "></asp:Label>
        </td>
        <td colspan="10">
            <asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
</table>

