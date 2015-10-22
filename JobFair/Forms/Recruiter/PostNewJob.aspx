<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
  
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td>
                        <h1>Post New Job</h1>
                    </td>
                </tr>
                <tr>
                    <td>Job Title/Designation</td>
                    <td>
                        <asp:TextBox ID="txtJobtitle" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                

                   <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td rowspan="3">
                        <asp:UpdatePanel ID="pnlState" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownCheckBoxes ID="ddlLocation" runat="server" style="top: -50px; left: 0px">
                                    <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                                </asp:DropDownCheckBoxes>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Company Level</td>
                    <td>
                        <asp:DropDownList ID="ddlCompanyLevel" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Startup Company</asp:ListItem>
                            <asp:ListItem>Small Scale Company</asp:ListItem>
                            <asp:ListItem>Mid Level Company</asp:ListItem>
                            <asp:ListItem>MNC</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Industry</td>
                    <td>
                        <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:DropDownList ID="ddlDepartment" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Functional Area</td>
                    <td>
                        <asp:DropDownList ID="ddlFunArea" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Job Description</td>
                    <td>
                        <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Keywords/Skillsets Roles</td>
                    <td>
                        <asp:TextBox ID="txtKeyRoles" runat="server" Height="26px" Width="344px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Keywords/Skillsets Technical</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px" Width="285px" style="margin-right: 3px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Work Experience</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlworkexprience" runat="server" Height="16px" Width="79px">
                            <asp:ListItem>0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                             <asp:ListItem> 2</asp:ListItem>
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
                        </asp:DropDownList>
                    &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
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
                    <td>Offered Anual Salary</td>
                    <td>&nbsp;&nbsp;<asp:DropDownList ID="ddlsalarymin" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>50,000</asp:ListItem>
                        <asp:ListItem>1,00,000</asp:ListItem>
                        <asp:ListItem>1,50,000</asp:ListItem>
                        <asp:ListItem>2,00,000</asp:ListItem>
                        <asp:ListItem>2,50,000</asp:ListItem>
                        <asp:ListItem>3,00,00</asp:ListItem>
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
                        <asp:ListItem>10,00,000</asp:ListItem>
                    </asp:DropDownList>
                        &nbsp;<asp:Label ID="lblmin" runat="server" Text="Min"></asp:Label>
                        &nbsp;&nbsp;
                <asp:DropDownList ID="ddlsalarymax" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                         <asp:ListItem>50,000</asp:ListItem>
                        <asp:ListItem>1,00,000</asp:ListItem>
                        <asp:ListItem>1,50,000</asp:ListItem>
                        <asp:ListItem>2,00,000</asp:ListItem>
                        <asp:ListItem>2,50,000</asp:ListItem>
                        <asp:ListItem>3,00,00</asp:ListItem>
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
                        <asp:ListItem>10,00,000</asp:ListItem>
                </asp:DropDownList>
                        &nbsp;
                <asp:Label ID="lblmin0" runat="server" Text="Max"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;OtherSalaryDetails</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtsalarydetaills" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Number of Vacancies</td>
                    <td>
                        <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Posted Date</td>
                    <td>
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server"  TargetControlID="txtdate" Format="d MM, yy" />
                    </td>
                </tr>
              
                   <h2>Recruiter Type</h2>
           
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="Recruitment Type"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server"  OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="true">
                               <asp:ListItem id="rdb1" runat="server" Text="In-House" Selected="True"></asp:ListItem>
                                <asp:ListItem id="rdb2" runat="server" Text="Client"></asp:ListItem>
                            </asp:RadioButtonList>
                          </td>
                        </tr>
                 <tr>
                        <td>
                              &nbsp;</td>
                        <td style="margin-left: 200px">
                            <asp:TextBox ID="txtaboutcompany" runat="server" Width="506px"  Visible="false" TextMode="MultiLine" Height="183px" Text="Logos Solutions is one of the conglomerate companies in India.

        Logos Corporate Solutions is the leading Recruitment and Placement Solution for IT -Non IT Companies.

        Logos iTech Software Solutions is the IT Outsourcing Company specialized in Mobile Application Development, Publishing, Website Design, E-commerce Solutions and Product Development
     

 ">              Logos Solutions is one of the conglomerate companies in India.

                  Logos Corporate Solutions is the leading Recruitment and Placement Solution for IT -Non IT Companies.

                  Logos iTech Software Solutions is the IT Outsourcing Company specialized in Mobile Application Development, Publishing, Website Design, E-commerce Solutions and Product Development
     

 </asp:TextBox>
                        </td>
                     
                        <td>
                            <asp:TextBox ID="txtclient" runat="server" Visible="false"> </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                              <asp:Label ID="lblcompanyclient" runat="server" Text="Company Name"></asp:Label>
                        </td>
                        <td class="auto-style2">
                         
                            <asp:Label ID="lblcompanyname1" runat="server" Text="Logos Itech Solutions Pvt.Ltd" Visible="False" ></asp:Label>
                         
                            <br />
                         
                            <br />
                            <br />
                          <asp:Label ID="lblclientoflogossolutios" Text="Client Of Logos Solutions" runat="server"></asp:Label>
                         
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
                        <td colspan="2">
                            <asp:Label ID="lblSSCTag" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblSSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table style="width: 358px">
                    <asp:Label ID="lblHSCHead" runat="server" Text="Specify HSC / 12th Qualification"></asp:Label>
                    <tr>

                        <td colspan="2">
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
                            <asp:Label ID="lblHSCSelect" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbHSC" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblHSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblUGDHead" runat="server" Text="Specify UG Diploma Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlUGDiploma" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblUGDSelect" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbUGD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblUGDTag" runat="server">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblUGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblBDHead" runat="server" Text="Specify Bachelors Degree Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlBachelorsDegree" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblBDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbBD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblBDTag" runat="server" CssClass="label">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblBD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblPGDHead" runat="server" Text="Specify PG Deploma Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlPGDiploma" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPGDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPGD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblPGDTag" runat="server">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblPGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblMDHead" runat="server" Text="Specify Master Degree Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlMasterDegree" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbMD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMDTag" runat="server" CssClass="label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblMD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblPHDHead" runat="server" Text="Specify Doctorate / PHD Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlPHD" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPHDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPHD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblPHDTag" runat="server" CssClass="label">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblPHDHead" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <h2> Select Questionrie</h2>
                <table>
               <tr>
                   <td>
                       <asp:Label ID="lblselectquestionrie" runat="server" Text="SelectQuestionrie"></asp:Label>
                       </td>
                   <td>
                        <asp:DropDownList ID="ddlQuestionary" runat="server"></asp:DropDownList>
                   </td>
                   </tr>
                 </table>
            </div>
            
    </form>
</body>
</html>