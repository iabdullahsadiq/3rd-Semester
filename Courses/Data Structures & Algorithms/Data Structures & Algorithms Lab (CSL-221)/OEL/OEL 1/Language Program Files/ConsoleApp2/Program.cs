using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalRecordSystem recordSystem = new HospitalRecordSystem();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add Patient Record");
            Console.WriteLine("2. Remove Patient Record");
            Console.WriteLine("3. Sort Records by Department");
            Console.WriteLine("4. Search Patient Record");
            Console.WriteLine("5. Exit");

            while (true)
            {
                Console.WriteLine("1. Add,  2. Remove,  3. Sort,  4. Search,  5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter serial number: ");
                        string serialNumber = Console.ReadLine();
                        Console.Write("Enter department: ");
                        string department = Console.ReadLine();
                        Console.Write("Enter patient name: ");
                        string patientName = Console.ReadLine();
                        recordSystem.AddPatientRecord(serialNumber, department, patientName);
                        break;

                    case 2:
                        Console.Write("Enter serial number: ");
                        serialNumber = Console.ReadLine();
                        Console.Write("Enter department: ");
                        department = Console.ReadLine();
                        recordSystem.RemovePatientRecord(serialNumber, department);
                        break;

                    case 3:
                        Console.Write("Enter department: ");
                        department = Console.ReadLine();
                        recordSystem.SortRecordsByDepartment(department);
                        break;

                    case 4:
                        Console.Write("Enter serial number: ");
                        serialNumber = Console.ReadLine();
                        Console.Write("Enter department: ");
                        department = Console.ReadLine();
                        recordSystem.SearchPatientRecord(serialNumber, department);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}