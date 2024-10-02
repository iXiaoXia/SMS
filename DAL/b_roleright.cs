using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 角色权限
	/// </summary>
	public class b_roleright
	{
		public b_roleright()
		{}
		#region  Method

		/// <summary>
		/// 获取最大ID
		/// </summary>
		public int GetMaxId()
		{
			return DbHelperMySQL.GetMaxID("RoleID", "b_roleright"); 
		}

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(int RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from b_roleright");
			strSql.Append(" where RoleID=?RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int16)};
			parameters[0].Value = RoleID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.b_roleright model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into b_roleright(");
			strSql.Append("RoleID,FID)");
			strSql.Append(" values (");
			strSql.Append("?RoleID,?FID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int16),
					new MySqlParameter("?FID", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.RoleID;
			parameters[1].Value = model.FID;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.b_roleright model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update b_roleright set ");
			strSql.Append("FID=?FID");
			strSql.Append(" where RoleID=?RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int16),
					new MySqlParameter("?FID", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.RoleID;
			parameters[1].Value = model.FID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_roleright ");
			strSql.Append(" where RoleID=?RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int16)};
			parameters[0].Value = RoleID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string RoleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_roleright ");
			strSql.Append(" where RoleID in ("+RoleIDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.b_roleright GetModel(int RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleID,FID from b_roleright ");
			strSql.Append(" where RoleID=?RoleID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int16)};
			parameters[0].Value = RoleID;

			studentMS.Model.b_roleright model=new studentMS.Model.b_roleright();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
				}
				model.FID=ds.Tables[0].Rows[0]["FID"].ToString();
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
			strSql.Append("select RoleID,FID ");
			strSql.Append(" FROM b_roleright ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

