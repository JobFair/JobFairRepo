<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="ViewAllJobsDetails.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewAllJobsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
</asp:DetailsView>
<asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    </asp:Content>
