using HospitalManagement.Models.Base;
using HospitalManagement.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    /*
     * 2. Nurse
    Properties: ID, FirstName, LastName, Salary
     */
    public class Nurse : Human, INurse
    {
        //public decimal Salary { get; set; }
        public decimal Salary { get; set; }
    }
}
