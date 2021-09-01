using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                StudentId = "789654123",
                FullName = "Mary Saray"
            };

            Student student2 = new Student()
            {
                StudentId = "369852147",
                FullName = "Saray Yuorn"
            };

            List<Student> students = new List<Student>()
            {
                student, student2
            };

            students.Sort();

            foreach (Student currentStudent in students)
            {
                Console.WriteLine(currentStudent.FullName);
            }

            Product product = new Product()
            {
                ProductId = 1,
                Price = 10.00,
                Title = "Student Id"
            };

            Display(student);
            Display(product);

            // stack example 
            Stack<Student> studentStack = new Stack<Student>();
            studentStack.Push(student);
            studentStack.Push(student2);

            DisplayList(students);      // list
            DisplayList(studentStack);  // stack: reverse order of printing push/pop

            Console.ReadKey();
        }

        static void Display(IDisplayable display)
        {
            Console.WriteLine(display.GetDisplayText());
        }

        static void DisplayList(IEnumerable<Student> studentList) // ICollection: used more for CRUD Functionality
        {
            foreach (Student s in studentList)
            {
                Console.WriteLine(s.FullName);
            }
        }
    }
}