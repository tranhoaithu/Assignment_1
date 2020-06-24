using BigAssignment1.Controller;
using System;
using System.Collections.Generic;

namespace BigAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentLst;
            //1.Input all data
            BaseController.CreateData();


            //Get
            SchoolController controller = new SchoolController();
            controller.GetSchoolNameById(1);
            controller.GetSchoolNameById(2);
            controller.GetSchoolNameById(3);


            //2.Search students come from VN
            StudentController stController = new StudentController();
            studentLst = stController.GetStudentByCountry("VN");
            stController.DisplayStudent(studentLst);

            //3. Search student > 20 years old
            Console.WriteLine("---more 20 years old");
            studentLst = stController.GetStudentMoreAge(20);
            stController.DisplayStudent(studentLst);

            //4.Each student belongs to a department, find students learning IT and > 23 years
            Console.WriteLine("---IT and more 23 years old");
            studentLst = stController.GetStudentByDepartmentNMoreAge("IT", 23);
            stController.DisplayStudent(studentLst);

            //5.Find students having Fullname which inlcude *hu*
            Console.WriteLine("---fullName includ *hu*");
            studentLst = stController.GetStudentIncludeCharacter("hu");
            stController.DisplayStudent(studentLst);

            //6.In Each school, print students who have old than normal
            Console.WriteLine("---In Each school, print students who have old than normal");
            List<School> schoolLst = BaseController.schoolLst;
            foreach(School school in schoolLst)
            {
                Console.WriteLine($"---In Each school {school.Name}");
                List<Student> studentLst2 = new List<Student>();
                studentLst = school.StudentLst;
                foreach (Student st in studentLst)
                {
                    if (st.Age > school.AgeThreshold) studentLst2.Add(st);
                }
                stController.DisplayStudent(studentLst2);

            }
        }
    }
}
