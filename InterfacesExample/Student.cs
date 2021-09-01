using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Student : IDisplayable
    {
        public string StudentId { get; set; }
        
        public string FullName { get; set; }

        public string GetDisplayText()
        {
            return $"{StudentId} : {FullName}";
        }

        public void Register(string courseCode)
        {
            throw new NotImplementedException();
        }
    }
}