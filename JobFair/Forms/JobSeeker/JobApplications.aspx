<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobApplications.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptrjobapplications" runat="server">
        <HeaderTemplate>
           <table cellspacing="4" rules="all" border="4">
            <tr>
                <th scope="col" style="width: 120px">
                  Apply Date
                </th>
                <th scope="col" style="width: 120px">
                   Candidate First Name
                </th>
                <th scope="col" style="width: 120px">
                  Candidate  Last Name
                </th>
                <th scope="col" style="width: 120px">
                    Candidate EmailId
                </th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
            <asp:Label ID="lbldate" runat="server" Text='<%#Eval("Date")%>'></asp:Label>
                    <td>
             <asp:Label ID="Label1" runat="server" Text='<%#Eval("FirstName")%>'></asp:Label>
                   </td>
                    <td>
             <asp:Label ID="Label2" runat="server" Text='<%#Eval("LastName")%>'></asp:Label>
                    </td>
                     <td> 
            <asp:Label ID="Label3" runat="server" Text='<%#Eval("EmailId")%>'></asp:Label>     
                    </td>
                    </tr>
          </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>