using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 选课信息
	/// </summary>
	public class s_c
	{
		private readonly studentMS.DAL.s_c dal=new studentMS.DAL.s_c();
		public s_c()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string SNO,string CNO)
		{
			return dal.Exists(SNO,CNO);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.s_c model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.s_c model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string SNO,string CNO)
		{
			return dal.Delete(SNO,CNO);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.s_c GetModel(string SNO,string CNO)
		{
				return dal.GetModel(SNO,CNO);
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

