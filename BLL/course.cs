using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 课程信息
	/// </summary>
	public class course
	{
		private readonly studentMS.DAL.course dal=new studentMS.DAL.course();
		public course()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string CNO)
		{
			return dal.Exists(CNO);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.course model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.course model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CNO)
		{
			return dal.Delete(CNO);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string CNOlist )
		{
			return dal.DeleteList(CNOlist );
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.course GetModel(string CNO)
		{
				return dal.GetModel(CNO);
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

