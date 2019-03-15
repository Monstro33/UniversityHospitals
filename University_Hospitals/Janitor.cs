using System;
using System.Collections.Generic;
using System.Text;
using UniversityHospitals;

namespace UniversityHospitals
{
    public class Janitor : Employee
    {
        public bool IsSweeping;

        public Janitor(int EmployeeId, string fullname, bool isPaid, bool isSweeping) : base(EmployeeId, fullname, isPaid)
        {
            IsSweeping = false;
            Salary = 40000;
        }

        public string SweepStatus()
        {
            if (IsSweeping)
            {
                return $"The Janitor is currently sweeping the Hospital";
            }
            else
            {
                return $"The Janitor is not currently sweeping the Hospital";
            }
        }

        public void Sweep()
        {
            if (IsSweeping /*== false*/)
            {
                IsSweeping = false;
                Console.WriteLine("The Janitor has now began sweeping the hospital");
            }
            else
            {
                IsSweeping = true;
                Console.WriteLine("The Janitor is not currently sweeping the hospital");
            }
        }

        public override string PayStatus()
        {
            Console.WriteLine();
            return base.PayStatus();
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine($"Janitor {FullName}, is {PayStatus().ToString()}, and {SweepStatus().ToString()}");
        }
    }
}