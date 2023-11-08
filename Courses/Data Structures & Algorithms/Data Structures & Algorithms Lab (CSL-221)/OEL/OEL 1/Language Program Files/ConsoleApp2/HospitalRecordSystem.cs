using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HospitalRecordSystem
    {
        private Dictionary<string, List<PatientRecord>> recordShelves = new Dictionary<string, List<PatientRecord>>();

        public void AddPatientRecord(string serialNumber, string department, string patientName)
        {
            if (!recordShelves.ContainsKey(department))
            {
                recordShelves[department] = new List<PatientRecord>();
            }
            PatientRecord newRecord = new PatientRecord
            {
                SerialNumber = serialNumber,
                Department = department,
                PatientName = patientName
            };
            recordShelves[department].Add(newRecord);

            Console.WriteLine($"Patient record added: {newRecord}");
            ShowRecordsByDepartment(department);
        }
        public void RemovePatientRecord(string serialNumber, string department)
        {
            if (recordShelves.ContainsKey(department))
            {
                var records = recordShelves[department];
                var recordToRemove = records.Find(r => r.SerialNumber == serialNumber);

                if (recordToRemove != null)
                {
                    records.Remove(recordToRemove);
                    Console.WriteLine($"Patient record removed: {recordToRemove}");
                    ShowRecordsByDepartment(department);
                }
                else
                {
                    Console.WriteLine("Record not found in the specified department.");
                }
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }
        public void SortRecordsByDepartment(string department)
        {
            if (recordShelves.ContainsKey(department))
            {
                recordShelves[department] = recordShelves[department].OrderByDescending(r => r.SerialNumber).ToList();
                Console.WriteLine($"Records in department {department} sorted by serial number in descending order:");
                ShowRecordsByDepartment(department);
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }
        public void SearchPatientRecord(string serialNumber, string department)
        {
            if (recordShelves.ContainsKey(department))
            {
                var record = recordShelves[department].Find(r => r.SerialNumber == serialNumber);
                if (record != null)
                {
                    Console.WriteLine($"Patient record found: {record}");
                }
                else
                {
                    Console.WriteLine("Patient record not found.");
                }
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }
        public void ShowRecordsByDepartment(string department)
        {
            if (recordShelves.ContainsKey(department))
            {
                Console.WriteLine($"Records in department {department}:");
                foreach (var record in recordShelves[department])
                {
                    Console.WriteLine(record);
                }
                Console.WriteLine($"Total records in department {department}: {recordShelves[department].Count}");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }
    }
}
