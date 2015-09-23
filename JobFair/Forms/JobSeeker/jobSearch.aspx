<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="jobSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.jobSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <table style="width:100%">
            <tr>
                <td style="vertical-align:top" class="auto-style1">
                    <fieldset>
                        <legend>Div 1</legend>
                        <div class="left">

                            <div>
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


                                <asp:LinkButton ID="lblFreshness" runat="server" Text="By Freshness"></asp:LinkButton>

                                <asp:Panel ID="PanelFreshness" runat="server">
                                    <asp:CheckBoxList ID="chkFreshness" runat="server">
                                        <asp:ListItem>30 Days</asp:ListItem>
                                        <asp:ListItem>25 Days</asp:ListItem>
                                        <asp:ListItem>20 Days</asp:ListItem>
                                        <asp:ListItem>15 Days</asp:ListItem>
                                        <asp:ListItem>10 Days</asp:ListItem>
                                        <asp:ListItem>7 Days</asp:ListItem>
                                        <asp:ListItem>1 Day</asp:ListItem>
                                    </asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEfreshness" runat="server" TargetControlID="PanelFreshness" TextLabelID="lblFreshness" CollapseControlID="lblFreshness" ExpandControlID="lblFreshness" Collapsed="true" />

                            </div>


                            <br />
                            <div>
                                <asp:LinkButton ID="lblLocation" runat="server" Text="By Location" CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelLoaction" runat="server">
                                    <asp:CheckBoxList ID="chkLocation" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPELocation" runat="server" TargetControlID="PanelLoaction" TextLabelID="lblLocation" CollapseControlID="lblFreshness" ExpandControlID="lblLocation" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblRole" runat="server" Text="Role" CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelRole" runat="server">
                                    <asp:CheckBoxList ID="chkRole" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPERole" runat="server" TargetControlID="PanelRole" TextLabelID="lblRole" CollapseControlID="lblRole" ExpandControlID="lblRole" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblFunctionalArea" runat="server" Text="Functional Area " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelFunctArea" runat="server">
                                    <asp:CheckBoxList ID="chkFunctArea" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEFunctArea" runat="server" TargetControlID="PanelFunctArea" TextLabelID="lblFunctionalArea" CollapseControlID="lblFunctionalArea" ExpandControlID="lblFunctionalArea" Collapsed="true" />

                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblCompanyLevel" runat="server" Text="Company Level " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelCompanyLevel" runat="server">
                                    <asp:CheckBoxList ID="chkCompanyLevel" runat="server">
                                        <asp:ListItem>Start Up Company</asp:ListItem>
                                        <asp:ListItem>Small Scale Company</asp:ListItem>
                                        <asp:ListItem>Mid Level Company</asp:ListItem>
                                        <asp:ListItem>MNC</asp:ListItem>
                                    </asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPECompnyLevel" runat="server" TargetControlID="PanelCompanyLevel" TextLabelID="lblCompanyLevel" CollapseControlID="lblCompanyLevel" ExpandControlID="lblCompanyLevel" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblIndustry" runat="server" Text="Industry " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelIndustry" runat="server">
                                    <asp:CheckBoxList ID="chkIndustry" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEIndustry" runat="server" TargetControlID="PanelIndustry" TextLabelID="lblIndustry" CollapseControlID="lblIndustry" ExpandControlID="lblIndustry" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblSalary" runat="server" Text="By Salary " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelSalary" runat="server">
                                    <asp:CheckBoxList ID="chkSalary" runat="server">
                                        <asp:ListItem>0-3 Lakhs</asp:ListItem>
                                        <asp:ListItem>3-6 Lakhs</asp:ListItem>
                                        <asp:ListItem>6-10 Lakhs</asp:ListItem>
                                        <asp:ListItem>10-15 Lakhs</asp:ListItem>
                                        <asp:ListItem>15- 20 Lakhs</asp:ListItem>
                                        <asp:ListItem>20-25 Lakhs</asp:ListItem>
                                        <asp:ListItem>more</asp:ListItem>
                                    </asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPESalary" runat="server" TargetControlID="PanelSalary" TextLabelID="lblSalary" CollapseControlID="lblSalary" ExpandControlID="lblSalary" Collapsed="true" />
                            </div>

                            <br />
                            <div>
                                <asp:LinkButton ID="lblEducation" runat="server" Text="By Education " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelEducation" runat="server">
                                    <asp:CheckBoxList ID="chkEducation" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEEducation" runat="server" TargetControlID="PanelEducation" TextLabelID="lblEducation" CollapseControlID="lblEducation" ExpandControlID="lblEducation" Collapsed="true" />
                            </div>

                            <br />
                            <div>
                                <asp:LinkButton ID="lblStatus" runat="server" Text="By Employment Status " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelStatus" runat="server">
                                    <asp:CheckBoxList ID="chkStatus" runat="server">
                                        <asp:ListItem>Full Time</asp:ListItem>
                                        <asp:ListItem>Part Time</asp:ListItem>
                                    </asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEStatus" runat="server" TargetControlID="PanelStatus" TextLabelID="lblStatus" CollapseControlID="lblStatus" ExpandControlID="lblStatus" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblJobType" runat="server" Text="Job Type " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelJobType" runat="server">
                                    <asp:CheckBoxList ID="chkJobType" runat="server">
                                        <asp:ListItem>Permanent</asp:ListItem>
                                        <asp:ListItem>Temporary</asp:ListItem>
                                        <asp:ListItem>Freelancing</asp:ListItem>
                                    </asp:CheckBoxList>
                                    <br />
                                    <br />
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEJobType" runat="server" TargetControlID="PanelJobType" TextLabelID="lblJobType" CollapseControlID="lblJobType" ExpandControlID="lblJobType" Collapsed="true" />
                            </div>

                        </div>
                    </fieldset>
                </td>
     
        </div>

                <td width="80%" style="vertical-align: top">
                    <fieldset>
                       <div>
                        <asp:LinkButton ID="allJobs" runat="server" Text="AllJobs" OnClick="lnks_Click"></asp:LinkButton>
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                            <br />
                            
                             </div>
                           </fieldset>
                       
       <asp:Repeater ID="Repeater1" runat="server" >
           <HeaderTemplate>
              <table>
              <tr>
                 <th>JobTitle</th>
                 <th>JobLocationCity</th>
                 <th>JobLocationArea</th>
                <th>CompanyLevel</th>
                 <th>Industry</th>
                  <th>Department</th>
                  <th>FunctionalArea</th>
                  <th>JobDescription</th>
                  <th>KeywordsRoles</th>
                  <th>KeywordsTechnical</th>
                  <th>WorkExprience</th>
                  <th>Gender</th>
                  <th>OfferedAnnualSalary</th>
                  <th>OtherSalaryDetails</th>
                   <th>NumberOfVacancies</th>
              </tr>
          </HeaderTemplate>
           <ItemTemplate>
               <tr>
               <td> 
                <%# DataBinder.Eval(Container.DataItem, "JobTitle") %>
          </td>
                <td> 
                <%# DataBinder.Eval(Container.DataItem, "JobLocationCity") %>
          </td>
                     <td> 
                <%# DataBinder.Eval(Container.DataItem, "JobLocationArea") %>
          </td>

                     <td> 
                <%# DataBinder.Eval(Container.DataItem, "CompanyLevel") %>
          </td>
                   <td> 
                <%# DataBinder.Eval(Container.DataItem, "Industry") %>
             </td> 
               <td> 
                <%# DataBinder.Eval(Container.DataItem, "Department") %>
                </td>
                 <td> 
                <%# DataBinder.Eval(Container.DataItem, "FunctionalArea") %>
                  </td>
                  <td> 
                <%# DataBinder.Eval(Container.DataItem, "JobDescription") %>
                   </td>
                  <td> 
                <%# DataBinder.Eval(Container.DataItem, "KeywordsRoles") %>
                 </td>
                  <td> 
                <%# DataBinder.Eval(Container.DataItem, "KeywordsTechnical") %>
                  </td>
                 <td> 
                <%# DataBinder.Eval(Container.DataItem, "WorkExprience") %>
                </td>     
                <td> 
                <%# DataBinder.Eval(Container.DataItem, "Gender") %>
                </td>
                 <td> 
                <%# DataBinder.Eval(Container.DataItem, "OfferedAnnualSalary") %>
                 </td>
                <td> 
                <%# DataBinder.Eval(Container.DataItem, "OtherSalaryDetails") %>
                  </td>
                   <td> 
                <%# DataBinder.Eval(Container.DataItem, "NumberOfVacancies") %>
                 </td>
                   </tr>

           </ItemTemplate>

          </asp:Repeater>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 11%;
        }
    </style>
</asp:Content>

