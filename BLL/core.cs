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

        public DataSet GetSelectedCourseList(string SNO)
        {
            return dal.GetSelectedCourseList(SNO);
        }

        public DataSet GetUnSelectedCourseList(string SNO)
        {
            return dal.GetUnSelectedCourseList(SNO);
        }

        public DataSet GetOneCourseStudentList(string CNO)
        {
            return dal.GetOneCourseStudentList(CNO);
        }

        public DataSet GetScoreList(string SNO, string SName, string CName)
        {
            return dal.GetScoreList(SNO, SName, CName);
        }

        /// <summary>
        /// 根据课程名称获取成绩统计
        /// </summary>
        /// <param name="CName">课程名称</param>
        /// <returns></returns>
        public DataSet GetScoreStatisticList(string CName)
        {
            return dal.GetScoreStatisticList(CName);
        }

        public DataSet GetCourseStatisticList(string CName)
        {
            return dal.GetCourseStatisticList(CName);
        }

        /// <summary>
        /// 依据角色ID获取权限
        /// </summary>
        /// <param name="roleID">权限ID</param>
        /// <returns></returns>
        public DataSet GetRoleRightList(string roleID)
        {
            return dal.GetRoleRightList(roleID);
        }

        /// <summary>
        /// 依据UID模糊查询符合条件的数据集
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <returns></returns>
        public DataSet GetUserList(string UID)
        {
            return dal.GetUserList(UID);
        }

        /// <summary>
        /// 依据用户名和密码查询该用户是否存在
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <param name="UCode">密码</param>
        /// <returns></returns>
        public bool ExistUIDUCode(string UID, string UCode)
        {
            return dal.ExistUIDUCode(UID, UCode);
        }
    }
}
