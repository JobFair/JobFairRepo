<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<script  type="text/javascript" src="../../Scripts/ValidationAll.js"></script>

<!DOCTYPE html>
<link href="../../Css/Style.css" rel="stylesheet" />


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <%-- <style>
        .autocomplit_highlitedItem 
        {

            background-color:red;
            color:black;
            padding :1px;
            cursor: pointer;

        }
        .autocomplit_completionListelement {

            margin: 0px !important;
           background-color: inherit;
            color: windowtext;
           border: buttonshadow
          cursor: 'default';
          overflow: auto;
         height: 50px;
          text-align: left;
           list-style-type: none;
           padding-left: 1px;
        }



    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />

            <asp:Label ID="lbladvancesearch" runat="server" Text="AdvanceSearch"></asp:Label>

            &nbsp;
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblkeyskill" runat="server" Text="KeySkill" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtkeyskill" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtkeyskill" MinimumPrefixLength="1"
                         EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetRoles" DelimiterCharacters="," > 
                        </cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td rowspan="3">
                        <asp:UpdatePanel ID="pnlState" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" onblur="return IsSelectedDDL(this.id)" AutoPostBack="True">
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                </asp:DropDownList>
                                <br />
                                <br />
                              <div>
                                     
                                    <%--<asp:TextBox runat="server" ID="txtarea" ReadOnly="true"/>--%>
                                   <asp:TextBox ID="txtarea" runat="server" ReadOnly="true" TextMode="MultiLine"  Width="300px" ></asp:TextBox>
                                     <asp:Button runat="server" ID="btnarea" Text="Select Area" OnClick="btnarea_Click"/>
                                  <asp:Panel ID="Panelarea" runat="server" Visible="false">
                                      <asp:CheckBoxList ID="chkarea" runat="server" AutoPostBack="true" RepeatColumns="6" OnSelectedIndexChanged="chkarea_SelectedIndexChanged"></asp:CheckBoxList>
                                </asp:Panel>
                                  <cc1:CollapsiblePanelExtender ID="CPELocation" runat="server" TargetControlID="Panelarea" TextLabelID="btnarea" CollapseControlID="btnarea" ExpandControlID="btnarea" Collapsed="true" ScrollContents="true" ExpandedText="Hide" />
                              </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblworkexprience" runat="server" Text="Work Exprience"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:DropDownList ID="ddlWorkExperienceMin" runat="server">
                            <asp:ListItem Value="">Select</asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>2.5</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>3.5</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>4.5</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>5.5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>6.5</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>7.5</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>8.5</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>9.5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;To
                        <asp:DropDownList ID="ddlWorkExperienceMax" runat="server">
                            <asp:ListItem Value="">Select</asp:ListItem>
                             <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>2.5</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>3.5</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>4.5</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>5.5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>6.5</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>7.5</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>8.5</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>9.5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbsalary" runat="server" Text="Expected Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMinSalary" runat="server">
                            <asp:ListItem Value="">Min</asp:ListItem>
                            <asp:ListItem>50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>1,50,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>2,50,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>3,50,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>4,50,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>5,50,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>6,50,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>7,50,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>8,50,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                            <asp:ListItem>9,50,000</asp:ListItem>
                            <asp:ListItem>10,00,000</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;To
                        <asp:DropDownList ID="ddlMaxSalary" runat="server">
                            <asp:ListItem Value="">Max</asp:ListItem>
                            <asp:ListItem>&lt;50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>1,50,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>2,50,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>3,50,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>4,50,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>5,50,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>6,50,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>7,50,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>8,50,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                            <asp:ListItem>9,50,000</asp:ListItem>
                            <asp:ListItem>10,00,000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblindustry" runat="server" Text="Industry"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                        <div>
                            <asp:TextBox ID="txtindusry" runat="server" ReadOnly="True" TextMode="MultiLine"  Width="300px"></asp:TextBox>
                            <asp:Button ID="btnselect" runat="server" Text="Select" OnClick="btnselect_Click" />
                            <asp:Panel ID="panellindustry" runat="server" Visible ="false">
                                <asp:CheckBoxList ID="chkIndustry" runat="server" RepeatColumns="4" AutoPostBack="True" OnSelectedIndexChanged="chkIndustry_SelectedIndexChanged"></asp:CheckBoxList>
                            </asp:Panel>

                            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" TargetControlID="panellindustry" TextLabelID="btnselect" CollapseControlID="btnselect" ExpandControlID="btnselect" Collapsed="true" ScrollContents="true" ExpandedText="Hide" />
                        </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmploymentStatus" runat="server" Text="Employement Status"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="chkEmploymentStatus" runat="server">
                           
                                 <asp:ListItem Value="">Temporarily</asp:ListItem>
                            <asp:ListItem>Permanant</asp:ListItem>
                            <asp:ListItem>Freelancing</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblJobType" runat="server" Text="Job Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="chkJobType" runat="server">
                              <asp:ListItem Value="">Part Time</asp:ListItem>
                            <asp:ListItem>Full Time</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRecruitmentType" runat="server" Text="Recruitment Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="chkRecruitmentType" runat="server">
                            <asp:ListItem Value="">In-House</asp:ListItem>
                            <asp:ListItem Value="">Client</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="97px" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>