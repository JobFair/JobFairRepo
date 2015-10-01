<%@ Page Language="C#" AutoEventWireup="true" CodeBehind ="Questionrie.aspx.cs" Inherits="JobFair.Forms.Recruiter.Questionrie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 630px; margin-bottom: 0px">
        <asp:Wizard ID="Wizard1" runat="server" style="margin-right: 482px" Width="564px" ActiveStepIndex="1" OnNextButtonClick="Wizard1_NextButtonClick">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                    <br />
                    <asp:Label ID="lblquestion" runat="server" Text="Enter Question"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtquestion" runat="server" Width="306px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Choose Your Question Type"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:DropDownList ID="ddlquestiontype" runat="server" style="height: 22px">
                        <asp:ListItem> TextBox </asp:ListItem>
                           <asp:ListItem> RediobButtonList </asp:ListItem>
                           <asp:ListItem> CheckBoxList </asp:ListItem>
                                 <asp:ListItem> ListMenu </asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                    <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem> Yes</asp:ListItem>
                         <asp:ListItem>No</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <br />
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
