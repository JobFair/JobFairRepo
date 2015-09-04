<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
    <div style="width:70%">
      
        <fieldset>
            <div>
              <asp:LinkButton ID="lblFreshness" runat="server" Text="By Job Title" CssClass="label"></asp:LinkButton>
                <p>
                <asp:DropDownList ID="ddlFreshers" runat="server" DataTextField="Freshers"></asp:DropDownList>
               </p>
                </div>
            <div>
              <asp:LinkButton ID="lblCompanyName" runat="server" Text="By Company Name" CssClass="label" ></asp:LinkButton>
                </div>
            <div>
              <asp:LinkButton ID="lblLocation" runat="server" Text="By Location" CssClass="label" ></asp:LinkButton>
                </div>
            <div>
              <asp:LinkButton ID="lblKeySkills" runat="server" Text="Key Skill" CssClass="label" ></asp:LinkButton>
                </div>
            <div>
            <asp:LinkButton ID="lblDescription" runat="server" Text="DEscription" CssClass="label" ></asp:LinkButton>
            </div>
            <asp:Repeater ID="SearchResult" runat="server">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div>
                        <div>Job Title: <strong><%# Eval("Title") %></div>
                        <div>Company Name: <strong><%# Eval("CompanyName") %> </div>
                        <div style="width:50%">Experience <strong><%# Eval("ExperienceYears") %> </div>
                        <div style="width:50%">Location <strong><%# Eval("jobLocation") %> </div>
                        <div>Key Skills: <strong><%# Eval("Skills") %></div>
                        <div>Description: <strong><%# Eval("Description") %></div>
                    </div>
                    </ItemTemplate>
                <AlternatingItemTemplate>
                     <div>
                        <div>Job Title: <strong><%# Eval("Title") %></div>
                        <div>Company Name: <strong><%# Eval("CompanyName") %> </div>
                        <div style="width:50%">Experience <strong><%# Eval("ExperienceYears") %> </div>
                        <div style="width:50%">Location <strong><%# Eval("jobLocation") %> </div>
                        <div>Key Skills: <strong><%# Eval("Skills") %></div>
                        <div>Description: <strong><%# Eval("Description") %></div>
                    </div>
                </AlternatingItemTemplate>
                  </asp:Repeater>
        </fieldset>
    </div>

</asp:Content>
