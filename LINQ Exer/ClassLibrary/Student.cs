using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        //FN	First name	Last Name	Email	Age	Group	Grade1	Grade2	Grade3	Grade4	Phones
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FN { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        public List<int> Grades { get; set; }
    }
}
