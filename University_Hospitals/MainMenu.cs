using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    class MainMenu
    {
        public void WelcomeMenu(HospitalFunctions hf)
        {
            Console.WriteLine("=========MAIN MENU=========\n\n");
            Console.WriteLine("\t\tHello! Welcome to the University Hospitals \n\t\tPatient and Employee Management System.");
            Console.WriteLine("");
            Console.WriteLine("\n\n\t\t\t   SELECT FROM THE OPTIONS BELOW:\n");
            Console.WriteLine("\t   Press 1 to view all employees");
            Console.WriteLine("\t   Press 2 to view all patients");
            Console.WriteLine("\t   Press 0 to exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1"://view all employees
                    Console.Clear();
                    hf.EmployeeStatus();
                    break;
                case "2"://view all patients
                    Console.Clear();
                    hf.Patient();
                    Console.WriteLine("\n\n\nPlease select from the options below: ");
                    Console.WriteLine("\n\\tPress 1 to view current patients " +
                    "\n\t\tPress 4 to draw blood from a patient " +
                    "\n\t\tPress 5 to care for a patient " +
                    "\n\t\tPress 0 to exit the application ");
                    break;
                case "0"://Close the program
                    Console.WriteLine("Thank you for using UniversityHospitals Employee ans Patient Tracking system. Hit the enter button to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
