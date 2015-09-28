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
                <td>
                    Candidate Name
                </td>
                <td>
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    EmailId
                </td>
                <td>
                    <asp:Label ID="lblEmailId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Contact details
                </td>
                <td>
                    <asp:TextBox ID="txtContact" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Education
                </td>
                <td>
                    <asp:Label ID="lblEducation" runat="server"></asp:Label>
                </td>
            </tr>            
        </table>
        <br />  
     ----------------------------------------------------------------------------------------------------------------------------------------------------      
        <table>
            <tr>
                <td>
                    
                </td>
            </tr>
        </table>
    </div>        
</asp:Content>
