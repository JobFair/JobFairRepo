<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Image ID="imgCandidate" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Candidate Name
                </td>
                <td>
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>EmailId
                </td>
                <td>
                    <asp:Label ID="lblEmailId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Contact details
                </td>
                <td>
                    <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Education
                </td>
                <td>
                    <asp:Label ID="lblEducation" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">Last Upadated on
                    <asp:Label ID="lblLastupdated" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        ----------------------------------------------------------------------------------------------------------------------------------------------------
        <div id="Skills">
            <div>
                <table>
                    <tr>
                        <td colspan="2">
                            <b>Resume Title & Key skills</b>
                        </td>
                    </tr>
                    <tr>
                        <td>Resume Title
                        </td>
                        <td>
                            <asp:Label ID="lblResumeTitle" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Key Skills
                        </td>
                        <td>
                            <asp:Label ID="lblSkills" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" ID="btnResumeskills" Text="Update" />
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div>
                <table>
                    <tr>
                        <td colspan="2">
                            <b>Resume Title & Key skills</b>
                        </td>
                    </tr>
                    <tr>
                        <td>Resume Title
                        </td>
                        <td>
                            <asp:TextBox ID="txtResumeTitle" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Key Skills
                        </td>
                        <td>
                            <asp:TextBox ID="txtkeyskills" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmitSkills" runat="server" Text="Submit" />
                            <asp:Button ID="btnCancelSkills" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <br />
        <div id="Location">
            <div>
                <table>
                    <tr>
                        <td colspan="2"><b>Location</b></td>
                    </tr>
                    <tr>
                        <td>Current Location
                        </td>
                        <td>
                            <asp:Label ID="lblCurrentLocation" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Preferred Location
                        </td>
                        <td>
                            <asp:Label ID="lblPreferredLoaction" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnLoaction" runat="server" Text="Update" />
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div>
                <table>
                    <tr>
                        <td colspan="2"><b>Location</b></td>
                    </tr>
                    <tr>
                        <td>Current Location
                        </td>
                        <td>
                            <asp:TextBox ID="txtCurrentLocation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Preferred Location
                        </td>
                        <td>
                            <asp:TextBox ID="txtPreferredLoacation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmitLocation" runat="server" Text="Submit" />
                            <asp:Button ID="btnCancelLocation" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <br />
        <div id="PersonalDetails">
            <div>
                <table>
                    <tr>
                        <td colspan="2">
                            <b>Personal Details</b>
                        </td>
                    </tr>
                    <tr>
                        <td>Name
                        </td>
                        <td>
                            <asp:Label ID="lblName1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>EmailId for communication</td>
                        <td>
                            <asp:Label ID="lblCommunicationEmailId" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Login Mail Id</td>
                        <td>
                            <asp:Label ID="lblLoginMailId" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Mobile No
                        </td>
                        <td>
                            <asp:Label ID="lblMobileNo" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Age
                        </td>
                        <td>
                            <asp:Label ID="lblAge" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Address
                        </td>
                        <td>
                            <asp:Label ID="lblAdress" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnUpdatePersonal" runat="server" Text="Update" /></td>
                    </tr>
                </table>
                <br />
            </div>
            <div>
                <table>
                    <tr>
                        <td colspan="2">
                            <b>Personal Details</b>
                        </td>
                    </tr>
                    <tr>
                        <td>Name
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>EmailId for communication</td>
                        <td>
                            <asp:TextBox ID="txtComEmailid" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Login Mail Id</td>
                        <td>
                            <asp:TextBox ID="txtLoginmailId" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Mobile No
                        </td>
                        <td>
                            <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Age
                        </td>
                        <td>
                            <asp:TextBox ID="txtAgeDate" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Address
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmitPersonal" runat="server" Text="Submit" />
                            <asp:Button ID="btnCancelPersonal" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
                <br />
            </div>
        </div>

        <table>
            <tr>
                <td colspan="2">
                    <b>Employement Details</b>
                </td>
            </tr>
            <tr>
                <td>Work Experience
                </td>
                <td>
                    <asp:Label ID="lblWorkexperience" runat="server"></asp:Label>
                </td>
            </tr>            
            <tr>
                <td>Current Employer
                </td>
                <asp:Label ID="lblCurrentEmployer" runat="server"></asp:Label>
            </tr>
            <tr>
                <td>Last Employer
                </td>
                <td>
                    <asp:Label ID="lblLastEmployer1" runat="server"></asp:Label></td>
            </tr>
        <tr>
            <td>
                Designation
            </td>
            <td>
                <asp:Label ID="lblDesignation1" runat="server"></asp:Label>
            </td>
        </tr>  
            <tr>
                <td>
                    Total Experience
                </td>
                <td>
                    <asp:Label ID="lblTotalExp1" runat="server"></asp:Label>
                </td>
            </tr>  
        </table>
    </div>
</asp:Content>