using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormRoleRight : Form
    {
        private string _roleID = ""; //保存从窗体传过来的角色ID

        private string _roleName = ""; //保存从窗体传过来的角色名称

        //不可能经常改变权限，所以我们可以缓存一些数据到本地，不可能每次都去访问数据库
        private DataTable db_tree = new DataTable(); //缓存角色所有的权限以及角色拥有的权限

        //缓存之后速度会相差很大

        public FormRoleRight(string roleID, string roleName)
        {
            _roleID = roleID;
            _roleName = roleName;
            InitializeComponent();
        }

        private void FormRoleRight_Load(object sender, EventArgs e)
        {
            //设置窗体标题
            this.Text = "角色" + _roleName + "的权限设置";
            if (String.IsNullOrEmpty(_roleID))
                return;
            //根据roleID查询当前系统所有权限以及该角色已拥有的权限并保存到db_tree中
            studentMS.BLL.core bll = new studentMS.BLL.core();
            db_tree = bll.GetRoleRightList(_roleID).Tables[0];

            //创建根节点
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Tag = "0";
            root.Text = "系统权限";
            this.treeView1.Nodes.Add(root);

            //创建父节点的所有子节点
            this.CreateChildNode(root);

            this.treeView1.ExpandAll(); //展开所有节点
        }

        //创建子节点
        private void CreateChildNode(TreeNode parent)
        {
            //获取节点parentNode的所有子节点的相关信息
            DataRow[] rowList = db_tree.Select("ParentFID=" + parent.Tag);
            //循环 把所有的子节点都展示出来
            foreach (DataRow row in rowList)
            {
                TreeNode node = new TreeNode();
                node.Tag = row["FID"].ToString();
                node.Text = row["FName"].ToString();
                node.Checked = row["Have"].ToString() != "";
                parent.Nodes.Add(node);

                //递归调用
                this.CreateChildNode(node);
            }
        }

        private List<TreeNode> listNode = new List<TreeNode>(); //保存所有子节点

        //获取所有子节点
        private void getAllChildNode(TreeNode node)
        {
            listNode.Add(node);
            foreach (TreeNode item in node.Nodes)
            {
                this.getAllChildNode(item);
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            //是否确定要提交到数据库
            if (
                MessageBox.Show(
                    "您确定提交权限更新吗？",
                    "提交确认",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            )
            {
                bool commited = true;
                studentMS.BLL.b_roleright bll = new studentMS.BLL.b_roleright();
                studentMS.Model.b_roleright model = new studentMS.Model.b_roleright();

                this.getAllChildNode(this.treeView1.Nodes[0]);
                //遍历所有的节点
                foreach (TreeNode node in listNode)
                {
                    //如果节点被选中并且在数据库中不存在，那么就新增并更新到数据库中
                    if (node.Checked)
                    {
                        if (!bll.Exists(int.Parse(_roleID), node.Tag.ToString()))
                        {
                            model.RoleID = int.Parse(_roleID);
                            model.FID = node.Tag.ToString();
                            try
                            {
                                bll.Add(model);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                commited = false;
                            }
                        }
                    }
                    else
                    {
                        //如果节点没有被选中，并且数据库中存在，那么就删除该记录
                        if (bll.Exists(int.Parse(_roleID), node.Tag.ToString()))
                        {
                            try
                            {
                                bll.Delete(int.Parse(_roleID), node.Tag.ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                commited = false;
                            }
                        }
                    }
                }

                if (commited)
                    this.DialogResult = DialogResult.OK; //设置给主窗体返回值
            }
        }
    }
}
