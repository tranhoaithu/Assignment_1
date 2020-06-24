using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1
{
    struct Department
    {
        private int id;
        private string name;


        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }


    }
}
