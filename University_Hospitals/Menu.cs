using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\n\t\t   SELECT FROM THE OPTIONS BELOW:\n");
            Console.WriteLine("\t\t   Press 1 to view all employee list");
            Console.WriteLine("\t\t   Press 2 for employee work status");
            Console.WriteLine("\t\t   Press 3 to pay employees");
            Console.WriteLine("\t\t   Press 4 to pay a single employee");
            Console.WriteLine("\t\t   Press 5 to view all patients");
            Console.WriteLine("\t\t   Press 6 for blood draw.");
            Console.WriteLine("\t\t   Press 7 for patient care");
            Console.WriteLine("\t\t   Press 8 to have the Receptionist answer the phone.");
            Console.WriteLine("\t\t   Press 9 to have the Janitor sweep.");
            Console.WriteLine("\t\t   Press 0 to exit");
        }

        public void EmployeeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\n\t\t\t   SELECT FROM THE OPTIONS BELOW:\n");
            Console.WriteLine("\t\t   Press 6 for blood draw.");
            Console.WriteLine("\t\t   Press 7 for patient care");
            Console.WriteLine("\t\t   Press 8 to have Receptionist answer the phone.");
            Console.WriteLine("\t\t   Press 9 to have janitor sweep.");
        }
    }
}

     

    //        string userInput = Console.ReadLine();

    //            switch (userInput)
    //            {
    //                case "1":
    //                    myHospital.EmployeeStatus();

    //                    Console.WriteLine();
    //                    MainMenu(myHospital);
    //                    break;
    //                case "2":
    //                    myHospital.PatientsList();
    //                    MainMenu(myHospital);
    //                    break;
    //                case "3":
    //                    myHospital.PatientStatus();
    //                    MainMenu(myHospital);
    //                    break;
    //                default:
    //                    Console.WriteLine("Please choose a valid selection.");
    //                    Console.ReadLine();
    //                    break;
    //            }
    //        }
    //    }
    //}





//                case "1"://view all employees
//                    Console.Clear();
//                    myHospital.EmployeeStatus();
//                    break;
//                case "2"://view all patients
//                    Console.Clear();
//                    myHospital.PatientStatus();
//                    Console.WriteLine("\n\n\nPlease select from the options below: ");
//                    Console.WriteLine("\n\\tPress 1 to view current patients " +
//                    "\n\t\tPress 4 to draw blood from a patient " +
//                    "\n\t\tPress 5 to care for a patient " +
//                    "\n\t\tPress 0 to exit the application ");
//                    break;
//                case "0"://Close the program
//                    Console.WriteLine("Thank you for using UniversityHospitals Employee ans Patient Tracking system. Hit the enter button to exit");
//                    Console.ReadKey();
//                    Environment.Exit(0);
//                    break;
//            }
//        }
//    }
//}
