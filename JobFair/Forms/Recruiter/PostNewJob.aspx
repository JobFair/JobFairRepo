<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td class="auto-style1">
                        <h1>Post New Job</h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label runat="server" ID="lbltitle" Text="Job Title/Designation"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtJobtitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style1"> 
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                       <td>
                        <asp:UpdatePanel ID="pnlState" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                               
                            </ContentTemplate>
                        </asp:UpdatePanel>
                  </td>
                       </tr>
                <tr>
                     <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="phlstate" runat="server">
                            <ContentTemplate>
                              <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    </tr>
                <tr>
                  <td>
                     <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                    <td>
                       
                            <asp:DropDownList ID="ddllocation" runat="server" AutoPostBack="true"></asp:DropDownList>
                        
                         <asp:Label ID="lbllocation" runat="server"></asp:Label>
                        </td>
                </tr>
                    
                <tr>
                    <td><asp:Label ID="lblcompanyname" runat="server" Text="CompanyType"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlCompanytype" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Startup Company</asp:ListItem>
                            <asp:ListItem>Small Scale Company</asp:ListItem>
                            <asp:ListItem>Mid Level Company</asp:ListItem>
                            <asp:ListItem>MNC</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblindustry" runat="server" Text="Industry"> </asp:Label></td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbldepartment" runat="server" Text="Department"> </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlDepartment" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblfunctionalarea" runat="server" Text="Functional Area"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlFunArea" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbljobdescription" runat="server" Text="Job Description"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtJobDescription" runat="server" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblkeyroles" runat="server" Text="Keywords/Skillsets Roles"></asp:Label></td>
                    <td>
                      
                        <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtKeyRoles" MinimumPrefixLength="1"
                         EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetRoles"></cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblkeytechnical" runat="server" Text="Keywords/Skillsets Technical"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtKeyTechnical" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtKeyTechnical" MinimumPrefixLength="1" EnableCaching="true"
                           CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="Gettechnicalskill" > </cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblworkexprience" runat="server" Text="Work Experience"></asp:Label></td>
                    <td>&nbsp;
                        <asp:DropDownList ID="ddlworkexprience" runat="server">
                        <asp:ListItem>0.5</asp:ListItem>
                                    <asp:ListItem>1.0</asp:ListItem>
                                    <asp:ListItem>1.5</asp:ListItem>
                                    <asp:ListItem>2.0</asp:ListItem>
                                    <asp:ListItem>2.5</asp:ListItem>
                                    <asp:ListItem>3.0</asp:ListItem>
                                    <asp:ListItem>3.5</asp:ListItem>
                                    <asp:ListItem>4.0</asp:ListItem>
                                    <asp:ListItem>4.5</asp:ListItem>
                                    <asp:ListItem>5.0</asp:ListItem>
                                    <asp:ListItem>5.5</asp:ListItem>
                                    <asp:ListItem>6.0</asp:ListItem>
                                    <asp:ListItem>6.5</asp:ListItem>
                                    <asp:ListItem>7.0</asp:ListItem>
                                    <asp:ListItem>7.5</asp:ListItem>
                                    <asp:ListItem>8.0</asp:ListItem>
                                    <asp:ListItem>8.5</asp:ListItem>
                                    <asp:ListItem>9.0</asp:ListItem>
                                    <asp:ListItem>9.5</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlgender" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Both [Male/Female]</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblofferedsalary" runat="server" Text="Offered Anual Salary"></asp:Label></td>
                    <td>&nbsp;<asp:DropDownList ID="ddlsalarymin" runat="server">
                                    <asp:ListItem>Min</asp:ListItem>
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
                <asp:DropDownList ID="ddlsalarymax" runat="server">
                            <asp:ListItem>Max</asp:ListItem>
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
                    <td><asp:Label ID="lblsalrydetails" runat="server" Text="OtherSalaryDetails"></asp:Label></td>
                    <td>
                <asp:TextBox ID="txtsalarydetaills" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> <asp:Label ID="lblvacancies" runat="server" Text="Number Of Vacancies"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbljobtype" Text="Job Type" runat="server"></asp:Label></td>
                    <td>
                        <asp:UpdatePanel ID="pnljobtype" runat="server">
                            <ContentTemplate>
                        <asp:CheckBoxList ID="chkjobtype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkjobtype_SelectedIndexChanged">
                            <asp:ListItem>Part Time</asp:ListItem>
                            <asp:ListItem>Full Time</asp:ListItem>
                        </asp:CheckBoxList>
                                 &nbsp;
                        <asp:Label ID="lblselectedjobtype" runat="server"></asp:Label>
                           </ContentTemplate>
                        </asp:UpdatePanel>
                       
                
                   
                       
                
                    </td>
                  
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblrecruitmenttype" Text ="Employment Status" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="pnlemploymenttype" runat="server">
                            <ContentTemplate>
                        <asp:CheckBoxList ID="chkemploymenttype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkemploymenttype_SelectedIndexChanged">
                            <asp:ListItem>Temporarily</asp:ListItem>
                            <asp:ListItem>Permanant</asp:ListItem>
                            <asp:ListItem>Freelancing</asp:ListItem>
                        </asp:CheckBoxList>
                        <asp:Label ID="lblemploymentstatus" runat="server"></asp:Label>
                           <br />
                    </td>
                     </ContentTemplate>
                    </asp:UpdatePanel>

                </tr>
              
                 
           
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Recruitment Type"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rdbrecruitmenttype" runat="server"  OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="true">
                               <asp:ListItem id="rdb1" runat="server" Text="In-House"></asp:ListItem>
                                <asp:ListItem id="rdb2" runat="server" Text="Client"></asp:ListItem>
                            </asp:RadioButtonList>
                          </td>
                        </tr>
                     <tr>
                        <td>
                            <asp:UpdatePanel ID="pnlaboutcompany" runat="server">
                            <ContentTemplate>
                            <asp:TextBox ID="txtaboutcompany" runat="server" Width="506px"  Visible="false" TextMode="MultiLine" Height="183px" Text="Logos Solutions is one of the conglomerate companies in India.

        Logos Corporate Solutions is the leading Recruitment and Placement Solution for IT -Non IT Companies.

        Logos iTech Software Solutions is the IT Outsourcing Company specialized in Mobile Application Development, Publishing, Website Design, E-commerce Solutions and Product Development
     

 ">              Logos Solutions is one of the conglomerate companies in India.

                  Logos Corporate Solutions is the leading Recruitment and Placement Solution for IT -Non IT Companies.

                  Logos iTech Software Solutions is the IT Outsourcing Company specialized in Mobile Application Development, Publishing, Website Design, E-commerce Solutions and Product Development
     </asp:TextBox>
                                  </ContentTemplate>
                                 </asp:UpdatePanel>

                        </td>
                    
                      
                    </tr>
                    <tr>
                        <td>
                              <asp:Label ID="lblcompanyclient" runat="server" Text="Company Name"></asp:Label>
                        </td>
                        <td>
                    <asp:UpdatePanel ID="pnlcompanyname" runat="server">
                       <ContentTemplate>
                                <asp:CheckBoxList ID="chkcompanyname" runat="server" Visible="False">
                                    <asp:ListItem>Logos Corporate Solutions</asp:ListItem>
                                    <asp:ListItem>Logos  Itech Solutions</asp:ListItem>
                                    <asp:ListItem>Client Of Logos Solutions</asp:ListItem>
                                </asp:CheckBoxList>
                                <br />
                           </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                      
              

                  <tr>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                    </td>
                    <td>
                        <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" Width="77px" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                </table>

        </div>
             
            <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">
                <h2>Desired Candidate Profile &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h2>

                <table>
                    <asp:Label ID="lblSSCHead" runat="server" Text="Specify SSC / 10th Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:Label ID="lblSSCTag" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblSSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <asp:UpdatePanel ID="updatepanel1" runat="server">
                    <ContentTemplate>
                <table style="width: 358px; height: 122px;">
                    <asp:Label ID="lblHSCHead" runat="server" Text="Specify HSC / 12th Qualification" Height="19px"></asp:Label>
                    <tr>

                        <td>
                            <asp:DropDownCheckBoxes ID="DropDownCheckBoxes1" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="DropDownCheckBoxes1_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                                <Items>
                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                    <asp:ListItem Value="1" Text="Arts"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Commerce"></asp:ListItem>
                                    <asp:ListItem Value="3" Text="Science"></asp:ListItem>
                                    <asp:ListItem Value="4" Text="Others"></asp:ListItem>
                                </Items>
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                          <td>
                            <asp:Panel ID="selectedItemspanel" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbHSC" runat="server" OnClick="lbHSC_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblHSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                <asp:UpdatePanel ID="updatepanel2" runat="server">
                    <ContentTemplate>
                <table>
                    <asp:Label ID="lblUGDHead" runat="server" Text="Specify UG Diploma Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlUGDiploma" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="ddlUGDiploma_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                          <td>
                            <asp:Panel ID="panel1" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbUGD" runat="server" OnClick="lbUGD_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblUGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                <asp:UpdatePanel ID="updatepanel3" runat="server">
                    <ContentTemplate>
                <table>
                    <asp:Label ID="lblBDHead" runat="server" Text="Specify Bachelors Degree Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlBachelorsDegree" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="ddlBachelorsDegree_SelectedIndexChanged" AutoPostBack="true" style="top: -1px; left: 2px">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="panel2" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbBD" runat="server" OnClick="lbBD_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblBDTag" runat="server" CssClass="label">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblBD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                <asp:UpdatePanel ID="updatepanel4" runat="server">
                    <ContentTemplate>
                <table>
                    <asp:Label ID="lblPGDHead" runat="server" Text="Specify PG Deploma Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlPGDiploma" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="ddlPGDiploma_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                           <td>
                            <asp:Panel ID="panel3" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPGD" runat="server" OnClick="lbPGD_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblPGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                <asp:UpdatePanel ID="updatepanel5" runat="server">
                    <ContentTemplate>
                <table>
                    <asp:Label ID="lblMDHead" runat="server" Text="Specify Master Degree Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlMasterDegree" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="ddlMasterDegree_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <asp:Panel ID="panel4" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbMD" runat="server" OnClick="lbMD_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblMD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                <asp:UpdatePanel ID="updatepanel6" runat="server">
                    <ContentTemplate>
                <table>
                    <asp:Label ID="lblPHDHead" runat="server" Text="Specify Doctorate / PHD Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlPHD" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="ddlPHD_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                          <asp:Panel ID="panel5" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPHD" runat="server" OnClick="lbPHD_Click">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rblPHDHead" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                          </ContentTemplate>
                    </asp:UpdatePanel>
                      
            </div>
            <div>
                <h2>Select Questionrie</h2>
                <table>
               <tr>
                   <td>
                       <asp:Label ID="lblselectquestionrie" runat="server" Text="SelectQuestionrie"></asp:Label>
                       </td>


                   <td>
                        <asp:DropDownList ID="ddlQuestionary" runat="server" style="margin-left: 47px"></asp:DropDownList>
                   </td>
                       </tr>
                 </table>
            </div>         
    </form>
</body>
</html>