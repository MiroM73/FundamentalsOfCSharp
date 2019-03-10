using System;

namespace Chapter01
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            //Program that reads your age from the console and prints your age after 10 years.
            Console.WriteLine("Program that reads your age from the console and prints your age after 10 years.");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years: " + (age + 10));

            Console.Write("Enter your date of birth: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            TimeSpan birthDateSpan = (DateTime.Now - birthDate);
            DateTime zeroTime = new DateTime(1, 1, 1);
            age = (zeroTime + birthDateSpan).Year - 1;
            Console.WriteLine("You are {0} old.", age);
            string nextDateOfBirthday = (birthDate.AddYears(age + 10)).ToLongDateString();
            Console.WriteLine("The date of your next birthday after 10 years is: {0}", nextDateOfBirthday);
        }
    }
}
