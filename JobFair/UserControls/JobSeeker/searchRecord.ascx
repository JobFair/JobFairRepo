<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="searchRecord.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.searchRecord" %>
<script src="../../NewFolder1/jquery-1.11.1.min%20(1).js"></script>
<table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblbasicdetails" runat="server" style="font-weight: 700" Text="BasicDetails"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdbbooleansearch" runat="server" Text="BooleanSearch" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbkeywords" runat="server" Text="Keywords" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords" runat="server" Text="Any Of The KeyWords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtkeywords" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords1" runat="server" Text="All Of The KeyWords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtallkeywords" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblkeywords2" runat="server" Text="Excluding Keywords"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtexcludingkeywords" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblsearch" runat="server" Text="Search In"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbresumetitle" runat="server" Text="ResumeTitle" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbkeyskills" runat="server" Text="Resume Title And KeySkill" />
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbsynopsis" runat="server" Text="Resume Synopsis" />
&nbsp;<asp:RadioButton ID="rdbentireresume" runat="server" Text="Entire Resume" />
                </td>
            </tr>
    <asp:GridView ID="GridView1" runat="server">
        <Columns> </Columns>
    </asp:GridView>
      <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="quicksearch.js"></script>
    <script type="text/javascript">
        $(function () {
            $('.search_textbox').each(function (i) {
                $(this).quicksearch("[id*=GridView1] tr:not(:has(th))", {
                    'testQuery': function (query, txt, row) {
                        return $(row).children(":eq(" + i + ")").text().toLowerCase().indexOf(query[0].toLowerCase()) != -1;
                    }
                });
            });
        });
    </script>
        </table>