<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.UserDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register src="../../UserControls/JobSeeker/AffirmativeInfo.ascx" tagname="AffirmativeInfo" tagprefix="uc1" %>
<%@ Register src="../../UserControls/JobSeeker/EducationalDetails.ascx" tagname="EducationalDetails" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" Width="80%">
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1" Width="80%">
           
            <ContentTemplate>
                <uc1:AffirmativeInfo ID="AffirmativeInfo1" runat="server" />
            </ContentTemplate>
           
        </cc1:TabPanel>
        
        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
            <ContentTemplate>
                
                <uc2:EducationalDetails ID="EducationalDetails1" runat="server" />
                
            </ContentTemplate>
        </cc1:TabPanel>
        
    </cc1:TabContainer>

</asp:Content>
