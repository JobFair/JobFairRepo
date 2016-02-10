<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageEmployer.aspx.cs" Inherits="JobFair.Forms.HR.ManageEmployer" %>

<script type="text/javascript">
    function SetTarget() {
        document.forms[0].target = "_blank";
    }
</script>

<style type="text/css">
    .GridView1 tbody tr th {
        vertical-align: central !important;
        text-align: center !important;
    }
</style>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmManageEmployer" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <div id="divMain" runat="server" style="min-height: 500px; width: 100%; padding: 10px">
            <h2 style="align-content: center">Manage Employer </h2>

            <asp:LinkButton ID="lnkBtnNewClientDetails" runat="server" Text="Add New Employer" OnClick="lnkBtnNewEmployerDetails_Click" OnClientClick="SetTarget();" Font-Bold="true" style="align-content:center"></asp:LinkButton>
            <br /><br />
            <asp:Repeater ID="repEmployerDetails" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td style="float: left; width: 70%">
                                <center><b>Employer Details</b></center>
                            </td>
                            <td style="float: right; width: 20%">
                                <center><b>Manage Employer Details</b></center>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                     <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: left; width: 60%">
                        
                            <asp:Label ID="lblEmployerId" runat="server" Text='<%#Eval("EmployerId")%>' Visible="false" />
                            <asp:Label ID="lblHrId" runat="server" Text='<%#Eval("HrId")%>' Visible="false" /></td>
                        <tr>
                            <td>Employer HR Full Name:
                                <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmployerHRFullName")%>' Font-Bold="true" /></td>   
                            <td>Company Name:
                                        <asp:Label ID="lblClientProfile" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyName")%>' /></td>
                        </tr>
                        <tr>   
                            <td>Company Contact Number:
                                        <asp:Label ID="lblIndustry" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyContactNumber")%>' /></td>
                        </tr>
                        <tr>
                            <td>Official Email Id:
                                        <asp:Label ID="lblFunctionalArea" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "OfficialEmailId")%>' /></td>
                        </tr>
                         <tr>
                            <td>Status:
                                        <asp:Label ID="Label1" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "Status")%>' /></td>
                        </tr>
                    </table>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: right; width: 40%">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnViewEmployer" runat="server" Text="View Employer Details" OnClick="lnkBtnViewEmployer_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnEditEmployer" runat="server" Text="Edit/Modify Employer Details" OnClick="lnkBtnEditEmployer_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <%--<tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnDeleteEmployer" runat="server" Text="Delete Employer" OnClick="lnkBtnDeleteEmployer_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnEmployerRequirement" runat="server" Text="Employer Requirement" OnClick="lnkBtnEmployerRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%--<asp:LinkButton ID="lnkBtnEditClientRequirement" runat="server" Text="Edit/Modify Client Requirement" OnClick="lnkBtnEditClientRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>--%>
                                <asp:LinkButton ID="lnkBtnViewEmployerRequirement" runat="server" Text="View Employer Requirement" OnClick="lnkBtnViewEmployerRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <FooterTemplate>

                </FooterTemplate>
            </asp:Repeater>
    </div>
    </form>
</body>
</html>
