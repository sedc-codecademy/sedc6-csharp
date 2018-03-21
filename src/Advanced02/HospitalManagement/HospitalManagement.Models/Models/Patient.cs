using HospitalManagement.Models.Contracts;
using HospitalManagement.Models.Base;
using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Patient : IPatient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Illness { get; set; }
        public List<Symptom> Symptoms { get; set; }
    }
}
