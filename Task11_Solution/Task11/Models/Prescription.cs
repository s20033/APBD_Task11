using System;

namespace Task11.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public int IdPatient { get; set; }

        public virtual Patient Patient { get; set; }

    }
}
