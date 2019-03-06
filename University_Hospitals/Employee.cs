using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string JobTitle { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public Employee()
        {
            Paid = false;
        }

        public abstract void EmployeeStatus();       

        public void PayStatus()
        {
            if (Paid == true)
            {
                Console.WriteLine("Paid");
            }
            else Console.WriteLine("Not Paid");
        }

        public abstract void PayEmployee();
    }
}
