<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
       <asp:Repeater ID="Repeater1" runat="server">
                
                   <HeaderTemplate>
                      
                </HeaderTemplate>
                 <ItemTemplate>
                     <table>
                         <tr>
                             <td>
                                 <%--<img src='<%# "~/images/" + Container.DataItem.ToString() %>' runat="server" />--%>
                                 <asp:Image ID="Image1" runat="server"  Height="100px" Width="100px"/><br />
                             </td>

                             <td>
                                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("RecruiterfullName")%>'></asp:Label><br />
                               <asp:Label ID="Label2" runat="server" Text='<%#Eval("Company")%>'></asp:Label><br />
                               <asp:Label ID="Label3" runat="server" Text='<%#Eval("MobileNumber")%>'></asp:Label><br />
                               <asp:Label ID="Label4" runat="server" Text='<%#Eval("OficialEmail_ID")%>'></asp:Label><br />
                            </td>
                         </tr>
                     </table>
                 </ItemTemplate>
            </asp:Repeater>
       
       
       
    </div>
    </div>
    </form>
</body>
</html>
