using HospitalManagement.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    /*
     * 4. Diagnose
    Properties: Name, Description
     */
    public class Diagnose : IDiagnose
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
