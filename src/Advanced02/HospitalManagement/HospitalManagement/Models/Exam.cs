using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    /*
     5. Exam
    Properties: Time, Doctor, Patient, list of Simptoms, Diagnose
         */
    public class Exam
    {
        public DateTime Time { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public List<Symptom> Symtom { get; set; }
        public Diagnose Diagnose { get; set; }

    }
}
