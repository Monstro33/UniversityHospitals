using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Patient_Tests
    {
        [Fact]
        public void Patient_Blood_Level_Can_Change()  
        {
            Patient patient = new Patient(1, "Patient");
            
            Nurse nurse = new Nurse(1, "Nurse", false, 2);
            nurse.NurseDrawBlood(patient);
            
            Assert.Equal(15, patient.BloodLevel);
        }

        [Fact]
        public void Patient_Health_Level_Can_Change()
        {
            Patient patient = new Patient(1, "Patient");

            Nurse nurse = new Nurse(1, "Nurse", false, 2);
            nurse.NurseCareForPatient(patient);

            Assert.Equal(70, patient.HealthLevel);
        }
    }
}