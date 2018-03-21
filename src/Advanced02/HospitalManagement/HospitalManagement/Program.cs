using HospitalManagement.Models;
using HospitalManagement.Models.Contracts;

namespace HospitalManagement
{
    class Program
    {
        /*
         Aplication Name: Hospital
1. Doctor
    Properties: ID, FirstName, LastName, Specialty, Salary
2. Nurse
    Properties: ID, FirstName, LastName, Salary
2. Patient 
    Properties: ID, FirstName, LastName, Illness, List of Simptoms
3. Symptom
    Properties: Name, FromDate, ToDate, Despcription
4. Diagnose
    Properties: Name, Despcription

5. Exam
    Properties: Time, Doctor, Patient, list of Simptoms, Diagnose
6. Hospital:
    Properties: Name, Revenue, NumberOfEmployees, list of doctors
             */
        static void Main(string[] args)
        {
            IPatient patient = new Patient();
            patient.Symptoms.Add(new Symptom());
            System.Console.WriteLine("I made it!!!");
        }
    }
}
