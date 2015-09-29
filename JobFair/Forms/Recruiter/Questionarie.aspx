<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="Questionarie.aspx.cs" Inherits="JobFair.Forms.Recruiter.CreateQuestionary" %>
<%@ Register src="../../UserControls/Recruiter/ClientDetails.ascx" tagname="ClientDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <table style="height: 159px; width: 240px">
         <tr>
         <td class="auto-style1">
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
     <td class="auto-style1">
      Enter Question: 
     </td>
     <td>
       <asp:TextBox ID="txtquestion" runat="server" Height="16px" Width="462px"></asp:TextBox>
         <br />
         <br />
     </td> 
 </tr>
      <tr>
     <td class="auto-style1">
      Enter Answer: 
     </td>
     <td>
       <asp:TextBox ID="txtanswer" runat="server" Width="453px"></asp:TextBox>
     </td> 
 </tr> 
         <tr>
     <td class="auto-style1">
         <asp:Button ID="btnsave" runat="server" Text="Save" />
     </td>
 </tr>        
</table>
        
    
</asp:Content>
