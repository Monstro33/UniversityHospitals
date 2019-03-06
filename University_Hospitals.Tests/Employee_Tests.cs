using System;
using System.Collections.Generic;
using System.Text;
using UniversityHospitals;
using Xunit;

namespace University_Hospitals_Tests
{
    public class Employee_Tests
    {
        [Fact]
        public void Can_Pay_Employees()
        {
            //Arrange
            var testEmployee = new Employee();

            //Act
            testEmployee.PayEmployee();

            //Assert
            Assert.True(testEmployee.Paid);
        }
    }
}

        //[Fact]
        //public void ()
        //{
        //    //Arrange
        //    var testEmployee = new Employee();

        //    //Act
        //    testEmployee.PayEmployee();

        //    //Assert
        //    Assert.True(testEmployee.Paid);
 


