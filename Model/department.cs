using System;

namespace studentMS.Model
{
	/// <summary>
	/// 院系信息
	/// </summary>
	[Serializable]
	public class department
	{
		public department()
		{}
		#region Model
		private string _deptno;
		private string _deptname;
		/// <summary>
		/// 院系编号
		/// </summary>
		public string DeptNO
		{
			set{ _deptno=value;}
			get{return _deptno;}
		}
		/// <summary>
		/// 院系名称
		/// </summary>
		public string DeptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
		}
		#endregion Model
	}
}

