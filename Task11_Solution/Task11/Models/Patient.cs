using System;
using System.Collections.Generic;

namespace Task11.Models
{
    public class Patient

    {
        public Patient()
        {

        Prescriptions =new HashSet<Prescription>();
        } 

        public int IdPatient { get; set; }
        public String Firstname { get; set; }
        public String FirstName { get; internal set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
  
    }
}
