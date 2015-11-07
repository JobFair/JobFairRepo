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
              <asp:TextBox ID="txtWorkshopName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblIns" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopInstitute" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblDur" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopDuration" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblYOC" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
              <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="true"></asp:DropDownList>
              <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGrade" runat="server" Text="Grade"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtworkspGrade" runat="server"></asp:TextBox>
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
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Year Of Completion" DataField="YearOfCompletion" />
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
