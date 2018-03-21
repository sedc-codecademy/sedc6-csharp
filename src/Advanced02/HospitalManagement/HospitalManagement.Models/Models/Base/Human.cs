using HospitalManagement.Models.Contracts.Base;

namespace HospitalManagement.Models.Base
{
    public abstract class Human : IHuman
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
