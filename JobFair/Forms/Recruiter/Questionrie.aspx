<%@ Page Language="C#" AutoEventWireup="true" CodeBehind ="Questionrie.aspx.cs" Inherits="JobFair.Forms.Recruiter.Questionrie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 234px;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Create Questionnaire</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Questionnaire Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Questions</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Enter Question</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Choose Question Type</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>TextBox</asp:ListItem>
                        <asp:ListItem>ListMenu</asp:ListItem>
                        <asp:ListItem>RadioButton</asp:ListItem>
                        <asp:ListItem>CheckBox</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Answer Options</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </form>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
