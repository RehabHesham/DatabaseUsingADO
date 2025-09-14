using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
        public string DeptLocation { get; set; }
        public int DeptManager { get; set; }
    }
}
