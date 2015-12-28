<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="SearchRecord.aspx.cs" Inherits="JobFair.Forms.Recruiter.searchrecord" %>

<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 209px;
        }
    .auto-style3 {
        width: 404px;
    }
    </style>
   
</head>

<body>
    <form id="form1" runat="server">
        <div id="divMain" runat="server">
            <div id="divClient" runat="server">
                <table>
                    <tr>
                        <td>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Client Name</td>
                        <td><asp:DropDownList ID="ddlClientName" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td>
                            Position
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPosition" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Requirement ID
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRequirementID" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                </table>

            </div>
        <div id="divBasicDetails" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:RadioButton ID="rdbbooleansearch0" runat="server" Text="BooleanSearch" GroupName="b" />
                       
                    <asp:RadioButton ID="rdbkeywords0" runat="server" Text="Keywords" GroupName="b" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Any Of The Keywords</td>
                    <td>
                        <asp:TextBox ID="txtkeywords0" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">All the Keywords</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Excluding Keywords</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Candidate Work Status</span></td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">                            
                    <asp:ListItem>Looking For The Job</asp:ListItem>
                    <asp:ListItem>Offer Accepted</asp:ListItem>
                    <asp:ListItem>Joined New Job</asp:ListItem>
                    <asp:ListItem>Satisfied in the Current Job</asp:ListItem>
                    <asp:ListItem>Looking For the Freelancing Work</asp:ListItem>
                    <asp:ListItem>Looking for the Part Time Work</asp:ListItem>
                    <asp:ListItem>Serving Notice Period</asp:ListItem>
                    <asp:ListItem>Unemployed</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                <asp:UpdatePanel ID="panelLocationCurrent" runat="server">
                    <ContentTemplate>
                        <table style="width: 688px">
                            <tr>
                                <td class="auto-style3">Current Country</td>
                                <td>
                                    <asp:DropDownList ID="ddlPreferredCountry0" OnSelectedIndexChanged="ddlPreferredCountry_SelectedIndexChanged" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">Current State</td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtPreferredState0" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnState0" runat="server" Text="Select State" OnClick="btnState_Click" />
                                    <asp:Panel ID="PanelState0" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklState0" runat="server" OnSelectedIndexChanged="chklState_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>Current City
                                </td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtCity0" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnCity0" runat="server" Text="Select City" OnClick="btnCity_Click" />
                                    <asp:Panel ID="Panelcity0" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklCity0" runat="server" OnSelectedIndexChanged="chklCity_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>Current Area
                                </td>
                                <td>
                                    <asp:TextBox ID="txtarea0" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button runat="server" ID="btnarea0" Text="Select Area" OnClick="btnarea_Click" />
                                    <asp:Panel ID="PanelArea0" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklArea0" runat="server" AutoPostBack="true" RepeatColumns="6" OnSelectedIndexChanged="chklArea_SelectedIndexChanged"></asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                <asp:UpdatePanel ID="panelLocationPreferred" runat="server">
                    <ContentTemplate>
                        <table style="width: 688px">
                            <tr>
                                <td class="auto-style3">Preferred Country</td>
                                <td>
                                    <asp:DropDownList ID="ddlPreferredCountry" OnSelectedIndexChanged="ddlPreferredCountry_SelectedIndexChanged" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">Preferred State</td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtPreferredState" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnState" runat="server" Text="Select State" OnClick="btnState_Click" />
                                    <asp:Panel ID="PanelState" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklState" runat="server" OnSelectedIndexChanged="chklState_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>Preferred City
                                </td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtCity" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnCity" runat="server" Text="Select City" OnClick="btnCity_Click" />
                                    <asp:Panel ID="Panelcity" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklCity" runat="server" OnSelectedIndexChanged="chklCity_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>Preferred Area
                                </td>
                                <td>
                                    <asp:TextBox ID="txtarea" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button runat="server" ID="btnarea" Text="Select Area" OnClick="btnarea_Click" />
                                    <asp:Panel ID="PanelArea" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklArea" runat="server" AutoPostBack="true" RepeatColumns="6" OnSelectedIndexChanged="chklArea_SelectedIndexChanged"></asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style2"><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Experience</span></td>
                    <td>
                     <asp:DropDownList ID="ddlworkexprience0" runat="server">
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
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Current Annual Salary </span></td>
                    <td>
                      <asp:DropDownList ID="DropDownList2" runat="server">
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
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Expected Annual Salary </span></td>
                    <td>
                      <asp:DropDownList ID="DropDownList3" runat="server">
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
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Notice Period </span></td>
                    <td>
                        <asp:DropDownList ID="ddlnoticeperiod0" runat="server">
                            <asp:ListItem>Any</asp:ListItem>
                            <asp:ListItem>Currently Serving Notice Period</asp:ListItem>
                            <asp:ListItem> 15 Days Or Less</asp:ListItem>
                            <asp:ListItem> 1 Month</asp:ListItem>
                            <asp:ListItem> 2 Months</asp:ListItem>
                            <asp:ListItem> 3Moths</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </div>
            <br />
            <div id="divEmploymentDetails" runat="server">
                <table>
                    <tr>
                        <td><strong>Employment Details</strong></td>
                        <td>
                            
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>Industry</td>
                        <td>
                            
                            <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                            </asp:CheckBoxList>
                            <asp:DropDownList ID="DropDownList4" runat="server">
                            </asp:DropDownList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>Functional Area</td>
                        <td>
                            
                            <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                            </asp:CheckBoxList>
                            <asp:DropDownList ID="DropDownList5" runat="server">
                            </asp:DropDownList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>Department</td>
                        <td>
                            
                            <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                            </asp:CheckBoxList>
                            <asp:DropDownList ID="DropDownList6" runat="server">
                            </asp:DropDownList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Keywords Role skills </span></td>
                        <td>
                            
                            <asp:CheckBoxList ID="CheckBoxList5" runat="server">
                            </asp:CheckBoxList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-fareast-font-family:Calibri;mso-bidi-font-family:
