using System;

namespace studentMS.Model
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public class b_user
    {
        public b_user() { }

        #region Model
        private string _uid;
        private string _ucode;
        private int? _staffid;
        private int? _roleid;
        private DateTime? _upriortime;
        private string _upriorip;
        private int? _usertype;
        private string _remark;
        private int? _state;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UID
        {
            set { _uid = value; }
            get { return _uid; }
        }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UCode
        {
            set { _ucode = value; }
            get { return _ucode; }
        }

        /// <summary>
        /// 工（学）号
        /// </summary>
        public int? StaffID
        {
            set { _staffid = value; }
            get { return _staffid; }
        }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int? RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? UPriorTime
        {
            set { _upriortime = value; }
            get { return _upriortime; }
        }

        /// <summary>
        /// 上次登录IP
        /// </summary>
        public string UPriorIP
        {
            set { _upriorip = value; }
            get { return _upriorip; }
        }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int? UserType
        {
            set { _usertype = value; }
            get { return _usertype; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int? State
        {
            set { _state = value; }
            get { return _state; }
        }
        #endregion Model
    }
}
