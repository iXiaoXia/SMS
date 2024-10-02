using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 选课信息
	/// </summary>
	public class s_c
	{
		public s_c()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string SNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from s_c");
			strSql.Append(" where SNO=?SNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?SNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = SNO;
			parameters[1].Value = CNO;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.s_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into s_c(");
			strSql.Append("SNO,CNO,Score)");
			strSql.Append(" values (");
			strSql.Append("?SNO,?CNO,?Score)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?SNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?Score", MySqlDbType.Float)};
			parameters[0].Value = model.SNO;
			parameters[1].Value = model.CNO;
			parameters[2].Value = model.Score;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.s_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update s_c set ");
			strSql.Append("Score=?Score");
			strSql.Append(" where SNO=?SNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?SNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?Score", MySqlDbType.Float)};
			parameters[0].Value = model.SNO;
			parameters[1].Value = model.CNO;
			parameters[2].Value = model.Score;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string SNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from s_c ");
			strSql.Append(" where SNO=?SNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?SNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = SNO;
			parameters[1].Value = CNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.s_c GetModel(string SNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SNO,CNO,Score from s_c ");
			strSql.Append(" where SNO=?SNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?SNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = SNO;
			parameters[1].Value = CNO;

			studentMS.Model.s_c model=new studentMS.Model.s_c();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.SNO=ds.Tables[0].Rows[0]["SNO"].ToString();
				model.CNO=ds.Tables[0].Rows[0]["CNO"].ToString();
				if(ds.Tables[0].Rows[0]["Score"].ToString()!="")
				{
					model.Score=decimal.Parse(ds.Tables[0].Rows[0]["Score"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SNO,CNO,Score ");
			strSql.Append(" FROM s_c ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

