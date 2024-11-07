using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 角色权限
	/// </summary>
	public class b_roleright
	{
		private readonly studentMS.DAL.b_roleright dal=new studentMS.DAL.b_roleright();
		public b_roleright()
		{}
		#region  Method

		/// <summary>
		/// 获取最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId(); 
		}

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(int RoleID,string FID)
		{
			return dal.Exists(RoleID,FID);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.b_roleright model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.b_roleright model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RoleID,string FID)
		{
			return dal.Delete(RoleID,FID);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.b_roleright GetModel(int RoleID,string FID)
		{
				return dal.GetModel(RoleID,FID);
		}

		/// <summary>
		/// 获取数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获取数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return dal.GetList("");
		}
		#endregion  Method
	}
}

