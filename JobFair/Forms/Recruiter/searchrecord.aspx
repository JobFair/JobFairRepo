<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchrecord.aspx.cs" Inherits="JobFair.Forms.Recruiter.searchrecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblbasicdetails" runat="server" style="font-weight: 700" Text="BasicDetails"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdbbooleansearch" runat="server" Text="BooleanSearch" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbkeywords" runat="server" Text="Keywords" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords" runat="server" Text="Any Of The KeyWords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtkeywords" runat="server" OnTextChanged="txtkeywords_TextChanged" AutoPostBack="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords1" runat="server" Text="All Of The KeyWords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtallkeywords" runat="server" OnTextChanged="txtallkeywords_TextChanged" AutoPostBack="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords2" runat="server" Text="Excluding Keywords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtexcludingkeywords" runat="server" Height="22px" AutoPostBack="True" OnTextChanged="txtexcludingkeywords_TextChanged"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:Button ID="btnsearch" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblsearch" runat="server" Text="Search In"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbresumetitle" runat="server" Text="ResumeTitle" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbkeyskills" runat="server" Text="Resume Title And KeySkill" />
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbsynopsis" runat="server" Text="Resume Synopsis" />
&nbsp;<asp:RadioButton ID="rdbentireresume" runat="server" Text="Entire Resume" />
                </td>
            </tr>
    <asp:GridView ID="GridView1" runat="server" >
    
    </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </table>
    
    </div>
    </form>
</body>
</html>
