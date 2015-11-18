<%@ Page Title="" Language="C#"  AutoEventWireup="true" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

        <table>
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                   
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Image ID="imgCandidate" ImageUrl='<%#Eval("JS12","~/Images/{0}") %>' runat="server" Height="100px" ImageAlign="Right" Width="100px" />
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <%--</td>--%>
            </tr>
            <tr>
                <td>Candidate Name
                </td>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                    &nbsp;<asp:Label ID="lblLastName" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>EmailId
                </td>
                <td>
                    <asp:Label ID="lblEmailId" runat="server" Text='<%#Eval("EmailId") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Contact details
                </td>
                <td>
                   
                    <asp:Label ID="lblContact" runat="server" Text='<%#Eval("MobileNo") %>'></asp:Label>

                </td>
            </tr>
            <tr>
                <td>Highest Qualification</td>
                <td>
                    <asp:Label ID="lblHighestQualification" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Position Applied For</td>
                <td>
                    <asp:Label ID="lblPositionAppliedFor" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Current Company</td>
                <td>
                    <asp:Label ID="lblCurrentCompany" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Designation</td>
                <td>
                    <asp:Label ID="lblDesignation" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>From </td>
                <td>
                    <asp:Label ID="lblFromDate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Till</td>
                <td>
                    <asp:Label ID="lblTillDate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Total Experience</td>
                <td>
                    <asp:Label ID="lblTotalExperience" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Relevant Experience</td>
                <td>
                    <asp:Label ID="lblRelevantExperience" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Current CTC</td>
                <td>
                    <asp:Label ID="lblCurrentCTC" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Expected CTC</td>
                <td>
                    <asp:Label ID="ExpectedCTC" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Joining Period</td>
                <td>
                    <asp:Label ID="lblJoiningPeriod" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Reason for Job Change</td>
                <td>
                    <asp:Label ID="lblReasonForJobChange" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Current City</td>
                <td>
                    <asp:Label ID="lblCurrentCity" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Residing Area</td>
                <td>
                    <asp:Label ID="lblResidingArea" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Ready To Relocate</td>
                <td>
                    <asp:Label ID="lblReadyToRelocate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Preferable City</td>
                <td>
                    <asp:Label ID="lblPreferableCity" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Areas in Preferred City</td>
                <td>
                    <asp:Label ID="lblAreaInPreferredCity" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Availability for the Personal Round on Working Days</td>
                <td>
                    <asp:Label ID="lblAvailabiltyforPersonalRound" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Availability in Week Days</td>
                <td>
                    <asp:Label ID="lblAvailabilityInWeekDays" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Resume Details</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtResumeDetails" runat="server" Height="459px" ReadOnly="True" TextMode="MultiLine" Width="341px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnedit" runat="server" Height="27px" Text="Edit" Width="93px" />
                </td>
            </tr>
        </table>
    </div>
    <br />
    <br />

    <br />
    <br />
    <br />
    </asp:Content>
    




