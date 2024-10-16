using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using studentMS.DAL;

namespace studentMS.BLL
{
    public class core
    {
        private readonly studentMS.DAL.core dal = new studentMS.DAL.core();

        /// <summary>
        /// 根据学号和姓名查询学生信息
        /// </summary>
        /// <param name="SNO">学号</param>
        /// <param name="SName">姓名</param>
        /// <returns></returns>
        public DataSet GetStudentList(string SNO, string SName)
        {
            return dal.GetStudentList(SNO, SName);
        }

        public DataSet GetCourseList(string CNO, string CName)
        {
            return dal.GetCourseList(CNO, CName);
        }

        public DataSet GetTeacherList(string TNO, string TName)
        {
            return dal.GetTeacherList(TNO, TName);
        }
    }
}