&quot;Times New Roman&quot;;mso-ansi-language:EN-US;mso-fareast-language:EN-US;
mso-bidi-language:AR-SA">Keyword Technical skills</span></td>
                        <td>
                            
                            <asp:CheckBoxList ID="CheckBoxList6" runat="server">
                            </asp:CheckBoxList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>Employer</td>
                        <td>
                            
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                            <asp:DropDownList ID="DropDownList7" runat="server">
                            </asp:DropDownList>
                            
                            <asp:DropDownList ID="DropDownList10" runat="server">
                            </asp:DropDownList>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>Exclude Employer</td>
                        <td>
                            
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            <asp:DropDownList ID="DropDownList8" runat="server">
                            </asp:DropDownList>
                            
                            <asp:DropDownList ID="DropDownList11" runat="server">
                            </asp:DropDownList>
                            
                        </td>
                    </tr>
                </table>
            </div>
            <div id="divEducationDetails" runat="server">
                <table>
                    <tr>
                        <td>
                            <strong>Education Details
                        </strong>
                        </td>
                    </tr>
                    <tr>
                        <td rowspan="2">
                            Highest Qualification
                        </td>
                        <td>
                            UG Qualification<asp:DropDownList ID="DropDownList9" runat="server">
                            </asp:DropDownList>
