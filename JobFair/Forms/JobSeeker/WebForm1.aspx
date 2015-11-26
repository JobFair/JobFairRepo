
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script src="../../Scripts/jquery-2.1.4.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
       
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       <div class="form-horizontal",role="form">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="User Name" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Password" CssClass="col-md-2 control-label"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Login" />
            </div>
        </div>
   
            <div class="form-control">
                <asp:Label ID="Label4" runat="server" CssClass="col-md-2 control-label" Text="First Name"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
               <div class="form-control">
                   <asp:Label ID="Label3" runat="server" Text="Last Name" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
           <div class="form-control">
                   <asp:Label ID="Label5" runat="server" Text="Email Id" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
            <div class="form-control">
                   <asp:Label ID="Label6" runat="server" Text="Gender" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
           <div class="form-control">
                   <asp:Label ID="Label7" runat="server" Text="Mobile No" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
          <div class="form-control">
                   <asp:Label ID="Label8" runat="server" Text="Password" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
         <div class="form-control">
                   <asp:Label ID="Label9" runat="server" Text="Confirm Password" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
            <div class="form-control">
                   <asp:Label ID="Label10" runat="server" Text="Current City" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
             <div class="form-control">
                   <asp:Label ID="Label11" runat="server" Text="Current Address" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                       <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
            <div class="form-control">
                   <asp:Label ID="Label12" runat="server" Text="Upload Resume" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                   </div>
               </div>
             <div class="form-control">
                   <asp:Label ID="Label13" runat="server" Text="Reference Mail Id" CssClass="col-md-2 control-label"></asp:Label>
                   <div class="col-md-3">
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
               </div>
            <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button2" runat="server" CssClass="btn btn-default" Text="Login" />
                <asp:Button ID="Button3" runat="server" Text="Cancel" CssClass="btn btn-danger" />
            </div>
        </div>
    </div>



        </form>
</body>
</html>