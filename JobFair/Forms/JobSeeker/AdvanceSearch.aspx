<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblSkill" runat="server" Text="Key Skill"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtKeyskill" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblWork" runat="server" Text="Work Exprience"></asp:Label>
            </td>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlworkexpyear" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblYear" runat="server" Text="Year"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlMonth" runat="server">
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMonth" runat="server" Text="Month"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;
                &nbsp;
                </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblSalary" runat="server" Text="Expected Salary"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMin" runat="server">
                </asp:DropDownList>
&nbsp;
                <asp:Label ID="lblMin" runat="server" Text="Min"></asp:Label>
&nbsp;
                <asp:DropDownList ID="ddlMax" runat="server">
                </asp:DropDownList>
&nbsp;&nbsp;
                <asp:Label ID="lblMax" runat="server" Text="Max"></asp:Label>
&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblIndustry" runat="server" Text="Industry"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIndustry" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblJobCategory" runat="server" Text="Job Category"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblJobType" runat="server" Text="Job Type"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlJobtype" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="Btnsearch_Click1" />
                <br />
                <br />
                <asp:Label ID="lblcount" runat="server" Text="Count"></asp:Label>
                <br />
                <br />
                <br />
            </td>
        </tr>

        <asp:Repeater ID="Reapetor1" runat="server">
            <Headertemplate><table width="100%"><tr><th>KeySkill</th><th>Location</th><th>WorkExprienceYear</th><th>WorkExprienceMonth</th><th>JobSalaryMin</th><th>JobSalaryMax</th><th>Industry</th><th>Job Category</th><th>Job Type</th>
             </tr></Headertemplate>
            <Itemtemplate> 
             <td><%#DataBinder.Eval(Container.DataItem,"KeySkill") %></td>
                 <td><%#DataBinder.Eval(Container.DataItem,"Location") %></td>
                     <td><%#DataBinder.Eval(Container.DataItem,"WorkExprienceYear") %></td>
                       <td><%#DataBinder.Eval(Container.DataItem,"WorkExprienceMonth") %></td>
                           <td><%#DataBinder.Eval(Container.DataItem,"JobSalaryMin") %></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"JobSalaryMax") %></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"Industry") %></a></td>
                                     <td><%#DataBinder.Eval(Container.DataItem,"JobCategory") %></td>
                                          <td><%#DataBinder.Eval(Container.DataItem,"JobType") %></td>
                                        


            </Itemtemplate>
            <AlternatingItemTemplate>
                 <td><%#DataBinder.Eval(Container.DataItem,"KeySkill") %></td>
                 <td><%#DataBinder.Eval(Container.DataItem,"Location") %></td>
                     <td><%#DataBinder.Eval(Container.DataItem,"WorkExprienceYear") %></td>
                       <td><%#DataBinder.Eval(Container.DataItem,"WorkExprienceMonth") %></td>
                           <td><%#DataBinder.Eval(Container.DataItem,"JobSalaryMin") %></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"JobSalaryMax") %></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"Industry") %></a></td>
                                     <td><%#DataBinder.Eval(Container.DataItem,"JobCategory") %></td>
                                          <td><%#DataBinder.Eval(Container.DataItem,"JobType") %></td>
                                        
            </AlternatingItemTemplate>
            <FooterTemplate></table></FooterTemplate>

            </asp:Repeater>
    </table>

    

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 326px;
        }
    </style>
</asp:Content>

