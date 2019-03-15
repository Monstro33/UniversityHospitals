using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Receptionist : Employee
    {
        public bool IsOnPhone { get; set; }

        public Receptionist(int EmployeeId, string fullName, bool PayStatus, bool IsOnPhone) : base(EmployeeId, fullName, PayStatus)
        {
            Salary = 45000;
            IsOnPhone = false;
        }

        public override string PayStatus()
        {
            return base.PayStatus();
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine($"Receptionist {FullName}, is {PayStatus().ToString()}, and {PhoneStatus().ToString()}");
        }

        public virtual string PhoneStatus()
        {
            if (IsOnPhone)
            {
                return $"{FullName} is currently on the phone";
            }
            else
            {
                ;
                IsOnPhone = true;
                return $"{FullName} is not currently on the phone.";
            }
        }
        public void MakePhoneCall()
        {
            if (IsOnPhone == true)
            {
                IsOnPhone = false;
                Console.WriteLine("The Receptionist is now making phone calls");
            }
            else if (IsOnPhone == false)
            {
                IsOnPhone = true;
                Console.WriteLine("The Receptionist is currently not making phone calls");  
            }
        }
    }
}
