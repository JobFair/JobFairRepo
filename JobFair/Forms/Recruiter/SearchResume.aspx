<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResume.aspx.cs" Inherits="JobFair.Forms.Recruiter.SearchResume" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <table>
                <tr>
                    <td colspan="2">
                        <h2>Search Resume</h2>
                    </td>
                </tr>
                <tr>
                    <td>Client Name</td>
                    <td>
                        <asp:DropDownList ID="ddlClientName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlClientName_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Position</td>
                    <td>
                        <asp:DropDownList ID="ddlPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Requirement ID</td>
                    <td>
                        <asp:Label ID="lblRequirementId" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Boolean Search</asp:ListItem>
                <asp:ListItem>Keywords</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Panel ID="pnlBooleanSearch" runat="server">
                <div>
                    <table>
                        <tr>
                            <td>Any Keywords</td>
                            <td>
                                <asp:TextBox ID="txtKeywords" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>All Keywords</td>
                            <td>
                                <asp:TextBox ID="txtAllKeywords" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Excluding Keywords</td>
                            <td>
                                <asp:TextBox ID="txtExcludingKeywords" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Work Status</td>
                            <td>
                                <asp:DropDownList ID="ddlWorkStatus" runat="server">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Looking For The Job</asp:ListItem>
                                    <asp:ListItem>Offer Accepted</asp:ListItem>
                                    <asp:ListItem>Joined New Job</asp:ListItem>
                                    <asp:ListItem>Satisfied in the Current Job</asp:ListItem>
                                    <asp:ListItem>Looking For the Freelancing Work</asp:ListItem>
                                    <asp:ListItem>Looking for the Part Time Work</asp:ListItem>
                                    <asp:ListItem>Serving Notice Period</asp:ListItem>
                                    <asp:ListItem>Unemployed</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Total Experience
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlWorkExperienceMin" runat="server">
                                    <asp:ListItem>Min</asp:ListItem>
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
                            <asp:ListItem>Max</asp:ListItem>
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
                            <td>Current Annual Salary</td>
                            <td>
                                <asp:DropDownList ID="ddlCurrentSalaryMin" runat="server">
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
                                &nbsp;To
                        <asp:DropDownList ID="ddlCurrentSalaryMax" runat="server">
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
                            <td>Expected Annual Salary</td>
                            <td>
                                <asp:DropDownList ID="ddlExpectedSalaryMin" runat="server">
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
                                &nbsp;To
                        <asp:DropDownList ID="ddlExpectedSalaryMax" runat="server">
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
                            <td>Current Country</td>
                            <td>
                                <asp:TextBox ID="txtCurrentCountry" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="autoExtenderCountry" runat="server" TargetControlID="txtCurrentCountry" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCountry" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Current State</td>
                            <td>
                                <asp:TextBox ID="txtCurrentState" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="autoExtenderState" runat="server" TargetControlID="txtCurrentState" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetState" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Current Location</td>
                            <td>
                                <asp:TextBox ID="txtCurrentCity" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="autoExtenderCity" runat="server" TargetControlID="txtCurrentCity" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCity" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Preferred Country</td>
                            <td>
                                <asp:TextBox ID="txtPreffredCountry" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="autoExtenderPreffredCountry" runat="server" TargetControlID="txtPreffredCountry" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCountry" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Preferred State</td>
                            <td>
                                <asp:TextBox ID="txtPreferredState" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="autoExtenderPreferredState" runat="server" TargetControlID="txtPreferredState" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetState" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Preferred Location</td>
                            <td>
                                <asp:TextBox ID="txtPreferredCity" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender3" runat="server" TargetControlID="txtPreferredCity" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCity" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Notice Period </td>
                            <td>
                                <asp:DropDownList ID="ddlNoticePeriod" runat="server">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Immediate</asp:ListItem>
                                    <asp:ListItem>7 Days</asp:ListItem>
                                    <asp:ListItem>15 Days</asp:ListItem>
                                    <asp:ListItem>30 Days</asp:ListItem>
                                    <asp:ListItem>45 Days</asp:ListItem>
                                    <asp:ListItem>60 Days</asp:ListItem>
                                    <asp:ListItem>90 Days</asp:ListItem>
                                    <asp:ListItem>No Notice Period</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table>
                        <tr>
                            <td>
                                <h3>Employment Details</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>Industry</td>
                            <td>
                                <asp:DropDownList ID="ddlIndustry" runat="server">
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
                            <td>Functional Area </td>
                            <td>
                                <asp:DropDownList ID="ddlFunctionalArea" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Keyword Role Skills</td>
                            <td>
                                <asp:TextBox ID="txtRoleSkills" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtRoleSkills" MinimumPrefixLength="1"
                                    EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetRoles" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true">
                                </cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Keyword Technical Skills </td>
                            <td>
                                <asp:TextBox ID="txtTechnicalSkills" runat="server"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtTechnicalSkills" MinimumPrefixLength="1" EnableCaching="false"
                                    CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetTechnicalskill" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true">
                                </cc1:AutoCompleteExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>Include Employers
                            </td>
                            <td>
                                <asp:TextBox ID="txtIncludeEmployer" runat="server"></asp:TextBox>
                                <asp:DropDownList ID="ddlInclude" runat="server">
                                    <asp:ListItem>Current Employer</asp:ListItem>
                                    <asp:ListItem>Previous Employer</asp:ListItem>
                                    <asp:ListItem>Current/Previous Employer</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Exclude Employers
                            </td>
                            <td>
                                <asp:TextBox ID="txtExcludeEmployer" runat="server"></asp:TextBox>
                                <asp:DropDownList ID="ddlExclude" runat="server">
                                    <asp:ListItem>Current Employer</asp:ListItem>
                                    <asp:ListItem>Previous Employer</asp:ListItem>
                                    <asp:ListItem>Current/Previous Employer</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Designation
                            </td>
                            <td>
                                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
                                <asp:DropDownList ID="ddlDesignation" runat="server">
                                    <asp:ListItem>Current Employer</asp:ListItem>
                                    <asp:ListItem>Previous Employer</asp:ListItem>
                                    <asp:ListItem>Current/Previous Employer</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table>
                        <tr>
                            <td>
                                <h3>Educational Details</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>Highest Qualification</td>
                            <td>

                                <asp:DropDownList ID="DropDownList12" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Doctorate/ PHD Degree
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Masters Degree</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>PG Diploma</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Bachelors Degree</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>UG Diploma</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>HSC/12th</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>SSC/10th</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Certifications</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Workshops</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Language Known</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table>
                        <tr>
                            <td>
                                <h3>Affirmative Action</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>Women Candidates Only
                            </td>
                            <td>
                                <asp:CheckBox ID="chkWomenCandidates" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Male Candidates Only</td>
                            <td>
                                <asp:CheckBox ID="chkMaleCandidates" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Candidate with Special Abilities Only</td>
                            <td>
                                <asp:CheckBox ID="chkSpecialAbilities" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Candidate with Sports Abilities</td>
                            <td>
                                <asp:CheckBox ID="chkSportsAbilities" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table>
                        <tr>
                            <td>
                                <h3>Additional Details</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>Candidate Age
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlMinAge" runat="server">
                                    <asp:ListItem>Min</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>21</asp:ListItem>
                                    <asp:ListItem>22</asp:ListItem>
                                    <asp:ListItem>23</asp:ListItem>
                                    <asp:ListItem>24</asp:ListItem>
                                    <asp:ListItem>25</asp:ListItem>
                                    <asp:ListItem>26</asp:ListItem>
                                    <asp:ListItem>28</asp:ListItem>
                                    <asp:ListItem>29</asp:ListItem>
                                    <asp:ListItem>30</asp:ListItem>
                                    <asp:ListItem>31</asp:ListItem>
                                    <asp:ListItem>32</asp:ListItem>
                                    <asp:ListItem>33</asp:ListItem>
                                    <asp:ListItem>34</asp:ListItem>
                                    <asp:ListItem>35</asp:ListItem>
                                    <asp:ListItem>36</asp:ListItem>
                                    <asp:ListItem>37</asp:ListItem>
                                    <asp:ListItem>38</asp:ListItem>
                                    <asp:ListItem>39</asp:ListItem>
                                    <asp:ListItem>40</asp:ListItem>
                                     <asp:ListItem>41</asp:ListItem>
                                    <asp:ListItem>42</asp:ListItem>
                                    <asp:ListItem>43</asp:ListItem>
                                    <asp:ListItem>44</asp:ListItem>
                                    <asp:ListItem>45</asp:ListItem>
                                    <asp:ListItem>46</asp:ListItem>
                                    <asp:ListItem>47</asp:ListItem>
                                    <asp:ListItem>48</asp:ListItem>
                                    <asp:ListItem>49</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                </asp:DropDownList>
                                To
                            <asp:DropDownList ID="ddlMaxAge" runat="server">
                                <asp:ListItem>Max</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>21</asp:ListItem>
                                    <asp:ListItem>22</asp:ListItem>
                                    <asp:ListItem>23</asp:ListItem>
                                    <asp:ListItem>24</asp:ListItem>
                                    <asp:ListItem>25</asp:ListItem>
                                    <asp:ListItem>26</asp:ListItem>
                                    <asp:ListItem>28</asp:ListItem>
                                    <asp:ListItem>29</asp:ListItem>
                                    <asp:ListItem>30</asp:ListItem>
                                    <asp:ListItem>31</asp:ListItem>
                                    <asp:ListItem>32</asp:ListItem>
                                    <asp:ListItem>33</asp:ListItem>
                                    <asp:ListItem>34</asp:ListItem>
                                    <asp:ListItem>35</asp:ListItem>
                                    <asp:ListItem>36</asp:ListItem>
                                    <asp:ListItem>37</asp:ListItem>
                                    <asp:ListItem>38</asp:ListItem>
                                    <asp:ListItem>39</asp:ListItem>
                                    <asp:ListItem>40</asp:ListItem>
                                    <asp:ListItem>41</asp:ListItem>
                                    <asp:ListItem>42</asp:ListItem>
                                    <asp:ListItem>43</asp:ListItem>
                                    <asp:ListItem>44</asp:ListItem>
                                    <asp:ListItem>45</asp:ListItem>
                                    <asp:ListItem>46</asp:ListItem>
                                    <asp:ListItem>47</asp:ListItem>
                                    <asp:ListItem>48</asp:ListItem>
                                    <asp:ListItem>49</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                            </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Employment Status</td>
                            <td>
                                <asp:CheckBoxList ID="chklstEmploymentStatus" runat="server">
                                    <asp:ListItem>Full Time</asp:ListItem>
                                    <asp:ListItem>Part Time</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td>Job Type</td>
                            <td>
                                <asp:CheckBoxList ID="chklstJobType" runat="server">
                                     <asp:ListItem>Permanent</asp:ListItem>
                                    <asp:ListItem>Temporary</asp:ListItem>
                                    <asp:ListItem>Freelancing</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td>Active in last</td>
                            <td>
                                <asp:DropDownList ID="ddlActive" runat="server">
                                    <asp:ListItem>Select</asp:ListItem>
                                   
                                    <asp:ListItem>7 Days</asp:ListItem>
                                    <asp:ListItem>15 Days</asp:ListItem>
                                    <asp:ListItem>30 Days</asp:ListItem>
                                    <asp:ListItem>45 Days</asp:ListItem>
                                    <asp:ListItem>60 Days</asp:ListItem>
                                    <asp:ListItem>90 Days</asp:ListItem>
                                    <asp:ListItem>6 Months</asp:ListItem>
                                    <asp:ListItem>1 Year</asp:ListItem>
                                    <asp:ListItem>All Resume</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Work Permit For</td>
                            <td>
                                <asp:DropDownList ID="ddlWorkPermit" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <asp:Button ID="btnFindResume" runat="server" Text="Find Resume" OnClick="btnFindResume_Click" />
                </div>
            </asp:Panel>
            <asp:Panel ID="pnlKeywords" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>