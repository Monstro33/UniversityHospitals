using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Can_Pay_Doctor()
        {
            var doctor = new Doctor();


            doctor.PayEmployee();

            Assert.True(doctor.Paid);
        }

    }
}
