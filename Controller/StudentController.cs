using BigAssignment1.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1
{
    class StudentController : BaseController
    {
        List<Student> studentLst2;

        /// <summary>
        /// Get student list by SchoolId
        /// </summary>
        /// <param name="schoolId"></param>
        /// <returns>student list</returns>
        public List<Student> GetStudentBySchoolId(int schoolId)
        {
            studentLst2 = new List<Student>();
            foreach (Student st in studentLst)
            {
                if (st.SchoolId == schoolId) studentLst2.Add(st);
            }
            return studentLst2;
        }


        /// <summary>
        /// Display student list
        /// </summary>
        /// <param name="lst"></param>
        public void DisplayStudent(List<Student> lst)
        {
            foreach (Student st in lst)
            {
                Console.WriteLine($"Name: {st.FullName} and Age: {st.Age} and School Name: {st.SchoolName} and Major: {st.Department}");
            }
        }


        /// <summary>
        /// Get Student by Country
        /// </summary>
        /// <param name="country"></param>
        /// <returns>student list</returns>
        public List<Student> GetStudentByCountry(string country)
        {
            studentLst2 = new List<Student>();
            foreach (Student st in studentLst)
            {
                if (st.Country == country) studentLst2.Add(st);
            }
            return studentLst2;
        }

        /// <summary>
        /// Get student list more than given age
        /// </summary>
        /// <param name="age"></param>
        /// <returns>student list</returns>
        public List<Student> GetStudentMoreAge(int age)
        {
            studentLst2 = new List<Student>();
            foreach (Student st in studentLst)
            {
                if (st.Age > age) studentLst2.Add(st);
            }
            return studentLst2;
        }

        public List<Student> GetStudentByDepartmentNMoreAge(string departmentName, int age)
        {
            studentLst2 = GetStudentMoreAge(age);
            foreach (Student st in studentLst)
            {
                if (st.Department == departmentName) studentLst2.Add(st);
            }
            return studentLst2;
        }

        public List<Student> GetStudentBySchoolNMoreAge(int schoolId, int age)
        {
            studentLst2 = GetStudentMoreAge(age);
            foreach (Student st in studentLst)
            {
                if (st.SchoolId == schoolId) studentLst2.Add(st);
            }
            return studentLst2;
        }

        public List<Student> GetStudentIncludeCharacter(string character)
        {
            studentLst2 = new List<Student>();
            foreach (Student st in studentLst)
            {
                if (st.FullName.Contains(character)) studentLst2.Add(st);
            }
            return studentLst2;
        }

     
    }
}
