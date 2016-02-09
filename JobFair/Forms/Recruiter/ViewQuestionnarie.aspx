<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewQuestionnarie.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewQuestionnarie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table border="1">
                <tr>
                    <td>
                        <%--<asp:Label ID="Label1" runat="server"></asp:Label>--%>
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
                        <asp:CheckBoxList
                            ID="CheckBoxList1"
                            runat="server">
                        </asp:CheckBoxList>
                        <asp:DropDownList ID="DropDownList1" runat="server" Visible="false"></asp:DropDownList>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                        <br />
                        <br />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>