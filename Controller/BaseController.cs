using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1.Controller
{
    abstract class BaseController
    {
        public static List<Student> studentLst = new List<Student>();
        public static List<School> schoolLst = new List<School>();
        public static List<Department> departmentLst = new List<Department>();

        public static void CreateData()
        {
            InputData input = new InputData();
            schoolLst = input.schoolLst;
            departmentLst = input.departmentLst;
            studentLst = input.studentLst;

        }
    }
}
