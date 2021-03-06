﻿using System;

namespace UserRegistrationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateDetails details = new ValidateDetails();
            Console.WriteLine("Enter the user first name :");
            string firstName = Console.ReadLine();
            while (!details.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid first name : ");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Enter the user last name :");
            string lastName = Console.ReadLine();
            while (!details.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid last name : ");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter the user Email Id :");
            string emailId = Console.ReadLine();
            while (!details.EmailValidation(emailId))
            {
                Console.WriteLine("Enter a valid Email Id : ");
                emailId = Console.ReadLine();
            }

            Console.WriteLine("Enter the user mobile number :");
            string mobileNumber = Console.ReadLine();
            while (!details.MobileNumberValidation(mobileNumber))
            {
                Console.WriteLine("Enter a valid mobile number : ");
                mobileNumber = Console.ReadLine();
            }

            Console.WriteLine("Enter the user password :");
            string password = Console.ReadLine();
            while (!details.PasswordValidation(password))
            {
                Console.WriteLine("Enter a valid password : ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + firstName + " " + lastName);
            Console.WriteLine("Email ID : " + emailId);
            Console.WriteLine("Mobile Number : " + mobileNumber);
        }
    }
}
