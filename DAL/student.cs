using System;
using System.Data;
using System.Text;
using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;

namespace studentMS.DAL
{
    /// <summary>
    /// 学生档案
    /// </summary>
    public class student
    {
        public student() { }

        #region  Method

        /// <summary>
        /// 是否存在
        /// </summary>
        public bool Exists(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from student");
            strSql.Append(" where SNO=?SNO");
            MySqlParameter[] parameters = { new MySqlParameter("?SNO", MySqlDbType.VarChar) };
            parameters[0].Value = SNO;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 新增一条数据
        /// </summary>
        public int Add(studentMS.Model.student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into student(");
            strSql.Append("SNO,SName,SSex,SBirthday,DeptNO,Address)");
            strSql.Append(" values (");
            strSql.Append("?SNO,?SName,?SSex,?SBirthday,?DeptNO,?Address)");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?SNO", MySqlDbType.VarChar, 50),
                new MySqlParameter("?SName", MySqlDbType.VarChar, 50),
                new MySqlParameter("?SSex", MySqlDbType.VarChar, 2),
                new MySqlParameter("?SBirthday", MySqlDbType.DateTime),
                new MySqlParameter("?DeptNO", MySqlDbType.VarChar, 50),
                new MySqlParameter("?Address", MySqlDbType.VarChar, 255)
            };
            parameters[0].Value = model.SNO;
            parameters[1].Value = model.SName;
            parameters[2].Value = model.SSex;
            parameters[3].Value = model.SBirthday;
            parameters[4].Value = model.DeptNO;
            parameters[5].Value = model.Address;

            return DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(studentMS.Model.student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update student set ");
            strSql.Append("SName=?SName,");
            strSql.Append("SSex=?SSex,");
            strSql.Append("SBirthday=?SBirthday,");
            strSql.Append("DeptNO=?DeptNO,");
            strSql.Append("Address=?Address");
            strSql.Append(" where SNO=?SNO");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?SNO", MySqlDbType.VarChar, 50),
                new MySqlParameter("?SName", MySqlDbType.VarChar, 50),
                new MySqlParameter("?SSex", MySqlDbType.VarChar, 2),
                new MySqlParameter("?SBirthday", MySqlDbType.DateTime),
                new MySqlParameter("?DeptNO", MySqlDbType.VarChar, 50),
                new MySqlParameter("?Address", MySqlDbType.VarChar, 255)
            };
            parameters[0].Value = model.SNO;
            parameters[1].Value = model.SName;
            parameters[2].Value = model.SSex;
            parameters[3].Value = model.SBirthday;
            parameters[4].Value = model.DeptNO;
            parameters[5].Value = model.Address;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            return (rows > 0);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from student ");
            strSql.Append(" where SNO=?SNO");
            MySqlParameter[] parameters = { new MySqlParameter("?SNO", MySqlDbType.VarChar) };
            parameters[0].Value = SNO;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            return (rows > 0);
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string SNOlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from student ");
            strSql.Append(" where SNO in (" + SNOlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            return (rows > 0);
        }

        /// <summary>
        /// 获取单条记录详细信息
        /// </summary>
        public studentMS.Model.student GetModel(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SNO,SName,SSex,SBirthday,DeptNO,Address from student ");
            strSql.Append(" where SNO=?SNO");
            MySqlParameter[] parameters = { new MySqlParameter("?SNO", MySqlDbType.VarChar) };
            parameters[0].Value = SNO;

            studentMS.Model.student model = new studentMS.Model.student();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.SNO = ds.Tables[0].Rows[0]["SNO"].ToString();
                model.SName = ds.Tables[0].Rows[0]["SName"].ToString();
                model.SSex = ds.Tables[0].Rows[0]["SSex"].ToString();
                if (ds.Tables[0].Rows[0]["SBirthday"].ToString() != "")
                {
                    model.SBirthday = DateTime.Parse(ds.Tables[0].Rows[0]["SBirthday"].ToString());
                }
                model.DeptNO = ds.Tables[0].Rows[0]["DeptNO"].ToString();
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
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
            strSql.Append("select SNO,SName,SSex,SBirthday,DeptNO,Address ");
            strSql.Append(" FROM student ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  Method
    }
}
