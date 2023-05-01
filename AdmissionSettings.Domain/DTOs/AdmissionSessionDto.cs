using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain.DTOs
{
    public class AdmissionSessionDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public int Year { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string IsPublished { get; set; } = "N";
    }
}
