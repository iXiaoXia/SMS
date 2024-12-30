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

        private static string UserRight = ""; //保存登录用户的所有权限

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

        /// <summary>
        /// 获取用户user的权限列表
        /// </summary>
        /// <param name="user">用户名</param>
        /// <returns></returns>
        public void GetRightByUser(string user)
        {
            UserRight = ","; //初始化

            //从数据库中获取登录用户的所有权限列表
            DataTable tb_rigth = dal.GetRightByUser(user).Tables[0];

            foreach (DataRow row in tb_rigth.Rows)
            {
                UserRight += row["FID"].ToString() + ",";
            }
        }

        /// <summary>
        /// 根据roleID获取权限
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public void GetRightByRoleID(string roleID)
        {
            UserRight = ","; //初始化

            //从数据库中获取登录用户的所有权限列表
            DataTable tb_rigth = dal.GetRightByRoleID(roleID).Tables[0];

            foreach (DataRow row in tb_rigth.Rows)
            {
                UserRight += row["FID"].ToString() + ",";
            }
        }

        /// <summary>
        /// 判断当前登录用户是否拥有编号为FID的权限
        /// </summary>
        /// <param name="rightID"></param>
        /// <returns></returns>
        public bool HaveRight(string FID)
        {
            return UserRight.Contains("," + FID + ",");
        }

        public DataSet GetDeptList(string DeptName)
        {
            return dal.GetDeptList(DeptName);
        }

        public DataSet GetGradeDistribution(string CNO)
        {
            return dal.GetGradeDistribution(CNO);
        }
    }
}
