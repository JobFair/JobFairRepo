<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchrecord.aspx.cs" Inherits="JobFair.Forms.Recruiter.searchrecord" %>

<!DOCTYPE html>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
  
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
        -------------------------------------------------------------------------------------------------------------
        <div>

            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                    <asp:Label ID="lblemploymentdetails" runat="server" style="font-weight: 700" Text="EmploymentDetails"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfunctionalarea" runat="server" Text="FunctionalArea"></asp:Label>
                    </td>
                    <td>
                  
                    &nbsp;<asp:DropDownCheckBoxes ID="ddlfunctionalarea" runat ="server" OnSelectedIndexChanged="ddlfunctionalarea_SelectedIndexChanged"> 
                        <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" /> </asp:DropDownCheckBoxes>
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblindystrytype" runat="server" Text="Industry Type"></asp:Label>
                    </td>
                 
                    <td>
                  
                   <asp:DropDownCheckBoxes ID="ddlindustrytype" runat="server" OnSelectedIndexChanged="ddlindustrytype_SelectedIndexChanged">
                        <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                   </asp:DropDownCheckBoxes>
                    &nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblemployers" runat="server" Text="Employers"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemployers" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlemployer" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlallwords" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblexcludeemployers" runat="server" Text="Exclude Employers"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtexcludeemployers" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlemployer0" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlallwords0" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbldesignation" runat="server" Text="Designatin"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddldesignation" runat="server">
                            <asp:ListItem>current Designation</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlallwords1" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        ----------------------------------------------------------------------------------------------------------------------------------------------
         <div>

        
             <table class="auto-style2">
                 <tr>
                     <td>
                         <asp:Label ID="lbleducationaldetails" runat="server" Text="Educational Details"></asp:Label></td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td><asp:Label ID="lblselecteducationaldetails" runat="server" Text="UGQualification"></asp:Label></td>
                     <td><asp:DropDownCheckBoxes ID="ddlugqualification" runat ="server" style="top: 0px; left: 1px">
                         <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" /></asp:DropDownCheckBoxes></td>
                 </tr>
                 <tr>
                     <td class="auto-style3"><asp:Label ID="lblinstitutename" runat="server" Text="InstituteName"></asp:Label></td>
                     <td class="auto-style3">
                         <asp:TextBox ID="txtInstitutename" runat="server"></asp:TextBox>
&nbsp;
                        <asp:DropDownList ID="ddlallwords2" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3"><asp:Label ID="lblYearOfpassing" runat="server" Text="YearOfPassing"></asp:Label>&nbsp;</td>
              
                    <td>Between
                        <asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate"></cc1:CalendarExtender>
                        <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="From Year" TargetControlID="txtFromdate" WatermarkCssClass="c" />
                        &nbsp;To
                        <asp:TextBox ID="txtTill" runat="server" Height="16px" Width="100px"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill"></cc1:CalendarExtender>
                        <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" WatermarkText="To Year" TargetControlID="txtTill" WatermarkCssClass="c" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>
              
                    <td>
                        <asp:RadioButton ID="rdbAnd" runat="server" Text="And" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbor" runat="server" Text="OR" />
                        </td>
                 </tr>
                 <tr>
                     <td class="auto-style3"><asp:Label ID="lblPGeducationaldetails" runat="server" Text="PGQualification"></asp:Label></td>
              
                    <td><asp:DropDownCheckBoxes ID="ddlpgqualification" runat ="server" style="top: 0px; left: 1px">
                         <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" /></asp:DropDownCheckBoxes></td>
                 </tr>
             </table>

        
        </div>
    </form>
</body>
</html>
