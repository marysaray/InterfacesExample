using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Student
    {
        public string StudentId { get; set; }
        
        public string FullName { get; set; }

        public void Register(string courseCode)
        {
            throw new NotImplementedException();
        }
    }
}