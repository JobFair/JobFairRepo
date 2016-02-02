<%@ Page Language="C#" AutoEventWireup="true" CodeBehind ="Questionnarie.aspx.cs" Inherits="JobFair.Forms.Recruiter.Questionrie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
   
</head>
<body>
    <form id="form1" runat="server">
        
        <table>
            <tr>
                <td><h3>Create Questionnaire</h3></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td >Questionnaire Name</td>
                <td>
                    <asp:TextBox ID="txtQuestionnarieName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td ><h3>Questions</h3></td>
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
                    <asp:DropDownList ID="ddlQuestionType" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>TextBox</asp:ListItem>
                        <asp:ListItem>ListMenu</asp:ListItem>
                        <asp:ListItem>RadioButton</asp:ListItem>
                        <asp:ListItem>CheckBox</asp:ListItem>
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
                        <asp:BoundField Visible="false" HeaderText="RecruiterId" DataField="RecruiterId" />
                        <asp:BoundField HeaderStyle-Width="120px" HeaderText="Questionnaire Id" DataField="QuestionnaireId" Visible="false" />
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
    </form>
  
</body>
</html>
