<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="WebApp.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 10%;
        }
        .auto-style2 {
            width: 947px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            margin-right: 0px;
        }
        .auto-style5 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style5">

                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="学号"></asp:Label>
                        <asp:TextBox ID="TextBoxSNO" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="姓名"></asp:Label>
                        <asp:TextBox ID="TextBoxSName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="ButtonQuery" runat="server" CssClass="auto-style3" Height="32px" OnClick="ButtonQuery_Click" Text="查  询" Width="75px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style4" ForeColor="#333333" GridLines="None" Width="944px">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="SNO" HeaderText="学号" />
                                <asp:BoundField DataField="SName" HeaderText="姓名" />
                                <asp:BoundField DataField="SSex" HeaderText="性别" />
                                <asp:BoundField DataField="SBirthday" HeaderText="出生日期" />
                                <asp:BoundField DataField="DeptName" HeaderText="所在院系" />
                                <asp:BoundField DataField="Address" HeaderText="住址" />
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
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="5">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
