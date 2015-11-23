<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreWorkshops.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreWorkshops" %>

<link href="../../Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<center>
<asp:Label ID="lblAddWork" runat="server" Text="Add MoreWorkshops" Font-Bold="true"></asp:Label>
</center>
<hr />
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="lblWorkshop" runat="server" Text="Workshop Name"></asp:Label></td>
        <td>
              <asp:TextBox ID="txtWorkshopName" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvWorkshopName" runat="server" ControlToValidate="txtWorkshopName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblIns" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopInstitute" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvWorkshopInstitute" runat="server" ControlToValidate="txtWorkshopInstitute" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblDur" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopDuration" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvWorkshopDuration" runat="server" ControlToValidate="txtWorkshopDuration" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlMonthFrom" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvYearFrom" runat="server" ControlToValidate="ddlYearFrom" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvMonthTo" runat="server" ControlToValidate="ddlMonthTo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvYearTo" runat="server" ControlToValidate="ddlYearTo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGrade" runat="server" Text="Grade"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtworkspGrade" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvworkspGrade" runat="server" ControlToValidate="txtworkspGrade" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </td>
        </tr>
          <tr>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add WorkShop" OnClick ="btnAdd_Click" style="margin-top: 10px; margin-left: 150px" />
        </td>
    </tr>
    </table>
     <div style="margin-top: 20px; margin-left: 10px;">
            <asp:HiddenField ID="hfCandidateId" runat="server" />
            <asp:GridView ID="grvAddMore" AutoGenerateColumns="false" runat="server" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField Visible="false" HeaderText="CandidateId" DataField="CandidateId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Workshop Name" DataField="WorkshopName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Workshop Institute" DataField="Institute" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Workshop Duration" DataField="Duration" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="From Year" DataField="FromYear" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="To Year" DataField="ToYear" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Workshop Grade" DataField="Grade" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <div style="margin-top: 10px; margin-left: 150px">
            <asp:Button ID="btnsubmitWorkshops" runat="server" Style="color: White"
                Text="Save Workshop" BackColor="#999966" OnClick="btnsubmitWorkshops_Click"/>
        </div>

<div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>
