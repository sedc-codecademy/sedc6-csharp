using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models.Contracts
{
    public interface ISymptom
    {
        string Name { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string Description { get; set; }
    }
}
