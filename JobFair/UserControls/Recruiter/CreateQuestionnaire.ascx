<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateQuestionnaire.ascx.cs" Inherits="JobFair.Forms.Recruiter.createQuestionnaire" %>
<style type="text/css">
    
    .auto-style2 {
        width: 136px;
    }
    
</style>
<link href="../../Style.css" rel="stylesheet" type="text/css" />

<table>
    <tr>
        <td colspan="2"><h1>Question 1</h1></td>
        
    </tr>
    <tr>
        <td class="auto-style2">Enter Question</td>
        <td>
            <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
        </td>
        
    </tr>
    <tr>
        <td class="auto-style2">
            Choose Question Type</td>
        <td>
            <asp:DropDownList ID="ddlQuestionType" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>TextBox</asp:ListItem>
                <asp:ListItem>ListMenu</asp:ListItem>
                <asp:ListItem>RadioButton </asp:ListItem>
                <asp:ListItem>CheckBox</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Answer Options</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

