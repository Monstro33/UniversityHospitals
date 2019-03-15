using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Nurse : Employee
    {
        public int PatientLoad { get; set; }

        public Nurse(int EmployeeId, string fullName, bool IsPaid, int patientLoad) : base(EmployeeId, fullName, IsPaid)
        {
            PatientLoad = patientLoad;
            Salary = 50000;
        }

        public override string PayStatus()
        {
            return base.PayStatus();
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine($"Nurse {FullName}, is {PayStatus().ToString()}, and currently has a patient load of {PatientLoad} patients.");
            Console.WriteLine();
        }

        public void NurseDrawBlood(Patient patient)
        {
            Console.WriteLine($"Nurse {FullName} has just administered a blood draw on {patient.FullName}");
            patient.BloodLevel -= 10;
        }

        public void NurseCareForPatient(Patient patient)
        {
            Console.WriteLine($"Nurse {FullName} has just administered care to {patient.FullName}");
            patient.HealthLevel += 35;
        }
    }
}
