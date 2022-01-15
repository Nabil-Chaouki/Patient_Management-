using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_Management.Models
{
   public interface IPatientRepository
    {
        IEnumerable<Patient> AllPatients { get; }
        Patient GetPatientById(int Id);
    }
}
