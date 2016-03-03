<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AffirmativeDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.AffirmativeDetails" %>
<table>
    <tr>
        <td rowspan="4">
            <asp:Label ID="lblKnownLanguages" runat="server" Text="Languages Known"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblLanguages" runat="server" Text="Languages"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblProficincy" runat="server" Text="Proficiency"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblRead" runat="server" Text="Read"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblWrite" runat="server" Text="Write"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblSpeak" runat="server" Text="Speak"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="ddlLanguageFirst" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="ddlProficiencyFirst" runat="server">
                <asp:ListItem>Beginner</asp:ListItem>
                <asp:ListItem>Intermediate</asp:ListItem>
                <asp:ListItem>Expert</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:CheckBox ID="chkReadFirst" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkWriteFirst" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkSpeakFirst" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="ddlLanguageSecond" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="ddlProficiencySecond" runat="server">
                <asp:ListItem>Beginner</asp:ListItem>
                <asp:ListItem>Intermediate</asp:ListItem>
                <asp:ListItem>Expert</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:CheckBox ID="chkReadSecond" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkWriteSecond" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkSpeakSecond" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="ddlLanguageThird" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="ddlProficiencyThird" runat="server">
                <asp:ListItem>Beginner</asp:ListItem>
                <asp:ListItem>Intermediate</asp:ListItem>
                <asp:ListItem>Expert</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:CheckBox ID="chkReadThird" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkWriteThird" runat="server" />
        </td>
        <td>
            <asp:CheckBox ID="chkSpeakThird" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPhysicallyChallenged" runat="server" Text="Physically Challenged"></asp:Label>
        </td>
        <td colspan="5">
            <asp:RadioButtonList ID="rbtPhysicallyChallenged" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rbtPhysicallyChallenged_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <asp:Panel ID="pnlPhysicallyChallenged" runat="server" Visible="false">
        <tr>
            <td>

                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
    </asp:Panel>

    <tr>
        <td>
            <asp:Label ID="lblSports" runat="server" Text="Sports"></asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtSports" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSportsDescription" runat="server" Text="Description"></asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtSportsDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Hobbies</td>
        <td colspan="5">
            <asp:TextBox ID="txtHobbies" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Extra Curricular Activity</td>
        <td colspan="5">
            <asp:TextBox ID="txtExtraActivity" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUSAPermit" runat="server" Text=" Permit For USA"></asp:Label>
        </td>
        <td colspan="5">
            <asp:RadioButtonList ID="rbtUSAPermit" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <%--<asp:RadioButton ID="rbtYesUSA" runat="server" Text="Yes" GroupName="Permit" />
            &nbsp;&nbsp;
                <asp:RadioButton ID="rbtNoUSA" runat="server" Text="No" GroupName="Permit" />--%>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblOtherPermit" runat="server" Text="Other Permit"></asp:Label>
        </td>
        <td colspan="5">
            <asp:DropDownList ID="ddlOtherPermit" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td colspan="5">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>