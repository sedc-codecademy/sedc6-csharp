using HospitalManagement.Models.Contracts;
using System.Collections.Generic;
using System;

namespace HospitalManagement.Models
{
    /*
     5. Exam
    Properties: Time, Doctor, Patient, list of Simptoms, Diagnose
         */
    public class Exam : IExam
    {
        public DateTime Time { get; set; }
        public IDoctor Doctor { get; set; }
        public IPatient Patient { get; set; }
        public ICollection<ISymptom> Symtom { get; set; }
        public IDiagnose Diagnose { get; set; }

    }
}
