using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Receptionist_Tests
    {
        [Fact]
        public void Can_Pay_Receptionist()
        {
            Receptionist receptionist = new Receptionist(3, "Amber Lake", false, false);

            receptionist.PaySalary();

            Assert.True(receptionist.IsPaid);
        }

        [Fact]
        public void Receptionist_Has_Name()
        {
            Receptionist receptionist = new Receptionist(3, "Mila", false, false);

            Assert.Equal("Mila", receptionist.FullName);
        }

        [Fact]
        public void Receptionist_Has_An_Employee_Id()
        {
            Receptionist receptionist = new Receptionist(4, "Mila", false, false);

            Assert.Equal(4, receptionist.ID);
        }

        [Fact]
        public void Receptionist_Can_Make_PhoneCall()
        {
            Receptionist receptionist = new Receptionist(4, "Mila", false, false);

            receptionist.MakePhoneCall();

            Assert.True(receptionist.IsOnPhone);
        }
    }
}

