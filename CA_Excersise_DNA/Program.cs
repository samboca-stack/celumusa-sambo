using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CA_Excersise_DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            int age;
            double weight = 0;
            char Gender;
            bool isMarried = true;
            
            string[] format = { "dd MMMM yyyy", "dd MMM yyyy" };
            DateTime DateOfBirth;
            decimal idNumber;
            decimal balance;

            //Enter your personal details

            Console.WriteLine("Write your personal details \n");
            Console.WriteLine("Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWeight: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nGender(M/F): ");
            Gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nAre you Married?: ");
            isMarried = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nYour Date of Birth(DD MMMM YYYY: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());//(Console.ReadLine());
            
            Console.WriteLine("\nID Number: /n");
           idNumber = Convert.ToDecimal(Console.ReadLine());
            string GenderInFull = "Male";

            if (Gender == 'M')
            {
                GenderInFull = "Male";

            }
            else
            {
                GenderInFull = "Female";
            }
                
            //if statement for gender

            
            //enter your balance in your account now 

            Console.WriteLine("Enter your balance on your account now : \n");
            balance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(name + " is " + age + " years old" + " with a weight of " + weight + "kg and is a " + GenderInFull + " who has born in " + DateOfBirth + " mariage status(Married/Not " + isMarried.ToString() + " and the national ID number is " + idNumber + " /n");

            Console.WriteLine(name + " s Bank balance is R" + balance);



            
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