&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            PG Qualification<asp:DropDownList ID="DropDownList12" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>

            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblbasicdetails" runat="server" Style="font-weight: 700" Text="BasicDetails"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="rdbbooleansearch" runat="server" Text="BooleanSearch" GroupName="b" />
                       
                    <asp:RadioButton ID="rdbkeywords" runat="server" Text="Keywords" GroupName="b" />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeywords" runat="server" Text="Any Of The KeyWords"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtkeywords" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeywords1" runat="server" Text="All Of The KeyWords"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtallkeywords" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeywords2" runat="server" Text="Excluding Keywords"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtexcludingkeywords" runat="server" Height="22px"></asp:TextBox>
                      
                    <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblworkstatus" runat="server" Text="Candidate Work Status"></asp:Label>
                    </td>
                    <td>
            <asp:DropDownList ID="ddlWorkStatus0" runat="server" Height="16px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Working</asp:ListItem>
                <asp:ListItem>On Notice Period</asp:ListItem>
                <asp:ListItem>Fresher</asp:ListItem>
            </asp:DropDownList>
      
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcandidatelocation" runat="server" Text="Candidate Current Location"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcurrentlocation" runat="server"></asp:TextBox>
                      </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="rdbarea" runat="server" GroupName="A" Text="And" />
                    </td>
                    <td>
                      </td>
                </tr>
                <tr>
                    <td>
                     
                        <asp:Label ID="lblareacurrent" runat="server" Text="Area Of Current Location "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcurrentarea" runat="server"></asp:TextBox>
                       </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblpreferedlocation" runat="server" Text="Candidate Prefered Location"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpreferedlocation" runat="server"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="rdbor1" runat="server" GroupName="A" Text="OR" />
                    </td>
                    <td>
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblareaprefered" runat="server" Text="Area Of Prefered Location "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpreferedarea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblExprience" runat="server" Text="Exprience"></asp:Label>
                    </td>
                    <td>
                     <asp:DropDownList ID="ddlworkexprience" runat="server">
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
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblannualsalary" runat="server" Text="Current Annual Salary"></asp:Label>
                    </td>
                    <td>
                      <asp:DropDownList ID="DropDownList1" runat="server">
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
                        </asp:DropDownList>
                 
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblexpectedannual" runat="server" Text="Expected Annual Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlworkexpyear1" runat="server">
                            <asp:ListItem>---select----</asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1.2</asp:ListItem>
                            <asp:ListItem>1.3</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>2.2</asp:ListItem>
                            <asp:ListItem>2.3</asp:ListItem>
                            <asp:ListItem> 2.4</asp:ListItem>
                            <asp:ListItem> 2.5</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>3.2</asp:ListItem>
                            <asp:ListItem>3.3</asp:ListItem>
                            <asp:ListItem> 3.5</asp:ListItem>
                            <asp:ListItem> 4</asp:ListItem>
                            <asp:ListItem> 4.2</asp:ListItem>
                            <asp:ListItem> 4.3</asp:ListItem>
                            <asp:ListItem>4.4</asp:ListItem>
                            <asp:ListItem>4.5</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>5.2</asp:ListItem>
                            <asp:ListItem>5.3</asp:ListItem>
                            <asp:ListItem> 5.4</asp:ListItem>
                            <asp:ListItem> 5.5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>6.2</asp:ListItem>
                            <asp:ListItem>6.3</asp:ListItem>
                            <asp:ListItem>6.4</asp:ListItem>
                            <asp:ListItem> 6.5</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblnoticeperiod0" runat="server" Text="Notice Period"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlnoticeperiod" runat="server">
                            <asp:ListItem>Any</asp:ListItem>
                            <asp:ListItem>Currently Serving Notice Period</asp:ListItem>
                            <asp:ListItem> 15 Days Or Less</asp:ListItem>
                            <asp:ListItem> 1 Month</asp:ListItem>
                            <asp:ListItem> 2 Months</asp:ListItem>
                            <asp:ListItem> 3Moths</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </table>
        </div>
         <hr style="border-width:initial"/>
        <div>

            <table>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="lblemploymentdetails" runat="server" Style="font-weight: 700" Text="EmploymentDetails"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfunctionalarea" runat="server" Text="FunctionalArea"></asp:Label>
                    </td>
                    <td>&nbsp;<asp:DropDownCheckBoxes ID="ddlfunctionalarea" runat="server" OnSelectedIndexChanged="ddlfunctionalarea_SelectedIndexChanged" style="top: -7px; left: -4px">
                        <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                    </asp:DropDownCheckBoxes>
                     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    &nbsp;
                       
                        <asp:DropDownList ID="ddlemployer1" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblindystrytype" runat="server" Text="Industry Type"></asp:Label>
                    </td>

                    <td>

                        <asp:DropDownCheckBoxes ID="ddlindustrytype" runat="server" OnSelectedIndexChanged="ddlindustrytype_SelectedIndexChanged" style="top: 0px; left: 0px; height: 20px">
                            <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                        </asp:DropDownCheckBoxes>
                        &nbsp; <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    &nbsp;
                       
                        <asp:DropDownList ID="ddlemployer2" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbldeparment" runat="server" Text="Department"></asp:Label>
                    </td>

                    <td>

                        <asp:DropDownList ID="ddldepartment" runat="server">
                        </asp:DropDownList>
                       
                        <asp:DropDownList ID="ddlemployer3" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblroleskill" runat="server" Text="Keywords/Role Skill"></asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="txtrollskill" runat="server"></asp:TextBox>
                       
                        <asp:DropDownList ID="ddlemployer4" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeywordstechnicalrole" runat="server" Text="Keywords/Role Technical"></asp:Label>
                    </td>

                    <td>

                        <asp:DropDownList ID="ddlroletechnical" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlemployer5" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblemployers" runat="server" Text="Employers"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemployers" runat="server"></asp:TextBox>
                       
                        <asp:DropDownList ID="ddlemployer" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                        <asp:DropDownList ID="ddlallwords" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblexcludeemployers" runat="server" Text="Exclude Employers"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtexcludeemployers" runat="server"></asp:TextBox>
                     
                        <asp:DropDownList ID="ddlemployer0" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                   
                        <asp:DropDownList ID="ddlallwords0" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                   
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbldesignation" runat="server" Text="Designatin"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
                      
                        <asp:DropDownList ID="ddldesignation" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                     
                        <asp:DropDownList ID="ddlallwords1" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                      </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                      </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
         <hr style="border-width:initial"/>
         <div>

             <table>
                 <tr>
                     <td>
                         <asp:Label ID="lbleducationaldetails" runat="server" Text="Educational Details"></asp:Label></td>
                     <td></td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblselecteducationaldetails" runat="server" Text="UGQualification"></asp:Label></td>
                     <td>
                         <asp:DropDownCheckBoxes ID="ddlugqualification" runat="server" style="top: 0px; left: 0px">
                             <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                         </asp:DropDownCheckBoxes></td>
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
                     <td>
                         <asp:Label ID="lblinstitutename" runat="server" Text="InstituteName"></asp:Label></td>
                     <td class="auto-style3">
                         <asp:TextBox ID="txtInstitutename" runat="server"></asp:TextBox>
                  
                        <asp:DropDownList ID="ddlallwords2" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblYearOfpassing" runat="server" Text="YearOfPassing"></asp:Label>&nbsp;&nbsp; </td>

                     <td>
                         <asp:DropDownList ID="ddlyear" runat="server">
                             <asp:ListItem> --from--</asp:ListItem>
                         </asp:DropDownList>
                       </td>
                 </tr>
                 <tr>
                     <td>&nbsp;</td>

                     <td>
                         <asp:RadioButton ID="rdbAnd" runat="server" Text="And" />
                         &nbsp;&nbsp;
                        <asp:RadioButton ID="rdbor" runat="server" Text="OR" />
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblPGeducationaldetails" runat="server" Text="PGQualification"></asp:Label></td>

                     <td>
                         <asp:DropDownCheckBoxes ID="ddlpgqualification" runat="server" style="top: 0px; left: 1px">
                             <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                         </asp:DropDownCheckBoxes>&nbsp;</td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblpginstitutename" runat="server" Text="InstituteName"></asp:Label></td>

                     <td>
                         <asp:TextBox ID="txtpginstitutename" runat="server"></asp:TextBox>
                         &nbsp;
                        <asp:DropDownList ID="ddlallwordspg" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblpgyearofpassing" runat="server" Text="YearOfPassing"></asp:Label></td>

                     <td>
                         <asp:DropDownList ID="ddlpassingyear" runat="server">
                             <asp:ListItem> --from--</asp:ListItem>
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td></td>

                     <td></td>
                 </tr>
             </table>
         </div>
        <hr style="border-width:initial"/>
        <div>

                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="lblaffirmative" runat="server" Text="Affirmative Details"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblcategory" runat="server" Text="Category"></asp:Label>
                                </td>
                                <td>
                                <asp:DropDownCheckBoxes runat="server" ID="ddlcategory" UseSelectAllNode = "false">
                                    <Style SelectBoxWidth="195" DropDownBoxBoxWidth="160" DropDownBoxBoxHeight="90" />
                                    <items>
                                    <asp:ListItem> SC</asp:ListItem>
                                    <asp:ListItem> ST</asp:ListItem>
                                    <asp:ListItem> OBC-Creamy</asp:ListItem>
                                    <asp:ListItem> OBC-Noncremy</asp:ListItem>
                                        </items>
                                </asp:DropDownCheckBoxes>
                             </td>               
                </tr>
                            <tr>
                                <td>
                                    <asp:Button Text="Submit" runat="server" OnClick = "Submit" /></td>
                               </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="chksearchwomen" runat="server" OnCheckedChanged="chksearchwomen_CheckedChanged" />

                                    <asp:Label ID="lblcandidate" runat="server" Text="search Women Candidate Only"></asp:Label>
                                </td>
                               </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" />

                                    <asp:Label ID="lblability" runat="server" Text="search  Candidate  With Special Ability Only"></asp:Label>
                                </td>
                               </tr>
            </table>
        </div>
        <hr style="border-width:initial"/>
        <div>

            <table>
                <tr>
                    <td>
                                    <asp:Label ID="lbladditionalfilters" runat="server" Text="Additional Filters"></asp:Label>
                                </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblCanditateAge" runat="server" Text="Candidate Age"></asp:Label>
                                </td>
                    <td>
                        <asp:DropDownList ID="ddlminage" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblWorkStatusfor" runat="server" Text="Work Status For"></asp:Label>
                                </td>
                    <td><asp:DropDownCheckBoxes runat="server" ID="ddlworkstatus" UseSelectAllNode="false" >
                          <Style SelectBoxWidth="195" DropDownBoxBoxWidth="160" DropDownBoxBoxHeight="90" />
                        <items>
                            <asp:ListItem> Have H1 Visa</asp:ListItem>
                            <asp:ListItem> Need H1 Visa</asp:ListItem>
                            <asp:ListItem> TN Permit Holder</asp:ListItem>
                            <asp:ListItem> Grren Card Holder</asp:ListItem>
                            <asp:ListItem> US Citizen</asp:ListItem>
                            <asp:ListItem> Authorized to work in US</asp:ListItem>
                        </items>
                        </asp:DropDownCheckBoxes>
              
                    <asp:DropDownCheckBoxes runat ="server" ID="ddlothercities" UseSelectAllNode="false" placeholder="Other Countries">
                         <Style SelectBoxWidth="195" DropDownBoxBoxWidth="160" DropDownBoxBoxHeight="90" />
                        <items>
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem> Australia</asp:ListItem>
                            <asp:ListItem> Bahrain</asp:ListItem>
                            <asp:ListItem> Bangladesh</asp:ListItem>
                            <asp:ListItem>Belgium</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                            <asp:ListItem>Dubai</asp:ListItem>
                            <asp:ListItem>France</asp:ListItem>
                            <asp:ListItem>Germany</asp:ListItem>
                            <asp:ListItem>Hong Kong</asp:ListItem>
                            <asp:ListItem>Thailand</asp:ListItem>
                            <asp:ListItem> United Arab Emirates</asp:ListItem>
                            <asp:ListItem>United Kingdom</asp:ListItem>
                            <asp:ListItem>United States</asp:ListItem>
                            <asp:ListItem>Zimbabwe</asp:ListItem>
                            <asp:ListItem>Other Int. Locations</asp:ListItem>
                        </items>
                       
                    </asp:DropDownCheckBoxes>
                        </td>
                </tr>
               
            </table>

        </div>
        <hr style="border-width:initial"/>
        <div>

            <table>
                <tr>
                    <td>
                                    <asp:Label ID="lbldisplaylocations" runat="server" Text="Display Locations"></asp:Label>
                                </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblactivecandidate" runat="server" Text="Active Candidate  In Last"></asp:Label>
                                </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblcandidateseeking" runat="server" Text="Show andidate Seeking"></asp:Label>
                                </td>
                    <td>
                        <asp:RadioButton ID="rdbpermantjob" runat="server" Text="Permant Job" GroupName="p" OnCheckedChanged="rdbpermantjob_CheckedChanged" />
                      
                        <asp:RadioButton ID="rdbtemproryjob" runat="server" Text="Temprory/Contract Job" GroupName="p" />

                        <asp:RadioButton ID="rdbAny" runat="server" Text="Any" GroupName="p" />
 </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:RadioButton ID="rdbfulltimejob" runat="server" Text="FullTime Job" GroupName="p" />

                        <asp:RadioButton ID="rdbparttime" runat="server" Text="PartTime Job" GroupName="p" />

                        <asp:RadioButton ID="rdbany1" runat="server" Text="Any" GroupName="p" />
                    </td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblnoticeperiod" runat="server" Text="Notice Period"></asp:Label>
                                </td>
                    <td>
                   </td>
                </tr>
                <tr>
                    <td>
                                    <asp:Label ID="lblsortby" runat="server" Text="Sort By"></asp:Label>
                                </td>
                    <td>
                        <asp:DropDownList ID="ddlsort" runat="server">
                            <asp:ListItem>Relevance</asp:ListItem>
                            <asp:ListItem>Last Active Date</asp:ListItem>
                            <asp:ListItem>Resume Freshness</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnresumefind" runat="server" Text="Find Resume" />
                    </td>
                </tr>
            </table>
        </div>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    
    </form>
</body>
</html>