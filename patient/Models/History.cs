using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace patient.Models
{
    public class History
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string DoctorName { get; set; }
        public string Diagnosis { get; set; }
        public string Complaint { get; set; }
        public DateTime VisitDate { get; set; }
    }
}