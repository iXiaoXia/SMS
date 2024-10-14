using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 教师表
	/// </summary>
	public class teacher
	{
		private readonly studentMS.DAL.teacher dal=new studentMS.DAL.teacher();
		public teacher()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string TNO)
		{
			return dal.Exists(TNO);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.teacher model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.teacher model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string TNO)
		{
			return dal.Delete(TNO);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string TNOlist )
		{
			return dal.DeleteList(TNOlist );
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.teacher GetModel(string TNO)
		{
				return dal.GetModel(TNO);
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

