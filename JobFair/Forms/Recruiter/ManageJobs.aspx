<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageJobs.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageJobs" %>

<script type="text/javascript">
    function SetTarget() {
        document.forms[0].target = "_blank";
    }
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <div id="divMain" runat="server" style="min-height: 500px; width: 100%; padding: 10px">
            <h2 style="align-content: center">Manage Jobs </h2>

            <asp:Repeater ID="repJobsDetails" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td style="float: left; width: 70%">
                                <center><b>Jobs Details</b></center>
                            </td>
                            <td style="float: right; width: 20%">
                                <center><b>Manage Profile</b></center>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: left; width: 80%">
                        
                            <asp:HiddenField ID="hfJobID" runat="server" Value='<%#Eval("JobId")%>' />
                            <asp:HiddenField ID="hRecruiterIDf" runat="server" Value='<%#Eval("RecruiterID")%>' />
                            <asp:Label ID="lblJobID" runat="server" Text='<%#Eval("JobId") %>' Visible="false" /></td>
                        <tr>
                            <td>Job Title:
                                <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("JobTitle") %>' Font-Bold="true" /></td>
                            <td>Location:
                                        <asp:Label ID="lblLocation" runat="server" Font-Bold="true" Text='<%#Eval("JobLocationCity") %>' /></td>
                        </tr>
                        <tr>
                            <td>Functional Area:
                                        <asp:Label ID="lblFunctionalArea" runat="server" Font-Bold="true" Text='<%#Eval("FunctionalAreaId") %>' /></td>
                            <td>Experience:
                                        <asp:Label ID="lblExperience" runat="server" Font-Bold="true" Text='<%#Eval("WorkExperience") %>' /></td>
                        </tr>
                        <tr>
                            <td>Gender:
                                        <asp:Label ID="lblGender" runat="server" Font-Bold="true" Text='<%#Eval("Gender") %>' /></td>
                            <td>No Of Vacancy:
                                        <asp:Label ID="lblNoOfVacancy" runat="server" Font-Bold="true" Text='<%#Eval("NumberOfVacancies") %>' /></td>
                        </tr>
                        <tr>
                            <td>Salary(Per Anum):
                                        <asp:Label ID="lblSalaryMin" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />
                                -
                                        <asp:Label ID="lblSalaryMax" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMax") %>' /></td>
                            <td>Posted Date:
                                        <asp:Label ID="lblPostedDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate", "{0:dd MMM yyyy H:mm:ss}") %>' /></td>
                        </tr>
                    </table>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: right; width: 20%">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnViewJob" runat="server" Text="View Job" OnClick="lnkBtnViewJob_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnEdit" runat="server" Text="Edit/Modify Job" OnClick="lnkBtnEditJob_Click" ></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnDelete" runat="server" Text="Delete Job" PostBackUrl="~/Forms/Recruiter/LogIn.aspx"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnRepost" runat="server" Text="Clone/Repost Job" OnClick="lnkBtnRepost_Click"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <FooterTemplate>
                </FooterTemplate>
            </asp:Repeater>
        </div>

        <div id="divViewJob" runat="server" style="min-height: 500px; width: 100%; padding: 10px" visible="false">

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <%--<h2 style="align-content: center">Jobs Details</h2>--%>
                <ContentTemplate>
                    <asp:GridView ID="gvViewJob" runat="server" AutoGenerateColumns="false" Width="100%"
                        Font-Names="Arial" Font-Size="11pt" AlternatingRowStyle-BackColor="#C2D69B"
                        HeaderStyle-BackColor="#FF6600" AllowPaging="true" ShowFooter="true"
                        OnPageIndexChanging="OnPaging" OnRowEditing="EditCustomer"
                        OnRowUpdating="UpdateCustomer" OnRowCancelingEdit="CancelEdit"
                        PageSize="10">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Job Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblJobID" runat="server" Text='<%# Eval("JobId")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Job Title">
                                <ItemTemplate>
                                    <asp:Label ID="lblJobTitle" runat="server" Text='<%# Eval("JobTitle")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtJobTitle" runat="server" Text='<%# Eval("JobTitle")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Location">
                                <ItemTemplate>
                                    <asp:Label ID="lblLocation" runat="server" Text='<%# Eval("JobLocationCity")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtLocation" runat="server" Text='<%# Eval("JobLocationCity")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Functional Area">
                                <ItemTemplate>
                                    <asp:Label ID="lblFunctionalAreaId" runat="server" Text='<%# Eval("FunctionalAreaId")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtFunctionalAreaId" runat="server" Text='<%# Eval("FunctionalAreaId")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Work Experience">
                                <ItemTemplate>
                                    <asp:Label ID="lblWorkExperience" runat="server" Text='<%# Eval("WorkExperience")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtWorkExperience" runat="server" Text='<%# Eval("WorkExperience")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Gender">
                                <ItemTemplate>
                                    <asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtGender" runat="server" Text='<%# Eval("Gender")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Number Of Vacancies">
                                <ItemTemplate>
                                    <asp:Label ID="lblNumberOfVacancies" runat="server" Text='<%# Eval("NumberOfVacancies")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtNumberOfVacancies" runat="server" Text='<%# Eval("NumberOfVacancies")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Offered Annual Salary Min">
                                <ItemTemplate>
                                    <asp:Label ID="lblOfferedAnnualSalaryMin" runat="server" Text='<%# Eval("OfferedAnnualSalaryMin")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtOfferedAnnualSalaryMin" runat="server" Text='<%# Eval("OfferedAnnualSalaryMin")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Offered Annual Salary Max">
                                <ItemTemplate>
                                    <asp:Label ID="lblOfferedAnnualSalaryMax" runat="server" Text='<%# Eval("OfferedAnnualSalaryMax")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtOfferedAnnualSalaryMax" runat="server" Text='<%# Eval("OfferedAnnualSalaryMax")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Posted Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblPostedDate" runat="server" Text='<%# Eval("PostedDate", "{0:dd MMM yyyy}")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtPostedDate" runat="server" Text='<%# Eval("PostedDate")%>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <%--  <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                            <asp:BoundField DataField="JobLocationCity" HeaderText="Location" />
                            <asp:BoundField DataField="FunctionalAreaId" HeaderText="Functional Area" />
                            <asp:BoundField DataField="WorkExperience" HeaderText="Work Experience" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="NumberOfVacancies" HeaderText="Number Of Vacancies" />
                            <asp:BoundField DataField="OfferedAnnualSalaryMin" HeaderText="Offered Annual Salary Min" />
                            <asp:BoundField DataField="OfferedAnnualSalaryMax" HeaderText="Offered Annual Salary Max" />
                            <asp:BoundField DataField="PostedDate" HeaderText="Posted Date" />--%>

                           <%-- <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkBtnRemove" runat="server" CommandArgument='<%# Eval("JobId")%>'
                                        OnClientClick="return confirm('Do you want to delete?')"
                                        Text="Delete" OnClick="DeleteCustomer" Visible="true"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            
                            <asp:CommandField ShowEditButton="true"/>
                            
                        </Columns>
                      <%--  <AlternatingRowStyle BackColor="#C2D69B" />--%>
                    </asp:GridView>
                </ContentTemplate>
           <%--     <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="gvViewJob" />
                </Triggers>--%>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>