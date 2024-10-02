using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 系统功能
	/// </summary>
	public class b_sysfunction
	{
		public b_sysfunction()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from b_sysfunction");
			strSql.Append(" where FID=?FID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?FID", MySqlDbType.VarChar)};
			parameters[0].Value = FID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.b_sysfunction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into b_sysfunction(");
			strSql.Append("FID,FName,ParentFID,DisplayOrder,IsVisible,FValue)");
			strSql.Append(" values (");
			strSql.Append("?FID,?FName,?ParentFID,?DisplayOrder,?IsVisible,?FValue)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?FID", MySqlDbType.VarChar,20),
					new MySqlParameter("?FName", MySqlDbType.VarChar,200),
					new MySqlParameter("?ParentFID", MySqlDbType.VarChar,20),
					new MySqlParameter("?DisplayOrder", MySqlDbType.Int16),
					new MySqlParameter("?IsVisible", MySqlDbType.Int16),
					new MySqlParameter("?FValue", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.FName;
			parameters[2].Value = model.ParentFID;
			parameters[3].Value = model.DisplayOrder;
			parameters[4].Value = model.IsVisible;
			parameters[5].Value = model.FValue;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.b_sysfunction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update b_sysfunction set ");
			strSql.Append("FName=?FName,");
			strSql.Append("ParentFID=?ParentFID,");
			strSql.Append("DisplayOrder=?DisplayOrder,");
			strSql.Append("IsVisible=?IsVisible,");
			strSql.Append("FValue=?FValue");
			strSql.Append(" where FID=?FID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?FID", MySqlDbType.VarChar,20),
					new MySqlParameter("?FName", MySqlDbType.VarChar,200),
					new MySqlParameter("?ParentFID", MySqlDbType.VarChar,20),
					new MySqlParameter("?DisplayOrder", MySqlDbType.Int16),
					new MySqlParameter("?IsVisible", MySqlDbType.Int16),
					new MySqlParameter("?FValue", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.FName;
			parameters[2].Value = model.ParentFID;
			parameters[3].Value = model.DisplayOrder;
			parameters[4].Value = model.IsVisible;
			parameters[5].Value = model.FValue;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_sysfunction ");
			strSql.Append(" where FID=?FID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?FID", MySqlDbType.VarChar)};
			parameters[0].Value = FID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string FIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_sysfunction ");
			strSql.Append(" where FID in ("+FIDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.b_sysfunction GetModel(string FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,FName,ParentFID,DisplayOrder,IsVisible,FValue from b_sysfunction ");
			strSql.Append(" where FID=?FID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?FID", MySqlDbType.VarChar)};
			parameters[0].Value = FID;

			studentMS.Model.b_sysfunction model=new studentMS.Model.b_sysfunction();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.FID=ds.Tables[0].Rows[0]["FID"].ToString();
				model.FName=ds.Tables[0].Rows[0]["FName"].ToString();
				model.ParentFID=ds.Tables[0].Rows[0]["ParentFID"].ToString();
				if(ds.Tables[0].Rows[0]["DisplayOrder"].ToString()!="")
				{
					model.DisplayOrder=int.Parse(ds.Tables[0].Rows[0]["DisplayOrder"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsVisible"].ToString()!="")
				{
					model.IsVisible=int.Parse(ds.Tables[0].Rows[0]["IsVisible"].ToString());
				}
				model.FValue=ds.Tables[0].Rows[0]["FValue"].ToString();
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
			strSql.Append("select FID,FName,ParentFID,DisplayOrder,IsVisible,FValue ");
			strSql.Append(" FROM b_sysfunction ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

