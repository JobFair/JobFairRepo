<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.UserDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="80%">
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1" Width="80%">
           
        </cc1:TabPanel>
        
        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
        </cc1:TabPanel>
        
    </cc1:TabContainer>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

</asp:Content>
