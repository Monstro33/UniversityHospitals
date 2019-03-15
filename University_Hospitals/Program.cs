using System;
using UniversityHospitals;
using System.Text;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital myHospital = new Hospital();
            Menu myMenu = new Menu();
            Janitor janitor = new Janitor(1, "janitor", false, false);
            Receptionist receptionist = new Receptionist(3, "receptionist", false, false);

            while (true)
            {
                Console.WriteLine("====================================MENU====================================\n\n");
                Console.WriteLine("\t\t\tUniversity Hospitals \n\t\tPatient and Employee Management System.");
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
                Console.WriteLine();

                bool running = true;

                while (running)
                {
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine();
                            myHospital.EmployeeList();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine();
                            myHospital.AllEmployeeStatus();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.EmployeeMenu();
                            //int ID = Convert.ToInt32(Console.ReadLine());
                            //myHospital.Trea(myHospital.AllPatients[ID]);
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine();
                            myHospital.PayAll();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            Console.WriteLine();
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine();
                            myHospital.PatientList();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            Console.WriteLine();
                            break;
                        case "6":
                            Console.Clear();
                            myHospital.PatientList();
                            Console.WriteLine();
                            Console.WriteLine("Select a patient by Patient ID.");
                            int index = Convert.ToInt32(Console.ReadLine());
                            int Id = index - 1;
                            Console.WriteLine();
                            myHospital.DrawBlood(myHospital.AllPatients[Id]);
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            break;
                        case "7":
                            Console.Clear();
                            myHospital.PatientList();
                            Console.WriteLine();
                            Console.WriteLine("Select a patient by Patient ID.");
                            int index2 = Convert.ToInt32(Console.ReadLine());
                            int Id2 = index2 - 1;
                            Console.WriteLine();
                            myHospital.PatientCare(myHospital.AllPatients[Id2]);
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            break;
                        case "8":
                            Console.Clear();
                            Console.WriteLine();
                            receptionist.MakePhoneCall();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            Console.WriteLine();
                            break;
                        case "9":
                            Console.Clear();
                            //myHospital.Sweep();
                            Console.WriteLine();
                            Console.WriteLine();
                            myMenu.MainMenu();
                            break;
                        case "0":
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("\tThank you for using UniversityHospitals Employee and \n\tPatient Tracking system. Hit the enter button to exit");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("\tPlease choose a valid selection.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
