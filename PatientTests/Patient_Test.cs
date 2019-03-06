using System;
using UniversityHospitals;
using Xunit;

namespace Patient_Tests
{
    public class Patient_Test
    {
        [Fact]
        public void IncreaseBloodLevelTest()
        {
            var testPatient = new Patient();
            testPatient.IncreaseBloodLevel();
            Assert.Equal(100, testPatient.BloodLevel);
        }

        //[Fact]
        //public void DoctorCanEffectBloodLevel()
        //{
        //    var doctor = new Patient();
        //    doctor.IncreaseBloodLevel();
        //    Assert.equal
        //}

    }
}
