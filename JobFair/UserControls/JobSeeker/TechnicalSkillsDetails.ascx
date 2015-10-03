<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TechnicalSkillsDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.TechnicalSkillsDetails" %>
<div style="border:solid; margin-left:150px; margin-right:150px">
    <div style="margin-left:60px; margin-right:60px">
    <h3>Languages</h3>
    <asp:CheckBoxList ID="chkTechnicalLanguage" runat="server" DataTextField="TechnicalSkillName" DataValueField="TechnicalSkillId" RepeatDirection="Horizontal" CellSpacing="15" CellPadding="15" RepeatColumns="6"></asp:CheckBoxList>
   
    <h3>Database</h3>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="TechnicalSkillName" DataValueField="TechnicalSkillId" RepeatDirection="Horizontal" CellSpacing="15" CellPadding="15" RepeatColumns="6"></asp:CheckBoxList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JobFairPortalConnectionString2 %>" SelectCommand="SELECT * FROM [TechnicalSkillsDetails] WHERE ([TechnicalSkillTypeId] = @TechnicalSkillTypeId)">
        <SelectParameters>
            <asp:Parameter DefaultValue="2" Name="TechnicalSkillTypeId" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <h3>
    Softwares
    </h3>
    <asp:CheckBoxList ID="CheckBoxList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="TechnicalSkillName" DataValueField="TechnicalSkillId" RepeatDirection="Horizontal" CellSpacing="15" CellPadding="15" RepeatColumns="6"></asp:CheckBoxList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:JobFairPortalConnectionString3 %>" SelectCommand="SELECT * FROM [TechnicalSkillsDetails] WHERE ([TechnicalSkillTypeId] = @TechnicalSkillTypeId)">
        <SelectParameters>
            <asp:Parameter DefaultValue="3" Name="TechnicalSkillTypeId" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <h3>Operating System</h3>
    <asp:CheckBoxList ID="CheckBoxList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="TechnicalSkillName" DataValueField="TechnicalSkillId" RepeatDirection="Horizontal" CellSpacing="15" CellPadding="15" RepeatColumns="6"></asp:CheckBoxList>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:JobFairPortalConnectionString4 %>" SelectCommand="SELECT * FROM [TechnicalSkillsDetails] WHERE ([TechnicalSkillTypeId] = @TechnicalSkillTypeId)">
        <SelectParameters>
            <asp:Parameter DefaultValue="4" Name="TechnicalSkillTypeId" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</div></div>