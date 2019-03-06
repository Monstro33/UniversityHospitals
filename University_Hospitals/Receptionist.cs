using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Receptionist : Employee
    {
        public bool IsOnPhone;
        public Receptionist()
        {
            EmployeeId = 003;
            JobTitle = "Receptionist";
            FullName = "Mila Marie";
            Salary = 45000;
            IsOnPhone = false;
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

        public void PhoneCall()
        {
            if (IsOnPhone)
            {
                IsOnPhone = false;
                Console.WriteLine("Receptionist Marie is not currently on the phone");
                
            }
            else
            {
                IsOnPhone = true;
                Console.WriteLine("Receptionist Marie is currently on the phone.");
            }
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("EMPLOYEE ID: " + EmployeeId);
            Console.WriteLine("JOB TITLE: " + JobTitle);
            Console.WriteLine("NAME: " + FullName);
            Console.WriteLine("SALARY: " + Salary);
            Console.WriteLine("PAY STATUS: " + Paid);
            Console.WriteLine("IS ON PHONE: " + IsOnPhone);
        }
    }
}
