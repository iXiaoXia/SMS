using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 课程信息
	/// </summary>
	public class course
	{
		public course()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from course");
			strSql.Append(" where CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = CNO;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into course(");
			strSql.Append("CNO,CName,Credit)");
			strSql.Append(" values (");
			strSql.Append("?CNO,?CName,?Credit)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?CName", MySqlDbType.VarChar,50),
					new MySqlParameter("?Credit", MySqlDbType.Float)};
			parameters[0].Value = model.CNO;
			parameters[1].Value = model.CName;
			parameters[2].Value = model.Credit;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update course set ");
			strSql.Append("CName=?CName,");
			strSql.Append("Credit=?Credit");
			strSql.Append(" where CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?CName", MySqlDbType.VarChar,50),
					new MySqlParameter("?Credit", MySqlDbType.Float)};
			parameters[0].Value = model.CNO;
			parameters[1].Value = model.CName;
			parameters[2].Value = model.Credit;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from course ");
			strSql.Append(" where CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = CNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string CNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from course ");
			strSql.Append(" where CNO in ("+CNOlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.course GetModel(string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CNO,CName,Credit from course ");
			strSql.Append(" where CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = CNO;

			studentMS.Model.course model=new studentMS.Model.course();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.CNO=ds.Tables[0].Rows[0]["CNO"].ToString();
				model.CName=ds.Tables[0].Rows[0]["CName"].ToString();
				if(ds.Tables[0].Rows[0]["Credit"].ToString()!="")
				{
					model.Credit=decimal.Parse(ds.Tables[0].Rows[0]["Credit"].ToString());
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
			strSql.Append("select CNO,CName,Credit ");
			strSql.Append(" FROM course ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

