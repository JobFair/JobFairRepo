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

        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 214px;
        }
        .auto-style6 {
            height: 21px;
        }
        .auto-style7 {
            width: 180px;
        }
        .auto-style8 {
            width: 180px;
            height: 23px;
        }
        .auto-style9 {
            width: 23%;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lblbasicdetails" runat="server" Style="font-weight: 700" Text="BasicDetails"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:RadioButton ID="rdbbooleansearch" runat="server" Text="BooleanSearch" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbkeywords" runat="server" Text="Keywords" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lblkeywords" runat="server" Text="Any Of The KeyWords"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtkeywords" runat="server" OnTextChanged="txtkeywords_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lblkeywords1" runat="server" Text="All Of The KeyWords"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtallkeywords" runat="server" OnTextChanged="txtallkeywords_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
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
                <asp:GridView ID="GridView1" runat="server">
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
                        <asp:Label ID="lblemploymentdetails" runat="server" Style="font-weight: 700" Text="EmploymentDetails"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfunctionalarea" runat="server" Text="FunctionalArea"></asp:Label>
                    </td>
                    <td>&nbsp;<asp:DropDownCheckBoxes ID="ddlfunctionalarea" runat="server" OnSelectedIndexChanged="ddlfunctionalarea_SelectedIndexChanged">
                        <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                    </asp:DropDownCheckBoxes>
                        &nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
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
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
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
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlemployer0" runat="server">
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlallwords0" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
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
                            <asp:ListItem>current employer</asp:ListItem>
                            <asp:ListItem>Previous employer</asp:ListItem>
                            <asp:ListItem>current/Previous</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlallwords1" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         <div>

             <table class="auto-style2">
                 <tr>
                     <td>
                         <asp:Label ID="lbleducationaldetails" runat="server" Text="Educational Details"></asp:Label></td>
                     <td>&nbsp;</td>
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
                     <td class="auto-style3">
                         <asp:Label ID="lblinstitutename" runat="server" Text="InstituteName"></asp:Label></td>
                     <td class="auto-style3">
                         <asp:TextBox ID="txtInstitutename" runat="server"></asp:TextBox>
                         &nbsp;
                        <asp:DropDownList ID="ddlallwords2" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                            <asp:ListItem> Any Of the Words</asp:ListItem>
                            <asp:ListItem> All Of The Pharse</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">
                         <asp:Label ID="lblYearOfpassing" runat="server" Text="YearOfPassing"></asp:Label>&nbsp;&nbsp; </td>

                     <td>
                         <asp:DropDownList ID="ddlyear" runat="server">
                             <asp:ListItem> --from--</asp:ListItem>
                         </asp:DropDownList>
                         &nbsp; To
                         <asp:DropDownList ID="DropDownList1" runat="server">
                             <asp:ListItem> ---to---</asp:ListItem>
                         </asp:DropDownList>
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
                     <td class="auto-style3">
                         <asp:Label ID="lblPGeducationaldetails" runat="server" Text="PGQualification"></asp:Label></td>

                     <td>
                         <asp:DropDownCheckBoxes ID="ddlpgqualification" runat="server" style="top: 0px; left: 1px">
                             <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                         </asp:DropDownCheckBoxes>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style4">
                         <asp:Label ID="lblpginstitutename" runat="server" Text="InstituteName"></asp:Label></td>

                     <td class="auto-style4">
                         <asp:TextBox ID="txtpginstitutename" runat="server"></asp:TextBox>
                         &nbsp;
                        <asp:DropDownList ID="ddlallwordspg" runat="server">
                            <asp:ListItem> All Words</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">
                         <asp:Label ID="lblpgyearofpassing" runat="server" Text="YearOfPassing"></asp:Label></td>

                     <td>
                         <asp:DropDownList ID="ddlpassingyear" runat="server">
                             <asp:ListItem> --from--</asp:ListItem>
                         </asp:DropDownList>
                         To<asp:DropDownList ID="ddlmaxyear" runat="server">
                             <asp:ListItem> ---to---</asp:ListItem>
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>

                     <td>&nbsp;</td>
                 </tr>
             </table>
         </div>
        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        <div>

                        <table class="auto-style2">
                            <tr>
                                <td>
                                    <asp:Label ID="lblaffirmative" runat="server" Text="Affirmative Details"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Label ID="lblcategory" runat="server" Text="Category"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                <asp:DropDownCheckBoxes runat="server" ID="ddlcategory" UseSelectAllNode = "false">
                                    <Style SelectBoxWidth="195" DropDownBoxBoxWidth="160" DropDownBoxBoxHeight="90" />
                                    <items>
                                    <asp:ListItem> SC</asp:ListItem>
                                    <asp:ListItem> ST</asp:ListItem>
                                    <asp:ListItem> OBC-Creamy</asp:ListItem>
                                    <asp:ListItem> OBC-Noncremy</asp:ListItem>
                                        </items>
                                </asp:DropDownCheckBoxes>
                             
                                <td class="auto-style6">
                             
                </tr>
                            <tr>
                                <td>
                                    <asp:Button Text="Submit" runat="server" OnClick = "Submit" /></td>
                               </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="chksearchwomen" runat="server" OnCheckedChanged="chksearchwomen_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lblcandidate" runat="server" Text="search Women Candidate Only"></asp:Label>
                                </td>
                               </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lblability" runat="server" Text="search  Candidate  With Special Ability Only"></asp:Label>
                                </td>
                               </tr>
            </table>
        </div>
        --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        <div>

            <table class="auto-style2">
                <tr>
                    <td class="auto-style5">
                                    <asp:Label ID="lbladditionalfilters" runat="server" Text="Additional Filters"></asp:Label>
                                </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                                    <asp:Label ID="lblCanditateAge" runat="server" Text="Candidate Age"></asp:Label>
                                </td>
                    <td>
                        <asp:DropDownList ID="ddlminage" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
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
        ----------------------------------------------------------------------------------------------------------------------------------------------
        <div>

            <table class="auto-style2">
                <tr>
                    <td class="auto-style8">
                                    <asp:Label ID="lbldisplaylocations" runat="server" Text="Display Locations"></asp:Label>
                                </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                                    <asp:Label ID="lblactivecandidate" runat="server" Text="Active Candidate  In Last"></asp:Label>
                                </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                                    <asp:Label ID="lblcandidateseeking" runat="server" Text="Show andidate Seeking"></asp:Label>
                                </td>
                    <td>&nbsp;
                        <asp:RadioButton ID="rdbpermantjob" runat="server" Text="Permant Job" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbtemproryjob" runat="server" Text="Temprory/Contract Job" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbAny" runat="server" Text="Any" />
&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        <asp:RadioButton ID="rdbfulltimejob" runat="server" Text="FullTime Job" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbparttime" runat="server" Text="PartTime Job" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbany1" runat="server" Text="Any" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                                    <asp:Label ID="lblnoticeperiod" runat="server" Text="Notice Period"></asp:Label>
                                </td>
                    <td>
                        <asp:DropDownList ID="ddlnoticeperiod" runat="server">
                            <asp:ListItem>Any</asp:ListItem>
                            <asp:ListItem>Currently Serving Notice Period</asp:ListItem>
                            <asp:ListItem> 15 Days Or Less</asp:ListItem>
                            <asp:ListItem> 1 Month</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
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
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnresumefind" runat="server" Text="Find Resume" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>