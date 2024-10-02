using System;

namespace studentMS.Model
{
    /// <summary>
    /// 角色信息
    /// </summary>
    [Serializable]
    public class b_role
    {
        public b_role() { }

        #region Model
        private int _roleid;
        private string _rolename;
        private int? _status;

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        {
            set { _rolename = value; }
            get { return _rolename; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status
        {
            set { _status = value; }
            get { return _status; }
        }
        #endregion Model
    }
}
