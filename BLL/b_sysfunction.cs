using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 系统功能
	/// </summary>
	public class b_sysfunction
	{
		private readonly studentMS.DAL.b_sysfunction dal=new studentMS.DAL.b_sysfunction();
		public b_sysfunction()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string FID)
		{
			return dal.Exists(FID);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.b_sysfunction model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.b_sysfunction model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FID)
		{
			return dal.Delete(FID);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string FIDlist )
		{
			return dal.DeleteList(FIDlist );
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.b_sysfunction GetModel(string FID)
		{
				return dal.GetModel(FID);
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

