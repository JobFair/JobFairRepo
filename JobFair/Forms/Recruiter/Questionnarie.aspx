<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questionnarie.aspx.cs" Inherits="JobFair.Forms.Recruiter.Questionrie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Panel ID="pnlQuestionnarie" runat="server" Visible="true">
                <table>
                    <tr>
                        <td>
                            <h3>Create Questionnaire</h3>
                        </td>
                    </tr>
                    <tr>
                        <td>Questionnarie Name
                        </td>
                        <td>
                            <asp:TextBox ID="txtQuestionnarieName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAddQuestionnarie" runat="server" Text="Add Questionnarie" OnClick="btnAddQuestionnarie_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <asp:Panel ID="pnlQuestion" runat="server" Visible="false">
        <table>
            <tr>
                <td>
                    <h3>Questions</h3>
                </td>
            </tr>
            <tr>
                <td>Enter Question</td>
                <td>
                    <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Choose Question Type</td>
                <td>
                    <asp:DropDownList ID="ddlQuestionType" runat="server" OnSelectedIndexChanged="ddlQuestionType_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem Value="TextBox">TextBox</asp:ListItem>
                        <asp:ListItem Value="ListMenu">List Menu</asp:ListItem>
                        <asp:ListItem Value="RadioButton">Radio Button</asp:ListItem>
                        <asp:ListItem Value="CheckBox">Check Box</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Answer Options</td>
                <td>
                    <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAddQuestion" runat="server" Text="Add More Questions" OnClick="btnAddQuestion_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
       
        <div style="margin-top: 20px; margin-left: 10px;">
            <asp:HiddenField ID="hfCandidateId" runat="server" />
            <asp:GridView ID="grdQuestionnarie" AutoGenerateColumns="false" runat="server" ForeColor="#333333"
                GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <%--  <asp:BoundField Visible="false" HeaderText="RecruiterId" DataField="RecruiterId" />
                        <asp:BoundField HeaderStyle-Width="120px" HeaderText="Questionnaire Id" DataField="QuestionnaireId" Visible="false" />--%>
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Question Name" DataField="QuestionName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Question Type" DataField="QuestionType" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Answer Option" DataField="AnswerOption" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </asp:Panel> 
    </form>
</body>
</html>