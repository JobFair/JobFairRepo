<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PassportDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.PassportDetails" %>
<style type="text/css">

table {
    background-color:lightgray;
    color:black;
    table-layout:auto;
    background-color: #CCCCCC;
    }
</style>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblpass" runat="server" Text="Passport Number" Visible="false"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassportNo" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPassportValidity" runat="server" Text="Validity" Visible="false"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtValidity" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            
