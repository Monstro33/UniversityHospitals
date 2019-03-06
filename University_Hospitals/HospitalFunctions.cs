using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class HospitalFunctions
    {
        public static Doctor doctor;
        public static Nurse nurse;
        public static Receptionist receptionist;
        public static Janitor janitor;
        public static Patient patient;

        public HospitalFunctions()
        {
           
            doctor = new Doctor();
            nurse = new Nurse();
            receptionist = new Receptionist();
            janitor = new Janitor();
            patient = new Patient();
        }

        public void Patient()
        {
            patient.PatientStatus();
            Console.ReadKey();
        }

        public void EmployeeStatus()
        {
            Console.Clear();
            doctor.EmployeeStatus();
            Console.WriteLine();
            nurse.EmployeeStatus();
            Console.WriteLine();
            receptionist.EmployeeStatus();
            Console.WriteLine();
            janitor.EmployeeStatus();

            Console.WriteLine();
            Console.WriteLine("Press any key to return to Main Menu.");
            Console.ReadKey();
        }

        public void EmployeeTasks()
        {
            Console.Clear();
            Console.WriteLine("Select an employee that you would like to perform a task.");
            Console.WriteLine("1. Doctor.");
            Console.WriteLine("2. Nurse.");
            Console.WriteLine("3. Receptionist.");
            Console.WriteLine("4. Janitor.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    doctor.DoctorTasks(patient);
                    break;
                case "2":
                    nurse.NurseTasks(patient);
                    break;
                case "3":
                    receptionist.PhoneCall();
                    Console.ReadKey();
                    break;
                case "4":
                    janitor.Sweep();
                    Console.ReadKey();
                    break;
            }
        }

        public void PayDay()
        {
            Console.Clear();
            Console.WriteLine("Select the employee you would like to pay their salary.");
            Console.WriteLine("1. Doctor.");
            Console.WriteLine("2. Nurse.");
            Console.WriteLine("3. Receptionist.");
            Console.WriteLine("4. Janitor.");
            Console.WriteLine("5. Pay All Employees");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    doctor.PayEmployee();
                    Console.ReadKey();
                    PayDay();
                    break;
                case "2":
                    nurse.PayEmployee();
                    Console.ReadKey();
                    PayDay();
                    break;
                case "3":
                    receptionist.PayEmployee();
                    Console.ReadKey();
                    PayDay();
                    break;
                case "4":
                    janitor.PayEmployee();
                    Console.ReadKey();
                    PayDay();
                    break;
                case "5":
                    doctor.PayEmployee();
                    nurse.PayEmployee();
                    receptionist.PayEmployee();
                    janitor.PayEmployee();
                    Console.ReadKey();
                    break;
            }
        }
    }
}

