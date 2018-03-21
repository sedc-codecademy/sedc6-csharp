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
        Doctor Doctor { get; set; }
        Patient Patient { get; set; }
        List<Symptom> Symtom { get; set; }
        Diagnose Diagnose { get; set; }
    }
}
