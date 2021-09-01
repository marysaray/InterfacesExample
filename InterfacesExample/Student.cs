using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Student : IDisplayable, IComparable<Student>
    {
        public string StudentId { get; set; }
        
        public string FullName { get; set; }

        public int CompareTo(Student other)
        {
            #region // compare students logic
            /*
            if (this.FullName < other.FullName)
            {
                return -1;
            }
            else if (this.FullName == other.FullName)
            {
                return 0;
            }
            else 
            {
                return 1;
            }
            */
            #endregion
            return this.FullName.CompareTo(other.FullName); // all built-in types has a compareTo method 
        }

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