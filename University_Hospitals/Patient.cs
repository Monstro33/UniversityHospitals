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
        public Patient(int patientId, string fullName, int bloodLevel, int healthLevel)
        {
            PatientId = patientId;
            FullName = fullName;
            BloodLevel = bloodLevel;
            HealthLevel = healthLevel;
        }

        public List<Patient> AllPatients { get; set; }

        public Patient()
        {
            BloodLevel = 25;
            HealthLevel = 25;
            AllPatients = new List<Patient>()
            {
                    new Patient(1, "Rick Ross", 25, 25),
                    new Patient(2, "John Mayer", 25, 25),
                    new Patient(3, "Tupac Shakur", 25, 25),
                    new Patient(4, "Biggie Smalls", 25, 25)
                };
        }

        public void PatientStatus()
        {
            for (int i = 0; i < AllPatients.Count; i++)
            {
                Console.Clear();
                Console.WriteLine("ID: " + PatientId);
                Console.WriteLine("NAME: " + FullName);
                Console.WriteLine("HEALTH LEVEL: " + HealthLevel);
                Console.WriteLine("BLOOD LEVEL: " + BloodLevel);
                Console.ReadKey();
            }
        }

        public void MinMax()
        {
            if (HealthLevel > 100)
            {
                HealthLevel = 100;
            }
            if (BloodLevel > 100)
            {
                BloodLevel = 100;
            }
            if (HealthLevel < 0)
            {
                HealthLevel = 0;
            }
            if (BloodLevel < 0)
            {
                BloodLevel = 0;
            }
        }

        public void DrawBlood()
        {
            BloodLevel -= 10;
            HealthLevel -= 10;
            MinMax();
        }

        public void Care()
        {
            HealthLevel += 25;
            BloodLevel += 15;
            MinMax();
        }

        public void Deteriorate()
        {
            HealthLevel -= 5;
            BloodLevel -= 5;
            MinMax();
        }
    }
}

        //public void PatientDeath()
        //{
        //    if (BloodLevel == 0)
        //    {
        //        Console.WriteLine("Your patient has expired, prepare for a lawsuit");
        //    }

    //public void TimeTick(Patient patient)
    //{
    //    for (int i = 0; i < patient.Count; i++) ;
    //    patients{
    //        patient[Pati.Deteriorate();
    //    }
