using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Nurse_Tests
    {
        [Fact]
        public void Can_Pay_Nurse()
        {
            Nurse nurse = new Nurse(1, "Nurse", false, 2);

            nurse.PaySalary();

            Assert.True(nurse.IsPaid);
        }

        [Fact]

        public void Nurse_Can_Treat_Health_level()
        {
            Nurse nurse = new Nurse(1, "Nurse", false, 2);

            Patient patient = new Patient(1, "patient");
            nurse.NurseCareForPatient(patient);

            Assert.Equal(70, patient.HealthLevel);
        }

        [Fact]

        public void Nurse_Can_Draw_Blood() 
        {
            Nurse nurse = new Nurse(1, "Nurse", false, 2);

            Patient patient = new Patient(1, "patient");
            nurse.NurseDrawBlood(patient); 

            Assert.Equal(15, patient.BloodLevel);
        }

        [Fact]
        public void Nurse_Has_An_Employee_Id()
        {
            Nurse nurse = new Nurse(2, "Nurse", false, 2);

            Assert.Equal(2, nurse.ID);
        }

        //[Fact]
        //public void Nurse_Has_A_Job_Title()
        //{
        //    Nurse nurse = new Nurse(1, "Nurse", "Nurse", 2, false);

        //    Assert.Equal("Nurse", nurse.JobTitle);
        //}

        [Fact]
        public void Nurse_Has_Patients()
        {
            Nurse nurse = new Nurse(1, "Nurse", false, 2);

            Assert.Equal(2, nurse.PatientLoad);
        }
    }
}

