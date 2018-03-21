using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models.Contracts
{
    public interface IHospital
    {
        string Name { get; set; }
        decimal Revenue { get; set; }
        int NumberOfEmployees { get; set; }
        List<Doctor> Doctors { get; set; }
    }
}
