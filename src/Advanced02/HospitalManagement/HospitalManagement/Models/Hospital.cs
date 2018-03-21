using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    /*
     * 6. Hospital:
    Properties: Name, Revenue, NumberOfEmployees, list of doctors
     */
    public class Hospital
    {
        public string Name { get; set; }
        public decimal Revenue { get; set; }
        public int NumberOfEmployees { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}
