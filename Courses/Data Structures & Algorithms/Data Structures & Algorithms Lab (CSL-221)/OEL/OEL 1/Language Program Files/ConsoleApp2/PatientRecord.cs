using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PatientRecord
    {
        public string SerialNumber { get; set; }
        public string Department { get; set; }
        public string PatientName { get; set; }

        public override string ToString()
        {
            return $"{SerialNumber}-{Department}-{PatientName}";
        }
    }
}
