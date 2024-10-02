using System;

namespace studentMS.Model
{
	/// <summary>
	/// 选课信息
	/// </summary>
	[Serializable]
	public class s_c
	{
		public s_c()
		{}
		#region Model
		private string _sno;
		private string _cno;
		private decimal _score;
		/// <summary>
		/// 学号
		/// </summary>
		public string SNO
		{
			set{ _sno=value;}
			get{return _sno;}
		}
		/// <summary>
		/// 课程编号
		/// </summary>
		public string CNO
		{
			set{ _cno=value;}
			get{return _cno;}
		}
		/// <summary>
		/// 成绩
		/// </summary>
		public decimal Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model
	}
}

