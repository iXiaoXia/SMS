using System;

namespace studentMS.Model
{
	/// <summary>
	/// 教师表
	/// </summary>
	[Serializable]
	public class teacher
	{
		public teacher()
		{}
		#region Model
		private string _tno;
		private string _tname;
		private string _tsex;
		private string _deptno;
		private string _address;
		/// <summary>
		/// 教师编号
		/// </summary>
		public string TNO
		{
			set{ _tno=value;}
			get{return _tno;}
		}
		/// <summary>
		/// 教师名
		/// </summary>
		public string TName
		{
			set{ _tname=value;}
			get{return _tname;}
		}
		/// <summary>
		/// 教师性别
		/// </summary>
		public string TSex
		{
			set{ _tsex=value;}
			get{return _tsex;}
		}
		/// <summary>
		/// 教师所在院系
		/// </summary>
		public string DeptNO
		{
			set{ _deptno=value;}
			get{return _deptno;}
		}
		/// <summary>
		/// 教师住址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		#endregion Model
	}
}

