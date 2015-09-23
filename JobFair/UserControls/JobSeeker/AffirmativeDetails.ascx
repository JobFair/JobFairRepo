<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AffirmativeDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.AffirmativeDetails" %>
<table >
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
            <asp:RadioButton ID="rbtYes" runat="server" Text="Yes" GroupName="PhysicallyChallenged" AutoPostBack="true" />
            &nbsp;&nbsp;
                <asp:RadioButton ID="rbtNo" runat="server" Text="No" GroupName="PhysicallyChallenged" AutoPostBack="true" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDescription" runat="server" Text="Description" Visible="false"></asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Visible="false"></asp:TextBox>
        </td>
    </tr>
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
        <td>
            <asp:Label ID="lblUSAPermit" runat="server" Text="USAPermit"></asp:Label>
        </td>
        <td colspan="5">
            <asp:RadioButton ID="rbtYesUSA" runat="server" Text="Yes" GroupName="Permit" />
            &nbsp;&nbsp;
                <asp:RadioButton ID="rbtNOUSA" runat="server" Text="No" GroupName="Permit" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblOtherPermit" runat="server" Text="Other Permit"></asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtOtherPermit" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td colspan="5">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>