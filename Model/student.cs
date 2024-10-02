using System;

namespace studentMS.Model
{
    /// <summary>
    /// 学生档案
    /// </summary>
    [Serializable]
    public class student
    {
        public student() { }

        #region Model
        private string _sno;
        private string _sname;
        private string _ssex;
        private DateTime? _sbirthday;
        private string _deptno;
        private string _address;

        /// <summary>
        /// 学号
        /// </summary>
        public string SNO
        {
            set { _sno = value; }
            get { return _sno; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string SName
        {
            set { _sname = value; }
            get { return _sname; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string SSex
        {
            set { _ssex = value; }
            get { return _ssex; }
        }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? SBirthday
        {
            set { _sbirthday = value; }
            get { return _sbirthday; }
        }

        /// <summary>
        /// 所在院系
        /// </summary>
        public string DeptNO
        {
            set { _deptno = value; }
            get { return _deptno; }
        }

        /// <summary>
        /// 住址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        #endregion Model
    }
}
