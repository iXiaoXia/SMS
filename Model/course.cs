using System;

namespace studentMS.Model
{
    /// <summary>
    /// 课程信息
    /// </summary>
    [Serializable]
    public class course
    {
        public course() { }

        #region Model
        private string _cno;
        private string _cname;
        private decimal? _credit;

        /// <summary>
        /// 课程编号
        /// </summary>
        public string CNO
        {
            set { _cno = value; }
            get { return _cno; }
        }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string CName
        {
            set { _cname = value; }
            get { return _cname; }
        }

        /// <summary>
        /// 学分
        /// </summary>
        public decimal? Credit
        {
            set { _credit = value; }
            get { return _credit; }
        }
        #endregion Model
    }
}
