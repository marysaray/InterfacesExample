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

            Product product = new Product()
            {
                ProductId = 1,
                Price = 10.00,
                Title = "Student Id"
            };
        }
    }
}
