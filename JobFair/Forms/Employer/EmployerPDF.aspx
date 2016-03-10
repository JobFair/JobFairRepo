<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployerPDF.aspx.cs" Inherits="JobFair.Forms.Employer.EmployerPDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="panel1" runat="server">
        <asp:Repeater ID="rptremployerdetails" runat="server">

            <ItemTemplate>
                <table>
                    <tr>
                        <td>HrId:
                            <asp:Label ID="lblhrid" runat="server" Text='<%#Eval("HrId") %>' Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr> Company Name:
                        <td>
                             <asp:Label ID="Label1" runat="server" Text='<%#Eval("CompanyName") %>' Visible="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td> Company Profile:
                             <asp:Label ID="Label2" runat="server" Text='<%#Eval("CompanyProfile") %>' Visible="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>EmployerFull Name
                             <asp:Label ID="Label3" runat="server" Text='<%#Eval("EmployerHRFullName") %>' Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>CompanyContactNumber:
                             <asp:Label ID="Label4" runat="server" Text='<%#Eval("CompanyContactNumber") %>' Visible="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>MobileNumber:
                         <asp:Label ID="Label5" runat="server" Text='<%#Eval("MobileNumber") %>' Visible="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>OfficialEmailId:
                              <asp:Label ID="Label6" runat="server" Text='<%#Eval("OfficialEmailId") %>' Visible="true"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>
       
    </asp:Panel>
         <asp:Button  ID="btngeneratepdf" Text="GeneratePDF" runat="server" OnClick="btngeneratepdf_Click"/>
    </div>
    </form>
</body>
</html>
