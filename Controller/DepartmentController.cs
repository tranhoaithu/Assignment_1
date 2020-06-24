using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1.Controller
{
    class DepartmentController : BaseController
    {
        public string GetDepartmentNameById(int id)
        {
            foreach (Department dp in departmentLst)
            {
                if (dp.Id == id) return dp.Name;
            }
            return null;
        }
    }
}
