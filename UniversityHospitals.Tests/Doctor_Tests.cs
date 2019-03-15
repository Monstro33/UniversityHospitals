using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Doctor_Tests
    {
        [Fact]
        public void Can_Pay_Doctor()
        {
            Doctor doctor = new Doctor(1, "Doctor", false, "Doctor");

            doctor.PaySalary();

            Assert.True(doctor.IsPaid);
        }

        [Fact]

        public void Doctor_Can_Treat_Health_level()
        {
            Doctor doctor = new Doctor(1, "Doctor", false, "Doctor");

            Patient patient = new Patient(1, "patient");
            doctor.DoctorCareForPatient(patient);

            Assert.Equal(60, patient.HealthLevel);
        }

        [Fact]

        public void Doctor_Can_Draw_Blood()
        {
             Doctor doctor = new Doctor(1, "Doctor", false, "Doctor");

            Patient patient = new Patient(1, "patient");
            doctor.DoctorDrawBlood(patient);

            Assert.Equal(10, patient.BloodLevel);
        }

        [Fact]
        public void Doctor_Has_An_Employee_Id()
        {
            Doctor doctor = new Doctor(1, "Doctor", false, "Doctor");

            Assert.Equal(1, doctor.ID);
        }

        //[Fact]
        //public void Doctor_Has_A_Job_Title()
        //{
        //    Doctor doctor = new Doctor(1, "Doctor", false, "Emergency Medicine");

        //    Assert.Equal("Emergency Medicine", doctor.JobSpecialty);
        //}

        [Fact]
        public void Doctor_Has_A_Job_Specialty()
        {
            Doctor doctor = new Doctor(1, "Doctor", false, "Emergency Medicine");

            Assert.Equal("Emergency Medicine", doctor.JobSpecialty);
        }
    }
}
