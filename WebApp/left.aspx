<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="WebApp.left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:steelblue;">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TreeView ID="TreeView1" runat="server">
            <Nodes>
                <asp:TreeNode Text="系统管理" Value="系统管理">
                    <asp:TreeNode Text="角色管理" Value="角色管理"></asp:TreeNode>
                    <asp:TreeNode Text="用户管理" Value="用户管理"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="档案管理" Value="档案管理">
                    <asp:TreeNode Text="学院信息" Value="学院信息"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/student.aspx" Target="mainFrame" Text="学生档案" Value="学生档案"></asp:TreeNode>
                    <asp:TreeNode Text="教师档案" Value="教师档案"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="课程管理" Value="课程管理">
                    <asp:TreeNode Text="课程信息" Value="课程信息"></asp:TreeNode>
                    <asp:TreeNode Text="学生选课" Value="学生选课"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Size="12pt" ForeColor="#FFFF99" Width="168px" Height="18px" />
        </asp:TreeView>
    </form>
</body>
</html>
