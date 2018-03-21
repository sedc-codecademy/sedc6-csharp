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
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public List<Symptom> Symtom { get; set; }
        public Diagnose Diagnose { get; set; }

    }
}
