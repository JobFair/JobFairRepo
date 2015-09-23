<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- <div>
       <asp:Repeater ID="Repeater1" runat="server">

                   <HeaderTemplate>
                </HeaderTemplate>
                 <ItemTemplate>
                     <table>
                         <tr>
                             <td>
                                 <%--<img src='<%# "~/images/" + Container.DataItem.ToString() %>' runat="server" />
                                 <asp:Image ID="Image1" runat="server"  Height="100px" Width="100px" /><br />
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
    </div>--%>
             <table >
           <tr>
             <asp:Image ID="Image1" runat="server"  Height="100px" Width="100px" ImageUrl="<%=photo %>" />
               <asp:Image ID="Img" runat ="server" Height="100px" Width="100px" ImageUrl="~/Images/L1-whte.jpg" />           </tr>
                  <tr>
               <td>
                   <span>
                  Name </span> </td>
               <td>
                   <%= name %></td>
           </tr>
            <tr>
               <td>
                   <span>
                Company Name </span> </td>
               <td>
                   <%= companyName %></td>
           </tr>
                 <tr>
               <td>
                  <span >  Mobile</span></td>
               <td >
                   <%=mobNo %></td>
           </tr>
                  <tr>
               <td>
                  <span>  E-Mail</span></td> 
               <td>
                   <asp:Label ID="Label1" runat="server" ><%= emailId %></asp:Label>
                   </td>
           </tr>
           <tr>
               <td>
                  <span>  City</span></td>
               <td >
                   <%=city %></td>
           </tr>
          
           
          
       </table>
        </div>
    </form>
</body>
</html>