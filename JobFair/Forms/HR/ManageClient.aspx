<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageClient.aspx.cs" Inherits="JobFair.Forms.HR.ManageClient" %>

<script type="text/javascript">
    function SetTarget()
    {
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
    <form id="frmManageClient" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <div id="divMain" runat="server" style="min-height: 500px; width: 100%; padding: 10px">
            <h2 style="align-content: center">Manage Client </h2>

            <asp:LinkButton ID="lnkBtnNewClientDetails" runat="server" Text="Add New Client" OnClick="lnkBtnNewClientDetails_Click" OnClientClick="SetTarget();" Font-Bold="true" style="align-content:center"></asp:LinkButton>
            <br /><br />
            <asp:Repeater ID="repClientDetails" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td style="float: left; width: 70%">
                                <center><b>Client Details</b></center>
                            </td>
                            <td style="float: right; width: 20%">
                                <center><b>Manage Client Details</b></center>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                     <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: left; width: 60%">
                        
                            <asp:Label ID="lblClientId" runat="server" Text='<%#Eval("ClientId")%>' Visible="false" />
                            <asp:Label ID="lblHrId" runat="server" Text='<%#Eval("HrId")%>' Visible="false" /></td>
                        <tr>
                            <td>Client Name:
                                <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName")%>' Font-Bold="true" /></td>   
                        </tr>
                        <tr>
                            <td>Client Profile:
                                        <asp:Label ID="lblClientProfile" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "ClientProfile")%>' /></td>
                        </tr>
                        <tr>   
                            <td>Industry:
                                        <asp:Label ID="lblIndustry" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "IndustryName")%>' /></td>
                        </tr>
                        <tr>
                            <td>Functional Area:
                                        <asp:Label ID="lblFunctionalArea" runat="server" Font-Bold="true" Text='<%# DataBinder.Eval(Container.DataItem, "FunctionalArea")%>' /></td>
                        </tr>
                    </table>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float: right; width: 40%">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnViewClient" runat="server" Text="View Client Details" OnClick="lnkBtnViewClient_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lnkBtnEditClient" runat="server" Text="Edit/Modify Client Details" OnClick="lnkBtnEditClient_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <%--<tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnDeleteClient" runat="server" Text="Delete Client" OnClick="lnkBtnDeleteClient_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnClientContactPerson" runat="server" Text="Client Contact Person" OnClick="lnkBtnClientContactPerson_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkBtnClientRequirement" runat="server" Text="Add Client Requirement" OnClick="lnkBtnClientRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>
                            </td>
                            <td>
                                <%--<asp:LinkButton ID="lnkBtnEditClientRequirement" runat="server" Text="Edit/Modify Client Requirement" OnClick="lnkBtnEditClientRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>--%>
                                <asp:LinkButton ID="lnkBtnViewClientRequirement" runat="server" Text="View Client Requirement" OnClick="lnkBtnViewClientRequirement_Click" OnClientClick="SetTarget();"></asp:LinkButton>
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
