<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="jobSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.jobSearch" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
<script  type="text/javascript" src="../../Scripts/ValidationAll.js"></script>

    <!DOCTYPE html>
    
    <script>
        $('#checkbox_filter').click(function () { oTable.fnDraw(); });
        /* Custom filtering function which will filter data in column four between two values */
        $.fn.dataTableExt.afnFiltering.push(
            function (oSettings, aData, iDataIndex) {

                if ($('#starfilter').attr('checked')) {
                    if ($('input', oTable.fnGetNodes(iDataIndex)).is(':checked')) {
                        return true
                    }
                }
                else {
                    return true
                }
            }
        );
       
        //$(document).ready(function () {
        //    var checkboxlist_selector = '#chkIndustry  input[type = checkbox]';
        //    alert(checkboxlist_selector);
        //    $(checkboxlist_selector).click(function () {
        //        if ($($(this).is(':checked'))) {
        //            $(checkboxlist_selector).attr('disabled', 'disabled');
        //            $($(this)).removeAttr('disabled');

        //        } else {
        //            $(checkboxlist_selector).removeAttr('disabled');
        //        }
        //    });

        //});
       // JSON.stringify(checkboxlist_selector);
       <%-- var valuesIndustryName = "";
        $j("#<%=chkIndustry.ClientID%>input[type=checkbox]:checked").each(function () {
            varIndustryName = $j(this).parent().attr('IndustryNamevalue');
            valuesIndustryName += varIndustryName + ",";
        });--%>
    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="row vdivide">
            <div class="col-md-2 text-left pull-left">
                <div class="h4"><span>Refine Request</span> </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelFreshness">Job Freshness</button>
                <div id="PanelFreshness" class="collapse">
                    <asp:CheckBoxList ID="chkFreshness" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkFreshness_SelectedIndexChanged">
                        <asp:ListItem>30 Days</asp:ListItem>
                        <asp:ListItem>25 Days</asp:ListItem>
                        <asp:ListItem>20 Days</asp:ListItem>
                        <asp:ListItem>15 Days</asp:ListItem>
                        <asp:ListItem>10 Days</asp:ListItem>
                        <asp:ListItem>7 Days</asp:ListItem>
                        <asp:ListItem>1 Day</asp:ListItem>
                    </asp:CheckBoxList>
                </div>

                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelLoaction">Job Location</button>
                <div id="PanelLoaction" class="collapse">
                    <asp:CheckBoxList ID="chkLocation" runat="server" OnSelectedIndexChanged="chkLocation_SelectedIndexChanged"></asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelRole">Role</button>
                <div id="PanelRole" class="collapse">
                    <asp:CheckBoxList ID="chkRole" runat="server" OnSelectedIndexChanged="chkRole_SelectedIndexChanged"></asp:CheckBoxList>
                </div>
                <hr />

                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelFunctArea">Functional Area</button>
                <div id="PanelFunctArea" class="collapse">
                    <asp:CheckBoxList ID="chkFunctArea" runat="server"></asp:CheckBoxList>
                </div>
                <hr />

                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelCompanyLevel">Company Level</button>
                <div id="PanelCompanyLevel" class="collapse">
                    <asp:CheckBoxList ID="chkCompanyLevel" runat="server" AutoPostBack="true" OnSelectedIndexChanged="chkCompanyLevel_SelectedIndexChanged">
                        <asp:ListItem Text="Start level Company" Value="Start level Company"></asp:ListItem>
                        <asp:ListItem Text="Small Scale Company" Value="Small Scale Company"></asp:ListItem>
                        <asp:ListItem Text="Mid Level Company" Value="Mid Level Company"></asp:ListItem>
                        <asp:ListItem Text="MNC" Value="MNC"></asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelIndustry">Industry</button>
                <div id="PanelIndustry" class="collapse">
                    <asp:CheckBoxList ID="chkIndustry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="chkIndustry_SelectedIndexChanged" ></asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelSalary">Salary</button>
                <div id="PanelSalary" class="collapse">
                    <asp:CheckBoxList ID="chkSalary" runat="server">
                        <asp:ListItem>0-3 Lakhs</asp:ListItem>
                        <asp:ListItem>3-6 Lakhs</asp:ListItem>
                        <asp:ListItem>6-10 Lakhs</asp:ListItem>
                        <asp:ListItem>10-15 Lakhs</asp:ListItem>
                        <asp:ListItem>15- 20 Lakhs</asp:ListItem>
                        <asp:ListItem>20-25 Lakhs</asp:ListItem>
                        <asp:ListItem>more</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelEducation">Education</button>
                <div id="PanelEducation" class="collapse">
                    <asp:CheckBoxList ID="chkEducation" runat="server"></asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelStatus">Employment Status</button>

                <div id="PanelStatus" class="collapse">
                    <asp:CheckBoxList ID="chkStatus" runat="server">
                        <asp:ListItem>Full Time</asp:ListItem>
                        <asp:ListItem>Part Time</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelJobType">Job Type</button>

                <div id="PanelJobType" class="collapse">

                    <asp:CheckBoxList ID="chkJobType" runat="server">
                        <asp:ListItem>Permanent</asp:ListItem>
                        <asp:ListItem>Temporary</asp:ListItem>
                        <asp:ListItem>Freelancing</asp:ListItem>
                    </asp:CheckBoxList>
                    <hr />
                </div>
            </div>
            <div class="col-md-10">
                <asp:Repeater ID="rptrJobPost" runat="server" OnItemCommand="rptrJobPost_ItemCommand">
                    <HeaderTemplate>
                    <table style="border: 1px solid #0000FF">
                            <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                                <td>
                                    <b>Job Post</b>
                                </td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                     <ItemTemplate>   <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                           <div class="divjobtitle"> <asp:HyperLink ID="HyperLink1"  runat="server" Text='<%#Eval("JobTitle")%>' NavigateUrl="ViewAllJobPost.aspx"></asp:HyperLink></div>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>/
                                             <asp:Label ID="lblstatename" runat="server" Text='<%#Eval("StateName")%>'></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                             <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                               <td>
                                            Work Experience&nbsp;&nbsp;
                                        <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperienceMin")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                          <asp:Label ID="lblworkexpriencemax" runat="server" Text='<%#Eval("WorkExperienceMax")%>'></asp:Label>
                                               </td>
                                                </tr>
                                            </table>
                                        </td>
                                        </tr>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                   <td> 
                                            Key Skill &nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="lblkeywordstechnical" runat="server" Text='<%#highlighttext(Convert.ToString(DataBinder.Eval(Container.DataItem,"KeywordsTechnical")))%>'></asp:Label>
                                                       </td>
                                                </tr>
                                            </table>
                                            </td>
                                        </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>Functional Area &nbsp;&nbsp;&nbsp;
                                                                 <asp:Label ID="lblfunctionalarea" runat="server" Text='<%#Eval("FunctionalArea") %>' ></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    </td>
                                                   </tr>       
                                                     <tr>
                                                     <td>
                                                    <table>
                                                    <tr>
                                                    <td>
                                       Number of Vacancies&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lblvacancies" runat="server" Text='<%#Eval("NumberOfVacancies")%>'></asp:Label> </td>
                            </tr>
                        </tr>
                       </td>
                    </table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>$
                                           [<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />/
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                       

                                        </td>s&nbsp;&nbsp;&nbsp;
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                   <tr>
                       <td>
                           <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                               <tr>
                                   <td>
                                       <asp:Button ID="btnapply"  OnClientClick="document.forms[0].target='_blank';" runat="server" Text="Apply"  CommandName="Contact" UseSubmitBehavior="false" />
                                   </td>
                               </tr>
                           </table>
                       </td>
                   </tr>    
                     </ItemTemplate>
                   <FooterTemplate>
                    </table>
                    </FooterTemplate>
                   </asp:Repeater>
            </div>
           
        </div>
    </div>
</asp:Content>