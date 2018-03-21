using HospitalManagement.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    /*
     * Illness, 
     * List of Symptoms
     */
    public class Patient : Human
    {
        public string Illness { get; set; }
        public List<Symptom> Symptoms { get; set; }
    }
}
