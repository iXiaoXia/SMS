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
            strSql.Append("select a.*,b.DeptName from student a,department b");
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
    }
}
