using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class PatientTests
    {
        [Fact]
        public void Blood_Draw_Lowers_BloodLevel()
        {
            var patient = new Patient();

            patient.DrawBlood();

            Assert.Equal(50, patient.BloodLevel);
        }
    }
}
