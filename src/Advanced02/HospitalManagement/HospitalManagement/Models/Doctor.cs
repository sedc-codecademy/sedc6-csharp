using HospitalManagement.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class Doctor : Human
    {
        //Properties: ID, FirstName, LastName, Specialty, Salary

        public string Speciality { get; set; }
        public decimal Salary { get; set; }
    }
}
