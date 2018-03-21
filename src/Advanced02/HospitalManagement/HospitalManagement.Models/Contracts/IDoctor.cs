using HospitalManagement.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models.Contracts
{
    public interface IDoctor : IEmployee
    {
        string Speciality { get; set; }
    }
}
