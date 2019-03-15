using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospitals
{
    public class Hospital
    {
        public List<Employee> AllEmployees { get; set; }
        public List<Patient> AllPatients { get; set; }
        Janitor janitor = new Janitor(1, "janitor", false, false);
        Receptionist receptionist = new Receptionist(3, "receptionist", false, false);

        public Hospital()
        {
            AllEmployees = new List<Employee>()
        {
                new Doctor(33,"Michael", false, "Emergency Medicine"),
                new Nurse(21,"Amber", false, 2),
                new Receptionist(7,"Mila", false, false),
                new Janitor(19,"Maximus", false, false)
        };
            AllPatients = new List<Patient>()
            {
                new Patient(1,"Tupac"),
                new Patient(2,"Biggie"),
                new Patient(3,"Tentacion"),
                new Patient(4,"Marilyn")
            };

        }
        public void EmployeeList()
        {
            Console.WriteLine("| ID | Patient ID |     Name     |  Job Position  | Salary | Ispaid |");
            for (int i = 0; i < AllEmployees.Count; i++)
            {
                Console.WriteLine("  {0}     {1}        {2}          {3}    {4}   {5}",
                i.ToString().PadRight(2),
                AllEmployees[i].ID.ToString().PadRight(2),
                AllEmployees[i].FullName.PadRight(8),
                JobPosition(i).PadRight(13),
                AllEmployees[i].Salary.ToString().PadRight(5),
                AllEmployees[i].IsPaid.ToString().PadRight(5)
                );
            }
        }

        public void PatientList()
        {
            Console.WriteLine();
            Console.WriteLine("| ID | Patient ID |  Full Name  |  Health Level  |  Blood Level  |");
            for (int i = 0; i < AllPatients.Count; i++)
            {

                Console.WriteLine("  {0}     {1}         {2}           {3}       {4}",
                i.ToString().PadRight(2),
                AllPatients[i].PatientId.ToString().PadRight(5),
                AllPatients[i].FullName.PadLeft(4),
                AllPatients[i].HealthLevel.ToString().PadRight(3),
                AllPatients[i].BloodLevel.ToString().PadLeft(10)

                );
            }
            Console.WriteLine();
        }

        public void SelectEmployee()
        {
            bool run = true;
            string input;
            while (run)
            {
                Console.WriteLine();
                Console.Write("Please select an ID number from the first colum.");
                Console.WriteLine();
                input = Console.ReadLine();
                int i = 0;

                do
                {
                    if (AllEmployees[i].ID.Equals(input))
                    {
                        AllEmployees[i].EmployeeStatus();
                        run = false;
                    }
                    i++;
                }
                while (i < AllEmployees.Count);
            }
        }

        public void AllEmployeeStatus()
        {

            for (int i = 0; i < AllEmployees.Count; i++)
            {
                AllEmployees[i].EmployeeStatus();
            }
        }

        public void PatientCare(Patient patient)
        {
            Console.WriteLine();
            Console.WriteLine($"You selected Patient {patient.FullName} to receive a patient care."); ;
            Console.WriteLine();
            Console.WriteLine("Press 0 for Doctor to provide care.");
            Console.WriteLine("Press 1 for Nurse to provide care.");
            int index = Convert.ToInt32(Console.ReadLine());
            Employee employee = AllEmployees[index];
            if (employee.GetType() == typeof(Doctor))
            {
                Doctor doctor = employee as Doctor;
                doctor.DoctorCareForPatient(patient);
                Console.WriteLine();
                Console.WriteLine($"{patient.FullName}'s Health Level and Blood Level have changed.");
                Console.WriteLine();
            }
            else if (employee.GetType() == typeof(Nurse))
            {
                Nurse nurse = employee as Nurse;
                nurse.NurseCareForPatient(patient);
                Console.WriteLine();
                Console.WriteLine($"{patient.FullName}'s Health Level and Blood Level have changed.");
            }
        }

        public void DrawBlood(Patient patient)
        {
            Console.WriteLine();
            Console.WriteLine($"You selected Patient {patient.FullName} to receive a blood draw.");
            Console.WriteLine();
            Console.WriteLine("Press 0 for Doctor to provide care.");
            Console.WriteLine("Press 1 for Nurse to provide care.");
            int index = Convert.ToInt32(Console.ReadLine());
            Employee employee = AllEmployees[index];
            if (employee.GetType() == typeof(Doctor))
            {
                Doctor doctor = employee as Doctor;
                doctor.DoctorDrawBlood(patient);
                Console.WriteLine();
                Console.WriteLine($"{patient.FullName}'s Health Level and Blood Level have changed.");
            }
            else if (employee.GetType() == typeof(Nurse))
            {
                Nurse nurse = employee as Nurse;
                nurse.NurseDrawBlood(patient);
                Console.WriteLine();
                Console.WriteLine($"{patient.FullName}'s Health Level and Blood Level have changed.");
            }
        }

        public void PayAll()
        {
            for (int i = 0; i < AllEmployees.Count; i++)
            {
                AllEmployees[i].PaySalary();
            }
            Console.WriteLine();
            Console.WriteLine("All Employees have now been paid their salary.");
            Console.WriteLine();
        }

        public string JobPosition(int i)
        {
            if (AllEmployees[i].GetType() == typeof(Doctor))
            {
                return "Doctor";
            }
            else if (AllEmployees[i].GetType() == typeof(Nurse))
            {
                return "Nurse";
            }
            else if (AllEmployees[i].GetType() == typeof(Janitor))
            {
                return "Janitor";
            }
            else if (AllEmployees[i].GetType() == typeof(Receptionist))
            {
                return "Receptionist";
            }
            return "N/A";
        }
    }
}



