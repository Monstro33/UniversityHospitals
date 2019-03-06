using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Doctor : Employee
    {
        public string JobSpecialty { get; set; }
        public int PatientLoad { get; set; }

        public Doctor()
        {
            EmployeeId = 001;
            JobTitle = "Doctor";
            JobSpecialty = "Emergency Care";
            PatientLoad = 1;
            FullName = "Michael Manville";
            Salary = 90000;
        }

        public override void PayEmployee( )
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
            Console.WriteLine("ID: " + EmployeeId);
            Console.WriteLine("JOB TITLE: " + JobTitle);
            Console.WriteLine("NAME: " + FullName);
            Console.WriteLine("SPECIALTY: " + JobSpecialty);
            Console.WriteLine("SALARY: " + Salary);
            Console.WriteLine("Pay Status: " + Paid);
        }

        public void DoctorDrawBlood(Patient patient)
        {
            patient.DrawBlood();
            Console.WriteLine("Doctor has just administered a blood draw on the patient which has decreased the patient's blood level to " + patient.BloodLevel);
            Console.ReadKey();
        }

        public void DoctorTreatHealth(Patient patient)
        {
            patient.Care();
            Console.WriteLine("Doctor Manville has just administered care on the patient which has helped raise the patient's health level to " + patient.HealthLevel + " and blood level to " + patient.BloodLevel);
            Console.ReadKey();
        }

        public void DoctorTasks(Patient patient)
        {
            Console.Clear();
            Console.WriteLine("Select a task below for the Doctor to Perform?");
            Console.WriteLine("1. Draw Blood.");
            Console.WriteLine("2. Provide Care.");
            Console.WriteLine("3. Return to Main Menu.");
            string doctorAction = Console.ReadLine();
            switch (doctorAction)
            {
                case "1":
                    DoctorDrawBlood (patient);
                    break;
                case "2":
                    DoctorTreatHealth(patient);
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
