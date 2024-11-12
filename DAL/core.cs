using System;
using System.Data;
using System.Text;
using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;

namespace studentMS.DAL
{
    public class core
    {
        public core() { }

        public DataSet GetStudentList(string SNO, string SName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select a.SNO,a.SName,a.SSex,a.SBirthday,a.Address,b.DeptName from student a,department b"
            );
            strSql.Append(" where a.DeptNO=b.DeptNO and SNO like ?SNO and SName like ?SName");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?SNO", MySqlDbType.VarChar),
                new MySqlParameter("?SName", MySqlDbType.VarChar)
            };
            parameters[0].Value = "%" + SNO + "%";
            parameters[1].Value = "%" + SName + "%";

            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }

        public DataSet GetCourseList(string CNO, string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.* from course a");
            strSql.Append(" where  CNO like ?CNO and CName like ?CName");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?CNO", MySqlDbType.VarChar),
                new MySqlParameter("?CName", MySqlDbType.VarChar)
            };
            parameters[0].Value = "%" + CNO + "%";
            parameters[1].Value = "%" + CName + "%";

            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }

        public DataSet GetTeacherList(string TNO, string TName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select a.TNO,a.TName,a.TSex,a.Address,b.DeptName from teacher a,department b"
            );
            strSql.Append(" where a.DeptNO=b.DeptNO and TNO like ?TNO and TName like ?TName");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?TNO", MySqlDbType.VarChar),
                new MySqlParameter("?TName", MySqlDbType.VarChar)
            };
            parameters[0].Value = "%" + TNO + "%";
            parameters[1].Value = "%" + TName + "%";

            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }

        public DataSet GetSelectedCourseList(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CNO,CName,Credit from course ");
            strSql.Append("where cno in (select cno from s_c where sno='" + SNO + "')");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetUnSelectedCourseList(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CNO,CName,Credit from course ");
            strSql.Append("where cno not in (select cno from s_c where sno='" + SNO + "')");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetOneCourseStudentList(string CNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.SNO,a.SName,b.Score from student a,s_c b ");
            strSql.Append("where a.SNO=b.SNO and b.cno='" + CNO + "' ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetScoreList(string SNO, string SName, string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select a.SNO,a.SName,a.SSex,b.CNO,b.CName,c.Score from student a,course b,s_c c"
            );
            strSql.Append(" where a.SNO=c.SNO and b.CNO=c.CNO ");
            if (!string.IsNullOrEmpty(SNO))
                strSql.Append(" and a.SNO like '%" + SNO + "%'");
            if (!string.IsNullOrEmpty(SName))
                strSql.Append(" and a.SName like '%" + SName + "%'");
            if (!string.IsNullOrEmpty(CName))
                strSql.Append(" and b.CName like '%" + CName + "%'");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据课程名称获取成绩统计
        /// </summary>
        /// <param name="CName">课程名称</param>
        /// <returns></returns>
        public DataSet GetScoreStatisticList(string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select b.SNO,b.SName,b.SSex,MAX(Score) as ScoreMax,MIN(Score) as ScoreMin,AVG(Score) as ScoreAvg "
            );
            strSql.Append(" from s_c a,student b ");
            strSql.Append(" where a.SNO=b.SNO ");

            if (!string.IsNullOrEmpty(CName))
                strSql.Append(
                    " and a.CNO in ( select cno from course where CName like '%" + CName + "%')"
                );
            strSql.Append(" GROUP BY a.SNO,b.SName,b.SSex;");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetCourseStatisticList(string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "SELECT c.CNO,c.CName,MAX(s.Score) AS MaxScore, MIN(s.Score) AS MinScore,ROUND(AVG(s.Score), 3) AS AvgScore, SUM(CASE WHEN s.Score > 60 THEN 1 ELSE 0 END) AS PassCount "
            );
            strSql.Append(" FROM course c");
            strSql.Append(" LEFT JOIN s_c s ON c.CNO = s.CNO");

            strSql.Append(" GROUP BY c.CNO, c.CName");
            if (!string.IsNullOrEmpty(CName))
                strSql.Append(" Having  c.CName like '%" + CName + "%';");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 依据角色ID获取权限
        /// </summary>
        /// <param name="roleID">权限ID</param>
        /// <returns></returns>
        public DataSet GetRoleRightList(string roleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT a.FID,a.FName,a.ParentFID,b.FID as Have");
            strSql.Append(" from b_sysfunction a");
            strSql.Append(" left join b_roleright b on a.FID=b.FID and b.RoleID=" + roleID);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 依据UID模糊查询符合条件的数据集
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <returns></returns>
        public DataSet GetUserList(string UID)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT a.UID,a.RoleID,b.RoleName,a.UPriorTime,a.UPriorIP,a.Remark ");
            strSQL.Append(" FROM b_user a,b_role b where a.RoleID=b.RoleID ");

            if (UID != "")
                strSQL.Append(" and UID like '%" + UID + "%'");

            return DbHelperMySQL.Query(strSQL.ToString());
        }

        /// <summary>
        /// 依据用户名和密码查询该用户是否存在
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <param name="UCode">密码</param>
        /// <returns></returns>
        public bool ExistUIDUCode(string UID, string UCode)
        {
            string strsql =
                "SELECT count(UID) FROM b_user where UID = '"
                + UID
                + "' and UCode = '"
                + UCode
                + "'";
            Object obj = DbHelperMySQL.GetSingle(strsql);

            if (obj == null || obj.ToString() == "" || obj.ToString() == "0")
                return false;
            else
                return true;
        }

        public DataSet GetDeptList(String DeptName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT d.DeptNO, d.DeptName,COUNT(s.SNO) AS StudentCount ");
            strSql.Append(" FROM course c");
            strSql.Append(" LEFT JOIN s_c s ON c.CNO = s.CNO");

            strSql.Append(" GROUP BY c.CNO, c.CName");
            if (!string.IsNullOrEmpty(DeptName))
                strSql.Append(" Having  c.CName like '%" + DeptName + "%';");
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}
