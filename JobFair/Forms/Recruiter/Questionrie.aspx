<%@ Page Language="C#" AutoEventWireup="true" CodeBehind ="Questionrie.aspx.cs" Inherits="JobFair.Forms.Recruiter.Questionrie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #question {
            width: 240px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                   <div "height: 630px; margin-bottom: 0px">
                <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblque" runat="server" Text="Enter Question"></asp:Label></td>
                <td><div id="DivQuestion">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"/>
                    <asp:TextBox ID="txtquestion" runat="server" Enabled="False" Visible="False"></asp:TextBox>
                    </div></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblanswer" runat="server" Text="Enter Answer"></asp:Label>
                </td>
                 <td><div id="DivAnswer">
                    <asp:Button ID="btnAddAnswer" runat="server" Text="AddAnswer" OnClick="btnAddAnswer_Click"/>
                    <asp:TextBox ID="txtanswer" runat="server" Enabled="False" Visible="False"></asp:TextBox>
                    </div></td>
            </tr>
                    <tr>
                     <td>
                    <asp:Label ID="lbllquestiontype" runat="server" Text="Choose Question Type"></asp:Label>
                </td>
                     <td><div id="DivQuestionType">
                  <%--  <asp:Button ID="btnquestiontype" runat="server" Text="AddQuestionType">--%>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                         <asp:DropDownList ID="ddlquestiontype" runat="server" OnSelectedIndexChanged="ddlquestiontype_SelectedIndexChanged" AutoPostBack="True">
                             <asp:ListItem Value="0">select </asp:ListItem>
                             <asp:ListItem Value="1"> TextBox</asp:ListItem>
                               <asp:ListItem Value ="2">CheckBoxList</asp:ListItem>
                               <asp:ListItem  Value="3">RedioButtonList</asp:ListItem>
                         </asp:DropDownList>
                    </div>

                     </td>
            </tr>
        </table>
       
    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBoxList ID="CheckBoxList1" runat="server" Visible="False">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:CheckBoxList>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="False">
                       <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                    <br />
                    <br />
                    <asp:Label ID="lblselctquestionrie" runat="server" Text="Select Questionrie"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlQuestionary" runat="server">
                    </asp:DropDownList>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </form>
</body>
</html>
