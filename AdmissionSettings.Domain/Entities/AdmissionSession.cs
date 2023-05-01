using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain.Entities
{
    public class AdmissionSession
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? StartDate { get; set; }   
        public string? EndDate { get; set; }
        public string IsPublished { get; set; } = "N"; 
    }
}
