using System;

namespace studentMS.Model
{
	/// <summary>
	/// 角色权限
	/// </summary>
	[Serializable]
	public class b_roleright
	{
		public b_roleright()
		{}
		#region Model
		private int _roleid;
		private string _fid;
		/// <summary>
		/// 角色ID
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public string FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		#endregion Model
	}
}

