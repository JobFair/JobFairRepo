<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchFormBasic.ascx.cs" Inherits="JobFair.Forms.Employeer.SearchFormBasic" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link href="../../Style.css" rel="stylesheet" />

<style type="text/css">
    .auto-style1 {
        width: 197px;
    }
</style>

<asp:Panel ID="Panel1" runat="server" Height="220px" Width="832px">
    <table >
        <tr>
            <td colspan="2"><strong><h1>Basic Details</h1></strong></td>
            
        </tr>
        <tr>
            <td >Any Of The Keywords</td>
            <td >
                <asp:TextBox ID="txtKey" runat="server" OnTextChanged="txtKey_TextChanged"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="txtKey_TextBoxWatermarkExtender" runat="server" BehaviorID="txtKey_TextBoxWatermarkExtender" TargetControlID="txtKey" WatermarkText="Enter searching keywords here...." />
            </td>
        </tr>
        <tr>
            <td >All The Keywords</td>
            <td >
                <asp:TextBox ID="txtAllKey" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Excluding Keywods</td>
            <td >
                <asp:TextBox ID="txtExcludeKey" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Search In</td>
            <td >
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                </asp:RadioButtonList>
            </td>
        </tr>
    </table>
</asp:Panel>

