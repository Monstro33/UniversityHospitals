using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Nurse : Employee
    {
        public int PatientLoad { get; set; }

        public Nurse()
        {
            EmployeeId = 002;
            JobTitle = "Nurse";
            PatientLoad = 3;
            FullName = "Amber Lake";
            Salary = 90000;
        }

        public override void PayEmployee()
        {
            if (Paid)
            {
                Console.WriteLine("Selection invalid, Doctor Manville has alredy been paid.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("Doctor Manville has just been paid their salary of $90,000.00");
            }
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("EMPLOYEE ID: " + EmployeeId);
            Console.WriteLine("JOB TITLE: " + JobTitle);
            Console.WriteLine("NAME: " + FullName);
            Console.WriteLine("PATIENT LOAD: " + PatientLoad);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("PAY STATUS: " + Paid);
        }

        public void NurseDrawBlood(Patient patient)
        {
            patient.DrawBlood();
            Console.WriteLine("Nurse Lake has just administered a blood draw on the patient which has decreased the patient's blood level to " + patient.BloodLevel);
            Console.ReadKey();
        }

        public void NurseTreatHealth(Patient patient)
        {
           patient.Care();
            Console.WriteLine("Nurse Lake has just administered care on the patient which has helped raise the patient's health level to " + patient.HealthLevel + " and blood level to " + patient.BloodLevel); 
            Console.ReadKey();
        }

        public void NurseTasks(Patient patient)
        {
            Console.Clear();
            Console.WriteLine("Select an Option below for the Nurse to perform?");
            Console.WriteLine("1. Draw Blood.");
            Console.WriteLine("2. Provide Care.");
            Console.WriteLine("3. Return to Main Menu.");
            string NurseTasks = Console.ReadLine();
            switch (NurseTasks)
            {
                case "1":
                    NurseDrawBlood(patient);
                    break;
                case "2":
                    NurseTreatHealth(patient);
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Please make a valid selection.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
