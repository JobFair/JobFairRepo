<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Search" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <table >
                <tr>
                    <td><h3>Search Job</h3></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKeywords" runat="server" placeholder="Skills"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtKeywords" MinimumPrefixLength="1"
                            EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetKeywords" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLocation" runat="server" placeholder="Location"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtLocation" MinimumPrefixLength="1"
                            EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCity" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlExperience" runat="server">
                            <asp:ListItem>Experience</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSalary" runat="server">
                            <asp:ListItem>Salary</asp:ListItem>
                            <asp:ListItem>50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnSearchJob" runat="server" Text="Search Job" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>