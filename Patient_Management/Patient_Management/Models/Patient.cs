using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_Management.Models
{
    public class Patient
    {
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LasteName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public  string Email { get; set; }
        public int Social_Security_Number { get; set; }
        public string CIN { get; set; }
        public string Gender { get; set; }
        public string Blood_Type { get; set; }
        public string Adresss { get; set; }
        public string Image { get; set; }
    }
}
