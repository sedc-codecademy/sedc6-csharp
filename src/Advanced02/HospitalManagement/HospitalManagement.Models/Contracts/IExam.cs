using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models.Contracts
{
    public interface IExam
    {
        DateTime Time { get; set; }
        IDoctor Doctor { get; set; }
        IPatient Patient { get; set; }
        ICollection<ISymptom> Symtom { get; set; }
        IDiagnose Diagnose { get; set; }
    }
}
