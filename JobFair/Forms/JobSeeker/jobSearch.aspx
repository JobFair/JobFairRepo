<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="jobSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.jobSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <table style="width:100%">
            <tr>
                <td style="width:20%;vertical-align:top">
                    <fieldset>
                        <legend>Div 1</legend>
                        <div class="left">

                            <div>
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


                                <asp:LinkButton ID="lblFreshness" runat="server" Text="By Freshness"></asp:LinkButton>

                                <asp:Panel ID="PanelFreshness" runat="server">
                                    <asp:CheckBoxList ID="cblFreshness" runat="server">
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
                                    <asp:CheckBoxList ID="cblLocation" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPELocation" runat="server" TargetControlID="PanelLoaction" TextLabelID="lblLocation" CollapseControlID="lblFreshness" ExpandControlID="lblLocation" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblRole" runat="server" Text="Role" CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelRole" runat="server">
                                    <asp:CheckBoxList ID="cblRole" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPERole" runat="server" TargetControlID="PanelRole" TextLabelID="lblRole" CollapseControlID="lblRole" ExpandControlID="lblRole" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblFunctionalArea" runat="server" Text="Functional Area " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelFunctArea" runat="server">
                                    <asp:CheckBoxList ID="cblFunctArea" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEFunctArea" runat="server" TargetControlID="PanelFunctArea" TextLabelID="lblFunctionalArea" CollapseControlID="lblFunctionalArea" ExpandControlID="lblFunctionalArea" Collapsed="true" />

                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblCompanyLevel" runat="server" Text="Company Level " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelCompanyLevel" runat="server">
                                    <asp:CheckBoxList ID="cblCompanyLevel" runat="server">
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
                                    <asp:CheckBoxList ID="cblIndustry" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEIndustry" runat="server" TargetControlID="PanelIndustry" TextLabelID="lblIndustry" CollapseControlID="lblIndustry" ExpandControlID="lblIndustry" Collapsed="true" />
                            </div>
                            <br />
                            <div>
                                <asp:LinkButton ID="lblSalary" runat="server" Text="By Salary " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelSalary" runat="server">
                                    <asp:CheckBoxList ID="cblSalary" runat="server">
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
                                    <asp:CheckBoxList ID="cblEducation" runat="server"></asp:CheckBoxList>
                                </asp:Panel>
                                <cc1:CollapsiblePanelExtender ID="CPEEducation" runat="server" TargetControlID="PanelEducation" TextLabelID="lblEducation" CollapseControlID="lblEducation" ExpandControlID="lblEducation" Collapsed="true" />
                            </div>

                            <br />
                            <div>
                                <asp:LinkButton ID="lblStatus" runat="server" Text="By Employment Status " CssClass="label"></asp:LinkButton>

                                <asp:Panel ID="PanelStatus" runat="server">
                                    <asp:CheckBoxList ID="cblStatus" runat="server">
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
                                    <asp:CheckBoxList ID="cblJobType" runat="server">
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
                <td width="80%" style="vertical-align: top">
                    <fieldset>
                        <div>
                        <asp:LinkButton ID="allJobs" runat="server" Text="AllJobs" OnClick="lnks_Click"></asp:LinkButton>
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                             <br />
                             </div>
                        <div style="width:70%; height: 542px;">
        <fieldset>
        
    <table class="auto-style6">
       
        <tr>
            <td class="auto-style7">Job Title/Designation</td>
            <td>
                <asp:TextBox ID="txtJobtitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Locations</td>
            <td>
                <div id="divDDL" class="divDDL" runat="server">
        Please Select…
                </div>
                <asp:Panel ID="pnlCustomers" runat="server" CssClass="MultipleSelectionDDL" Height="49px" Width="85px">
                    <asp:CheckBoxList ID="chkCustomerList" runat="server" onclick="readCheckBoxList()" Width="110px" Height="40px" >
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
                <br /></td>
        </tr>
        <tr>
            <td class="auto-style7">Company Level</td>
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
            <td class="auto-style7">Industry</td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Department</td>
            <td>
                <asp:DropDownList ID="ddlDepartment" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Functional Area</td>
            <td>
                <asp:DropDownList ID="ddlFunArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Roles</td>
            <td>
                <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Technical</td>
            <td>
                <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Work Experience</td>
            <td><asp:TextBox ID="txtWorkExp" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtWorkExp_CalendarExtender" runat="server" BehaviorID="txtWorkExp_CalendarExtender" TargetControlID="txtWorkExp">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Gender</td>
            <td>
                <asp:CheckBoxList ID="chkGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Offered Anual Salary</td>
            <td>
                <asp:TextBox ID="txtAnnualSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Other Salary Details</td>
            <td>
                <asp:TextBox ID="txtOtherSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Number of Vacancies</td>
            <td>
                <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnsend" runat="server" Text="Send" OnClick="btnsend_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblTotalCount" runat="server" Text="TotalCount"></asp:Label>
            </td>
        </tr>
    </table> 
    </div>
                    </fieldset>
                </td>
            </tr>
        </table>
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
