using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My_own_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignUp();
            SignUpUser();
            Console.WriteLine(" The second calling");
            SignUpUser();
            SignUp();

        }
        static void SignUp()
        {
            Console.WriteLine("Enter your name\n,  name is");
            string name = Console.ReadLine();
            Console.WriteLine("Hi" + name);
           
        }
        static void SignUpUser()
        {
            Console.WriteLine(" When you were born " ); 
            int year = int.Parse(Console.ReadLine());
            int age = 2023 - year;

    
            Console.WriteLine(" You are " + age + " years old ");
            Console.ReadLine();
        }

        
    }

}
