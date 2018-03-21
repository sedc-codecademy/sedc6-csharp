using HospitalManagement.Models.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Models.Contracts
{
    public interface IPatient : IHuman
    {
        string Illness { get; set; }
        ICollection<ISymptom> Symptoms { get; set; }
    }
}
