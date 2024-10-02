using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 院系信息
	/// </summary>
	public class department
	{
		public department()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string DeptNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from department");
			strSql.Append(" where DeptNO=?DeptNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?DeptNO", MySqlDbType.VarChar)};
			parameters[0].Value = DeptNO;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into department(");
			strSql.Append("DeptNO,DeptName)");
			strSql.Append(" values (");
			strSql.Append("?DeptNO,?DeptName)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?DeptNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?DeptName", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.DeptNO;
			parameters[1].Value = model.DeptName;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update department set ");
			strSql.Append("DeptName=?DeptName");
			strSql.Append(" where DeptNO=?DeptNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?DeptNO", MySqlDbType.VarChar,50),
					new MySqlParameter("?DeptName", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.DeptNO;
			parameters[1].Value = model.DeptName;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string DeptNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from department ");
			strSql.Append(" where DeptNO=?DeptNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?DeptNO", MySqlDbType.VarChar)};
			parameters[0].Value = DeptNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string DeptNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from department ");
			strSql.Append(" where DeptNO in ("+DeptNOlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.department GetModel(string DeptNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DeptNO,DeptName from department ");
			strSql.Append(" where DeptNO=?DeptNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?DeptNO", MySqlDbType.VarChar)};
			parameters[0].Value = DeptNO;

			studentMS.Model.department model=new studentMS.Model.department();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.DeptNO=ds.Tables[0].Rows[0]["DeptNO"].ToString();
				model.DeptName=ds.Tables[0].Rows[0]["DeptName"].ToString();
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
			strSql.Append("select DeptNO,DeptName ");
			strSql.Append(" FROM department ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

