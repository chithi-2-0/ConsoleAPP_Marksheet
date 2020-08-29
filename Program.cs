using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name?");
            String fname = Console.ReadLine();
            Console.WriteLine("Your Name is " +fname);
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());//covert string into integer
            Console.WriteLine("Your age is: " +age);
            Console.WriteLine("Your name is :" +fname +  " and Age is: " +age);//CONCATENANTE
            Console.WriteLine("Your name is : {0} {1}" , fname , age) ; //Placeholder Sytax*/

            /*WHAT IS CONSTANT VARIABLE?
            const double PI = 3.14;
            PI = 3.144; // will give error
            Console.WriteLine(PI);  */


            /*
            what is time & date specifier?
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}", dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:d} {1:D}", dt, dt);
            Console.WriteLine("{0:HH:mm:ss tt}", dt);
            Console.WriteLine("{0:dd-MM-yyyy}", dt*/

            Console.WriteLine("Enter Your Name");
            String Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Your Roll No.");
            string roll_no = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Your Class.");
            string Class = Console.ReadLine();


            Console.WriteLine("Enter Your Physics Marks out of 100 marks");

            int physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Chemistry Marks out of 100 marks");

            int chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Math Marks out of 100 marks");

            int math = int.Parse(Console.ReadLine());

            int total_marks = physics + chemistry + math;
            int percentage = total_marks * 100 / 300;

            Console.WriteLine();
            Console.WriteLine("----Marksheet-----");
            Console.WriteLine("Your Name is : {0}", Name);
            Console.WriteLine(" Your Roll Number is  : {0}", roll_no);
            Console.WriteLine(" Your Class is  : {0}", Class);
            Console.WriteLine("Your Total Marks is :{0}/300", total_marks);
            Console.WriteLine("Your percentage is: " + percentage + "%");
            Console.WriteLine();


            if (percentage < 33 || physics<33 || chemistry<33 || math<33)
            {
                Console.WriteLine("You Are Fail & Try for next year");
            }
            else if (percentage >= 33 && percentage < 50)
            {
                Console.WriteLine("Congrats ! You passed with 3rd Division");

            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("Congtrats! You passed with 2nd Division");
            }
            else
            {
                Console.WriteLine("Congtrats! You passed with 1st Division");
            }

            int suppli = 0;

            if (physics < 33)
            {
                suppli++;
            }

            if (chemistry < 33)
            {
                suppli++;
            }
            if (math < 33)
            {
                suppli++;
            }

            Console.WriteLine("You are failed in " +suppli+ " subject.");
            Console.WriteLine();
            if(suppli==1)
            {
                Console.WriteLine("You are failed in following subject.");
            }
            if (suppli >1)
            {
                Console.WriteLine("You are failed in following subjects.");
            }
            if(physics<33)
            {
                Console.WriteLine("You are failed in Physics.");
            }
            if (chemistry < 33)
            {
                Console.WriteLine("You are failed in Chemistry.");
            }
            if (math < 33)
            {
                Console.WriteLine("You are failed in Math.");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
