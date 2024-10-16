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
            strSql.Append("  where a.DeptNO=b.DeptNO and TNO like ?TNO and TName like ?TName");
            MySqlParameter[] parameters =
            {
                new MySqlParameter("?TNO", MySqlDbType.VarChar),
                new MySqlParameter("?TName", MySqlDbType.VarChar)
            };
            parameters[0].Value = "%" + TNO + "%";
            parameters[1].Value = "%" + TName + "%";

            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }
    }
}
