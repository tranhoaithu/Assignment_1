using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1.Controller
{
    class SchoolController : BaseController
    {
        public string GetSchoolNameById(int id)
        {
            foreach (School sc in schoolLst)
            {
                if (sc.Id == id) return sc.Name;
            }
            return null;
        }
    }
}
