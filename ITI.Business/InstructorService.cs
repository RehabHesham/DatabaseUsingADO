using ITI.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business
{
    public class InstructorService
    {
        public DataTable GetAsManger()
        {
            string cmd = "select [Ins_Id],[Ins_Name] from [dbo].[Instructor]";
            DbContext db = new DbContext();
            DataTable dt = db.Select(cmd);
            return dt;
        }
    }
}
