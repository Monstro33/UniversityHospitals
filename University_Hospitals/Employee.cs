using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FullName { get; private set; }
        public int Salary { get; set; }
        public bool IsPaid { get; set; }

        public Employee(int EmployeeId, string fullName, bool PayStatus)
        {
            ID = EmployeeId;
            FullName = fullName;
            Salary = 0;
            IsPaid = PayStatus;
        }

        public abstract void EmployeeStatus();

        public virtual string PayStatus()
        {
            if (IsPaid)
            {
                return $"Paid";
            }
            else
            {

                return $"Not Paid";
            }
        }

        public virtual void PaySalary()
            {
                if (IsPaid)
                {
                    IsPaid = false;
                    Console.WriteLine();
                    Console.WriteLine($"{FullName} has just been paid their salary");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{FullName} error, this employee has already been paid their salary");
                    Console.WriteLine();
                }
            }
        }
    }
