using ITI.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business
{
    public class DepartmentService
    {
        public DataTable GetAll()
        {
            string cmd = "select [Dept_Id],[Dept_Name],[Dept_Desc],[Dept_Location],[Dept_Manager] from [dbo].[Department]";

            DbContext db = new DbContext();
            DataTable dt = db.Select(cmd);
            return dt;
        }

        public int Insert(Models.Department dept)
        {
            string cmd = $"insert into [dbo].[Department]([Dept_Name],[Dept_Desc],[Dept_Location],[Dept_Manager]) values('{dept.DeptName}','{dept.DeptDesc}','{dept.DeptLocation}',{dept.DeptManager})";
            DbContext db = new DbContext();
            int res = db.ExecuteNonQuery(cmd);
            return res;
        }

        public int Update(Models.Department dept)
        {
            string cmd = $"update [dbo].[Department] set [Dept_Name]='{dept.DeptName}',[Dept_Desc]='{dept.DeptDesc}',[Dept_Location]='{dept.DeptLocation}',[Dept_Manager]={dept.DeptManager} where [Dept_Id]={dept.DeptId}";
            DbContext db = new DbContext();
            int res = db.ExecuteNonQuery(cmd);
            return res;
        }

        public int Delete(int id)
        {
            string cmd = $"delete from [dbo].[Department] where [Dept_Id]={id}";
            DbContext db = new DbContext();
            int res = db.ExecuteNonQuery(cmd);
            return res;
        }
    }
}
