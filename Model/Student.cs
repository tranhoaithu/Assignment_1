using BigAssignment1.Controller;
using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Text;

namespace BigAssignment1
{
    class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string country;
        private int schoolId;
        private int departmentId;
        private int bornYear;

        public Student() { }
        public Student(int id, string firstName, string lastName, int bornYear, string country, int schoolId, int departmentId)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.bornYear = bornYear;
            this.country = country;
            this.schoolId = schoolId;
            this.departmentId = departmentId;
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        public int Age
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - bornYear;
            }
         }


        public string SchoolName
        {
            get 
            {
                SchoolController controller = new SchoolController();
                return controller.GetSchoolNameById(schoolId);
                
            }
        }

        public string Department
        {
            get 
            {
                DepartmentController controller = new DepartmentController();
                return controller.GetDepartmentNameById(departmentId);
            }
        }

        public int SchoolId
        { 
            get
            {
                return schoolId;
            }
        }

        public string Country
        {
            get { return country; }
        }

        public int DepartmentId
        {
            get { return departmentId; }
        }

    }
}
