using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }

        //constructors
        public Patient(int id, string fullName)
        {
            PatientId = id;
            FullName = fullName;
            BloodLevel = 25;
            HealthLevel = 35;
        }

        public void Deteriorate()
        {
            HealthLevel -= 5;
            BloodLevel -= 5;
        }
    }
}
