<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewClientRequirementDetails.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewClientRequirementDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlNew" runat="server" Visible="false">
                <table>
                    <tr>
                        <td>
                            <h2>New Requirement</h2>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Name</td>
                        <td>
                            <asp:Label ID="lblClientName" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Profile</td>
                        <td>
                            <asp:Label ID="lblClientProfile" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Position Name</td>
                        <td>
                            <asp:Label ID="lblPositionName" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Industry</td>
                        <td>
                            <asp:Label ID="lblIndustry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Functional Area</td>
                        <td>
                            <asp:Label ID="lblFunctionalArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <asp:Label ID="lblAddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Country</td>
                        <td>
                            <asp:Label ID="lblCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>State</td>
                        <td>
                            <asp:Label ID="lblState" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>City </td>
                        <td>
                            <asp:Label ID="lblCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Area</td>
                        <td>
                            <asp:Label ID="lblArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Pincode</td>
                        <td>
                            <asp:Label ID="lblPincode" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Skill Sets</td>
                        <td>
                            <asp:Label ID="lblSkills" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Content</td>
                        <td>
                            <asp:Label ID="lblContent" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date Of Requirement Sent</td>
                        <td>
                            <asp:Label ID="lblDateOfRequirement" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Due Date</td>
                        <td>
                            <asp:Label ID="lblDueDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>

                <asp:Repeater ID="rptrContactPerson" runat="server">
                    <HeaderTemplate>
                        <table>
                            <tr style="background-color: #fb7700">
                                <h1>Client Contact Person</h1>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr style="background-color: #ffffff">
                            <td>
                                <table>
                                    <tr>
                                        <td>Name</td>
                                        <td>
                                            <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactPersonName")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Designation</td>
                                        <td>
                                            <asp:Label ID="lblDesignation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Designation") %>'></asp:Label>
                                    </tr>
                                    <tr>
                                        <td>Email</td>
                                        <td>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmailId")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Contact</td>
                                        <td>
                                            <asp:Label ID="lblContact" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactNo")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Active/ Inactive</td>
                                        <td>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IsActive") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </table>
                        </table>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
            <asp:Panel ID="pnlActive" runat="server" Visible="false">
                <table>
                    <tr>
                        <td>
                            <h2>Active Requirement</h2>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Name</td>
                        <td>
                            <asp:Label ID="lblActiveClientName" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Profile</td>
                        <td>
                            <asp:Label ID="lblActiveClientProfile" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Position Name</td>
                        <td>
                            <asp:Label ID="lblActivePosition" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Requirement ID</td>
                        <td>
                            <asp:Label ID="lblRequirementId" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Industry</td>
                        <td>
                            <asp:Label ID="lblActiveIndustry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Functional Area</td>
                        <td>
                            <asp:Label ID="lblActiveFunctionalArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <asp:Label ID="lblActiveAddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Country</td>
                        <td>
                            <asp:Label ID="lblActiveCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>State</td>
                        <td>
                            <asp:Label ID="lblActiveState" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>City </td>
                        <td>
                            <asp:Label ID="lblActiveCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Area</td>
                        <td>
                            <asp:Label ID="lblActiveArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Pincode</td>
                        <td>
                            <asp:Label ID="lblActivePincode" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Skill Sets</td>
                        <td>
                            <asp:Label ID="lblActiveSkills" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Content</td>
                        <td>
                            <asp:Label ID="lblActiveContent" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date Of Requirement Sent</td>
                        <td>
                            <asp:Label ID="lblActiveRequirementDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Due Date</td>
                        <td>
                            <asp:Label ID="lblActiveDueDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Position Closed</td>
                        <td>
                            <asp:Button ID="btnPositionClosed" runat="server" OnClick="btnPositionClosed_Click1" Text="Yes" />
                        </td>
                    </tr>
                </table>

                <asp:Repeater ID="rptrActiveRequirement" runat="server">
                    <HeaderTemplate>
                        <table>
                            <tr style="background-color: #fb7700">
                                <h1>Client Contact Person</h1>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr style="background-color: #ffffff">
                            <td>
                                <table>
                                    <tr>
                                        <td>Name</td>
                                        <td>
                                            <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactPersonName")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Designation</td>
                                        <td>
                                            <asp:Label ID="lblDesignation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Designation") %>'></asp:Label>
                                    </tr>
                                    <tr>
                                        <td>Email</td>
                                        <td>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmailId")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Contact</td>
                                        <td>
                                            <asp:Label ID="lblContact" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactNo")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Active/ Inactive</td>
                                        <td>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IsActive") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </table>
                        </table>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
            <asp:Panel ID="pnlInActive" runat="server" Visible="false">
                <table>
                    <tr>
                        <td>
                            <h2>InActive Requirement</h2>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Name</td>
                        <td>
                            <asp:Label ID="lblInActiveClientName" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Client Profile</td>
                        <td>
                            <asp:Label ID="lblInActiveClientProfile" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Position Name</td>
                        <td>
                            <asp:Label ID="lblInActivePositon" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Requirement ID</td>
                        <td>
                            <asp:Label ID="lblInActiveRequirementId" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Industry</td>
                        <td>
                            <asp:Label ID="lblInActiveIndustry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Functional Area</td>
                        <td>
                            <asp:Label ID="lblInActiveFunctionalArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <asp:Label ID="lblInActiveAddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Country</td>
                        <td>
                            <asp:Label ID="lblInActiveCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>State</td>
                        <td>
                            <asp:Label ID="lblInActiveState" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>City </td>
                        <td>
                            <asp:Label ID="lblInActiveCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Area</td>
                        <td>
                            <asp:Label ID="lblInActiveArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Pincode</td>
                        <td>
                            <asp:Label ID="lblInActivePincode" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Skill Sets</td>
                        <td>
                            <asp:Label ID="lblInActiveSkills" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Content</td>
                        <td>
                            <asp:Label ID="lblInActiveContent" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date Of Requirement Sent</td>
                        <td>
                            <asp:Label ID="lblInActiveRequirementSent" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Due Date</td>
                        <td>
                            <asp:Label ID="lblInActiveDueDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Date Of Closure</td>
                        <td>
                            <asp:Label ID="lblDateOfClosure" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>

                <asp:Repeater ID="rptrInActiveRequirement" runat="server">
                    <HeaderTemplate>
                        <table>
                            <tr style="background-color: #fb7700">
                                <h1>Client Contact Person</h1>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr style="background-color: #ffffff">
                            <td>
                                <table>
                                    <tr>
                                        <td>Name</td>
                                        <td>
                                            <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactPersonName")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Designation</td>
                                        <td>
                                            <asp:Label ID="lblDesignation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Designation") %>'></asp:Label>
                                    </tr>
                                    <tr>
                                        <td>Email</td>
                                        <td>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmailId")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Contact</td>
                                        <td>
                                            <asp:Label ID="lblContact" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ContactNo")%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Active/ Inactive</td>
                                        <td>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "IsActive") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </table>
                        </table>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
        </div>
    </form>
</body>
</html>