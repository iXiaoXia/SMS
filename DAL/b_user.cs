using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 用户信息
	/// </summary>
	public class b_user
	{
		public b_user()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string UID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from b_user");
			strSql.Append(" where UID=?UID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?UID", MySqlDbType.VarChar)};
			parameters[0].Value = UID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.b_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into b_user(");
			strSql.Append("UID,UCode,StaffID,RoleID,UPriorTime,UPriorIP,UserType,Remark,State)");
			strSql.Append(" values (");
			strSql.Append("?UID,?UCode,?StaffID,?RoleID,?UPriorTime,?UPriorIP,?UserType,?Remark,?State)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?UID", MySqlDbType.VarChar,50),
					new MySqlParameter("?UCode", MySqlDbType.VarChar,50),
					new MySqlParameter("?StaffID", MySqlDbType.Int16),
					new MySqlParameter("?RoleID", MySqlDbType.Int16),
					new MySqlParameter("?UPriorTime", MySqlDbType.DateTime),
					new MySqlParameter("?UPriorIP", MySqlDbType.VarChar,15),
					new MySqlParameter("?UserType", MySqlDbType.Int16),
					new MySqlParameter("?Remark", MySqlDbType.Text,65535),
					new MySqlParameter("?State", MySqlDbType.Int16)};
			parameters[0].Value = model.UID;
			parameters[1].Value = model.UCode;
			parameters[2].Value = model.StaffID;
			parameters[3].Value = model.RoleID;
			parameters[4].Value = model.UPriorTime;
			parameters[5].Value = model.UPriorIP;
			parameters[6].Value = model.UserType;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.State;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.b_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update b_user set ");
			strSql.Append("UCode=?UCode,");
			strSql.Append("StaffID=?StaffID,");
			strSql.Append("RoleID=?RoleID,");
			strSql.Append("UPriorTime=?UPriorTime,");
			strSql.Append("UPriorIP=?UPriorIP,");
			strSql.Append("UserType=?UserType,");
			strSql.Append("Remark=?Remark,");
			strSql.Append("State=?State");
			strSql.Append(" where UID=?UID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?UID", MySqlDbType.VarChar,50),
					new MySqlParameter("?UCode", MySqlDbType.VarChar,50),
					new MySqlParameter("?StaffID", MySqlDbType.Int16),
					new MySqlParameter("?RoleID", MySqlDbType.Int16),
					new MySqlParameter("?UPriorTime", MySqlDbType.DateTime),
					new MySqlParameter("?UPriorIP", MySqlDbType.VarChar,15),
					new MySqlParameter("?UserType", MySqlDbType.Int16),
					new MySqlParameter("?Remark", MySqlDbType.Text,65535),
					new MySqlParameter("?State", MySqlDbType.Int16)};
			parameters[0].Value = model.UID;
			parameters[1].Value = model.UCode;
			parameters[2].Value = model.StaffID;
			parameters[3].Value = model.RoleID;
			parameters[4].Value = model.UPriorTime;
			parameters[5].Value = model.UPriorIP;
			parameters[6].Value = model.UserType;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.State;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string UID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_user ");
			strSql.Append(" where UID=?UID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?UID", MySqlDbType.VarChar)};
			parameters[0].Value = UID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string UIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from b_user ");
			strSql.Append(" where UID in ("+UIDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.b_user GetModel(string UID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UID,UCode,StaffID,RoleID,UPriorTime,UPriorIP,UserType,Remark,State from b_user ");
			strSql.Append(" where UID=?UID");
			MySqlParameter[] parameters = {
					new MySqlParameter("?UID", MySqlDbType.VarChar)};
			parameters[0].Value = UID;

			studentMS.Model.b_user model=new studentMS.Model.b_user();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.UID=ds.Tables[0].Rows[0]["UID"].ToString();
				model.UCode=ds.Tables[0].Rows[0]["UCode"].ToString();
				if(ds.Tables[0].Rows[0]["StaffID"].ToString()!="")
				{
					model.StaffID=int.Parse(ds.Tables[0].Rows[0]["StaffID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UPriorTime"].ToString()!="")
				{
					model.UPriorTime=DateTime.Parse(ds.Tables[0].Rows[0]["UPriorTime"].ToString());
				}
				model.UPriorIP=ds.Tables[0].Rows[0]["UPriorIP"].ToString();
				if(ds.Tables[0].Rows[0]["UserType"].ToString()!="")
				{
					model.UserType=int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
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
			strSql.Append("select UID,UCode,StaffID,RoleID,UPriorTime,UPriorIP,UserType,Remark,State ");
			strSql.Append(" FROM b_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}

