﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewClientRequirements.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewClientRequirements" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" Width="900px" Height="600px">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="New Requirements">
                    <ContentTemplate>
                        <asp:GridView ID="grdViewRequirements" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">

                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                            <Columns>
                                <asp:TemplateField HeaderText="Position">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPosition" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Position")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Client Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location">
                                    <ItemTemplate>
                                        <asp:Label ID="lblLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CityName")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Skills">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSkillSets" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Skillsets")%>'></asp:Label>
                                        <asp:Label ID="lblClientId" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientId")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkbtnView" runat="server"  CommandArgument='<%#Eval("ClientRequirementId")%>'  OnClientClick="document.forms[0].target='_blank';" OnClick="lnkView_Click" CommandName="View">View</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>

                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Active Requirements">
                    <ContentTemplate>
                        <asp:GridView ID="grdActiveRequirement" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">

                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                            <Columns>
                                <asp:TemplateField HeaderText="Position">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPosition" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Position")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Client Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location">
                                    <ItemTemplate>
                                        <asp:Label ID="lblLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CityName")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Skills">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSkillSets" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Skillsets")%>'></asp:Label>
                                        <asp:Label ID="lblClientId" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientId")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkbtnView" runat="server"  CommandArgument='<%#Eval("ClientRequirementId")%>'  OnClientClick="document.forms[0].target='_blank';" OnClick="lnkView_Click" CommandName="View">View</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="InActive Requirements">
                    <ContentTemplate>
                         <asp:GridView ID="grdInActiveRequirements" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">

                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                            <Columns>
                                <asp:TemplateField HeaderText="Position">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPosition" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Position")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Client Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location">
                                    <ItemTemplate>
                                        <asp:Label ID="lblLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CityName")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Skills">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSkillSets" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Skillsets")%>'></asp:Label>
                                        <asp:Label ID="lblClientId" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientId")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkbtnView" runat="server"  CommandArgument='<%#Eval("ClientRequirementId")%>'  OnClientClick="document.forms[0].target='_blank';" OnClick="lnkView_Click" CommandName="View">View</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </ContentTemplate>
                </cc1:TabPanel>

               
            </cc1:TabContainer>
        </div>
    </form>
</body>
</html>