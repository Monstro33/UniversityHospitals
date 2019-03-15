using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Janitor_Tests
    {
        [Fact]
        public void Can_Pay_Janitor()
        {
            Janitor janitor = new Janitor(4, "Janitor", false, false);

            janitor.PaySalary();

            Assert.True(janitor.IsPaid);
        }

        [Fact]
        public void Janitor_Has_Name()
        {
            Janitor janitor = new Janitor(4, "Maximus", false, false);

            Assert.Equal("Maximus", janitor.FullName);
        }

        [Fact]
        public void Janitor_Has_An_Employee_Id()
        {
            Janitor janitor = new Janitor(4, "Janitor", false, false);

            Assert.Equal(4, janitor.ID);
        }

        //[Fact]
        //public void Janitor_Has_A_Job_Title()
        //{
        //    Janitor janitor = new Janitor(4, "Janitor", false, false);

        //    Assert.Equal("Janitor", janitor.JobPosition);
        //}

        [Fact]
        public void Janitor_Can_Sweep()
        {
            Janitor janitor = new Janitor(4, "Maximus", false, false);

            janitor.Sweep();

            Assert.True(janitor.IsSweeping);
        }
    }
}
