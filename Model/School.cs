using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1
{
    class School
    {
        private int id;
        private string name;
        private string nation;
        private int ageThreshold;
        private List<Department> deparments;
        
        public int NumberOfDeparments
        {
            get { return deparments.Count; }
            private set { }
        }

        public School(int id, string name, string nation, int ageThreshold, List<Department> departments)
        {
            this.id = id;
            this.name = name;
            this.nation = nation;
            this.ageThreshold = ageThreshold;
            this.deparments = departments;
        }
        public List<Student> StudentLst
        {
            get 
            {
                StudentController studentManger = new StudentController();
                return studentManger.GetStudentBySchoolId(id);
            }
        }

        public int NumberOfStudent
        {
            get { return StudentLst.Count; }

        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public int AgeThreshold
        {
            get { return ageThreshold; }
        }
    }
}
