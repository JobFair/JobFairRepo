<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.UserDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<%@ Register src="../../UserControls/JobSeeker/PersonalDetails.ascx" tagname="PersonalDetails" tagprefix="uc1" %>
<%@ Register src="../../UserControls/JobSeeker/ContactDetails.ascx" tagname="ContactDetails" tagprefix="uc2" %>


<%@ Register src="../../UserControls/JobSeeker/ProfessionalDetails.ascx" tagname="ProfessionalDetails" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="80%">
        <cc1:TabPanel runat="server" HeaderText="Contact Details" ID="TabPanelContactdetails" Width="80%">
           
            <ContentTemplate>
                <uc2:ContactDetails ID="ContactDetails1" runat="server" >
                    
                </uc2:ContactDetails>
            </ContentTemplate>
           
        </cc1:TabPanel>
        
        <cc1:TabPanel ID="TabPanelPersonalDetails" runat="server" HeaderText="Personal Details">
            <ContentTemplate>
                <uc1:PersonalDetails ID="PersonalDetails1" runat="server" />
            </ContentTemplate>
        </cc1:TabPanel>
    <cc1:TabPanel ID="TabPanelProfDetails" runat="server" HeaderText="Professional Details">
        <ContentTemplate>
            
            <uc3:ProfessionalDetails ID="ProfessionalDetails1" runat="server" />
            
        </ContentTemplate>
    </cc1:TabPanel>    
    </cc1:TabContainer>
    
    </asp:Content>
