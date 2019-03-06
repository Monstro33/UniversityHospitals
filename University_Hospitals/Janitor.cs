using System;
using System.Collections.Generic;
using System.Text;
using UniversityHospitals;

namespace UniversityHospitals
{
    public class Janitor : Employee
    {
        public bool IsSweeping;
        public Janitor()
        {
            EmployeeId = 004;
            JobTitle = "Janitor";
            FullName = "Maximus Michael";
            Salary = 40000;
            IsSweeping = false;
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("EMPLOYEE ID: " + EmployeeId);
            Console.WriteLine("JOB TITLE: " + JobTitle);
            Console.WriteLine("NAME: " + FullName);
            Console.WriteLine("SALARY: " + Salary);
            Console.WriteLine("PAY STATUS: " + Paid);
            Console.WriteLine("IS CLEANING: " + IsSweeping);
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
     

          public void Sweep()
        {
            if (IsSweeping)
            {
                IsSweeping = false;
                Console.WriteLine("Janitor Michael is currently not sweeping.");
                
            }
            else
            {
                IsSweeping = true;
                Console.WriteLine("Janitor Michael is currently sweeping.");
            }
        }       
    }
}

