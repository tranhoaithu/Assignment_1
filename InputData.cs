using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1
{
    class InputData
    {
        public List<Department> departmentLst = new List<Department>();
        public List<School> schoolLst = new List<School>();
        public List<Student> studentLst = new List<Student>();
        public InputData()
        {
            InputDepartment();
            InputSchool();
            InputStudent();

        }

        public void InputDepartment()
        {
            departmentLst.Add(new Department(1, "IT"));
            departmentLst.Add(new Department(2, "Finance"));
            departmentLst.Add(new Department(3, "Accountant"));
        }

        public void InputSchool()
        {
            schoolLst.Add(new School(1, "PTIT", "VietNam", 22, departmentLst));
            schoolLst.Add(new School(2, "NEU", "US", 25, departmentLst));
            schoolLst.Add(new School(3, "HUST", "US", 25, departmentLst));
        }

        public void InputStudent()
        {
            Student st1 = new Student(1, "Thu", "Tran", 1991, "VN", 1, 1);
            Student st2 = new Student(2, "Trung", "Do Nam", 1981, "US", 2, 2);
            Student st3 = new Student(3, "Mai", "Tran", 1990, "UK", 1, 3);
            Student st4 = new Student(4, "Huong", "Tran", 2003, "VN", 2, 1);
            Student st5 = new Student(5, "Hang", "Phan", 2002, "VN", 3, 2);
            studentLst.Add(st1);
            studentLst.Add(st2);
            studentLst.Add(st3);
            studentLst.Add(st4);
            studentLst.Add(st5);
        }
    }
}
