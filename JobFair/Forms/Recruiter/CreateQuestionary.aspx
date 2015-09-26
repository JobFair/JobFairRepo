<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="CreateQuestionary.aspx.cs" Inherits="JobFair.Forms.Recruiter.CreateQuestionary" %>
<%@ Register src="../../UserControls/Recruiter/ClientDetails.ascx" tagname="ClientDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Height="159px" Width="603px" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnFinishButtonClick="Wizard1_FinishButtonClick">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
               <table>
         <tr>
         <td>
      Enter Oestion Type: 
     </td>
     <td>
       <asp:DropDownList ID="ddlquestion" runat="server">
        <asp:ListItem>TextBox</asp:ListItem>
        <asp:ListItem>RadioButton</asp:ListItem>
        <asp:ListItem>LixtBox</asp:ListItem>
        <asp:ListItem>CheckBox</asp:ListItem>
       </asp:DropDownList>
     </td>
 </tr>
 <tr>
     <td>
      Enter Question: 
     </td>
     <td>
       <asp:TextBox ID="txtanswer" runat="server"></asp:TextBox>
     </td>
 </tr>        
</table>
                &nbsp;
                <asp:TextBox ID="txtque" runat="server" Height="16px" Width="274px"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                &nbsp;&nbsp;
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
    
</asp:Content>
