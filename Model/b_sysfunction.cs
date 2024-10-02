using System;

namespace studentMS.Model
{
	/// <summary>
	/// 系统功能
	/// </summary>
	[Serializable]
	public class b_sysfunction
	{
		public b_sysfunction()
		{}
		#region Model
		private string _fid;
		private string _fname;
		private string _parentfid;
		private int? _displayorder;
		private int _isvisible=1;
		private string _fvalue;
		/// <summary>
		/// 权限ID
		/// </summary>
		public string FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 权限名称
		/// </summary>
		public string FName
		{
			set{ _fname=value;}
			get{return _fname;}
		}
		/// <summary>
		/// 父ID
		/// </summary>
		public string ParentFID
		{
			set{ _parentfid=value;}
			get{return _parentfid;}
		}
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 是否可见
		/// </summary>
		public int IsVisible
		{
			set{ _isvisible=value;}
			get{return _isvisible;}
		}
		/// <summary>
		/// 参数值
		/// </summary>
		public string FValue
		{
			set{ _fvalue=value;}
			get{return _fvalue;}
		}
		#endregion Model
	}
}

