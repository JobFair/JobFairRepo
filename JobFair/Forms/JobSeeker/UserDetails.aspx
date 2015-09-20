<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.UserDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/JobSeeker/ContactDetails.ascx" TagPrefix="uc1" TagName="ContactDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>






<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <br />
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1">
        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">                       
            <ContentTemplate>
                <updatepanel>
<uc1:ContactDetails runat="server" id="ContactDetails" />
</updatepanel>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
            <ContentTemplate>
                <updatepanel>
<uc1:ProfessionalDetails runat="server" id="ProfessionalDetails" ></uc1:ProfessionalDetails>
</updatepanel>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="TabPanel4">
            <ContentTemplate>
                <asp:Label ID="lblsession" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel5" runat="server" HeaderText="TabPanel5">
        </cc1:TabPanel>
    </cc1:TabContainer>
</asp:Content>