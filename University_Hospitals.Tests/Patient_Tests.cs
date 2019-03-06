using System;
using Xunit;

namespace UniversityHospitals.Tests
{
    public class Patient_Tests
    {
        [Fact]
        public void Doctor_Can_Draw_Blood()
        {
            //Arrange
            var testPatient = new Patient();

            //Act
            testPatient.DoctorIncreaseBloodLevel();

            //Assert
            Assert.Equal(50, testPatient.BloodLevel);
        }

        [Fact]
        public void Nurse_Can_Draw_Blood()
        {
            //Arrange
            var patient = new Patient();

            //Act
            patient.NurseIncreaseBloodLevel();

            //Assert
            Assert.Equal(50, patient.BloodLevel);
        }
    }
}

//        //[Fact]
//        //public void Doctor_Care_For_Patient()
//        //{
//        //    // Arrange
//        //    var myDoctor = new Employee();
//        //    var Patient = new Patient();

//        //    //Act
//        //    myDoctor.Care_For_Patient(ref Patient);

//        //    //Assert
//        //    Assert.Equal(35, Patient.HealthLevel);
//        //}

//        //[Fact]
//        //public void Nurse_Care_For_Patient()
//        //{
//        //    //Arrange
//        //    var Nurse = new Employee();
//        //    var Patient = new Patient();

//        //    //Act
//        //    Nurse.Care_For_Patient(ref Patient);

//        //    //Assert
//        //    Assert.Equal(20, Patient.HealthLevel);
//        //}

//    }
//}




