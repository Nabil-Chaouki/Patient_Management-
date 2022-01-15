using Patient_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_Management.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public PatientRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public IEnumerable<Patient> AllPatients{
            get
            {
                return _applicationDbContext.Patients;
            }
        }
       
    }
}
