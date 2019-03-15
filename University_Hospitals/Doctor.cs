using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Doctor:Employee
    {
        public string JobSpecialty { get; set; }

        public Doctor(int EmployeeId, string fullName, bool IsPaid, string jobSpecialty) : base(EmployeeId, fullName, IsPaid)
        {
            JobSpecialty = jobSpecialty;
            Salary = 90000;
        }

        public override void PaySalary()
        {
            base.PaySalary();
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"Doctor {FullName},  {JobSpecialty} specialist, is {PayStatus().ToString()}");
            Console.WriteLine();
        }

        public override string PayStatus()
        {
            return base.PayStatus();
        }

        public void DoctorDrawBlood(Patient patient)
        {
            Console.WriteLine();
            Console.WriteLine($"Doctor {FullName} has administered a blood draw on Patient{patient.FullName}");
            patient.BloodLevel -= 15;
            patient.HealthLevel -= 5;
        }

        public void DoctorCareForPatient(Patient patient)
        {
            Console.WriteLine();
            Console.WriteLine($"Doctor {FullName} has just administered care to Patient {patient.FullName}");
            patient.HealthLevel += 25;
            patient.BloodLevel += 10;
        }
    }
}