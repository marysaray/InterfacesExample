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

            Console.ReadKey();
        }

        static void Display(IDisplayable display)
        {
            Console.WriteLine(display.GetDisplayText());
        }
    }
}