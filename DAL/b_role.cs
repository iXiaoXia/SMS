using System;
using System.Data;
using System.Text;
using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;

namespace studentMS.DAL
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public class b_role
    {
        public b_role() { }

        #region  Method

        /// <summary>
        /// 获取最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("RoleID", "b_role");
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        public bool Exists(int RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from b_role");
            strSql.Append(" where RoleID=?RoleID");
            MySqlParameter[] parameters = { new MySqlParameter("?RoleID", MySqlDbType.Int16) };
            parameters[0].Value = RoleID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 新增一条数据
        /// </summary>
        public int Add(studentMS.Model.b_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into b_role(");
            strSql.Append("RoleID,RoleName,Status)");
            strSql.Append(" values (");
            strSql.Append("?RoleID,?RoleName,?Status)");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?RoleID", MySqlDbType.Int16),
                new MySqlParameter("?RoleName", MySqlDbType.VarChar, 45),
                new MySqlParameter("?Status", MySqlDbType.Int16)
            };
            parameters[0].Value = model.RoleID;
            parameters[1].Value = model.RoleName;
            parameters[2].Value = model.Status;

            return DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(studentMS.Model.b_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update b_role set ");
            strSql.Append("RoleName=?RoleName,");
            strSql.Append("Status=?Status");
            strSql.Append(" where RoleID=?RoleID");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?RoleID", MySqlDbType.Int16),
                new MySqlParameter("?RoleName", MySqlDbType.VarChar, 45),
                new MySqlParameter("?Status", MySqlDbType.Int16)
            };
            parameters[0].Value = model.RoleID;
            parameters[1].Value = model.RoleName;
            parameters[2].Value = model.Status;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            return (rows > 0);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from b_role ");
            strSql.Append(" where RoleID=?RoleID");
            MySqlParameter[] parameters = { new MySqlParameter("?RoleID", MySqlDbType.Int16) };
            parameters[0].Value = RoleID;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            return (rows > 0);
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string RoleIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from b_role ");
            strSql.Append(" where RoleID in (" + RoleIDlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            return (rows > 0);
        }

        /// <summary>
        /// 获取单条记录详细信息
        /// </summary>
        public studentMS.Model.b_role GetModel(int RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoleID,RoleName,Status from b_role ");
            strSql.Append(" where RoleID=?RoleID");
            MySqlParameter[] parameters = { new MySqlParameter("?RoleID", MySqlDbType.Int16) };
            parameters[0].Value = RoleID;

            studentMS.Model.b_role model = new studentMS.Model.b_role();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["RoleID"].ToString() != "")
                {
                    model.RoleID = int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
                }
                model.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                if (ds.Tables[0].Rows[0]["Status"].ToString() != "")
                {
                    model.Status = int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoleID,RoleName,Status ");
            strSql.Append(" FROM b_role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  Method
    }
}
