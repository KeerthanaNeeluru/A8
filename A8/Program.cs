using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8
{
    public class calc
    {

        public double Calculate(double projectHandles = 1, double extras = 0)
        {
            Console.WriteLine("Enter no.of working hours per day");
            int WorkingHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no.of working Days in a month");
            int workingDays = int.Parse(Console.ReadLine());

            double result = WorkingHours * workingDays + projectHandles * 3000 + extras * 2000;
            return result;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            calc obj = new calc();
            char ch;
            do
            {
                Console.WriteLine("Please Enter your role\n  Human Resourse ---> HR\n Admin department--->ADMIN\n SoftwareDeveloper--->SD ");
                string role = Console.ReadLine().ToUpper();
                switch (role)
                {
                    case "HR":
                        Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate());
                        break;
                    case "ADMIN":
                        Console.WriteLine("Please enter number of  projects Handled");
                        int p1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p1));
                        break;
                    case "SD":
                        Console.WriteLine("Please enter number of projects Handled");
                        int p2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your extras");
                        int extras = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p2, extras));
                        break;
                    default:
                        Console.WriteLine("please Enter valid role");
                        break;
                }
                Console.WriteLine("if you want to continue press y");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'y');
             Console.ReadKey();

        }
    }
}
