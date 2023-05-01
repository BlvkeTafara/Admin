using AdmissionSettings.Domain.DTOs;
using AdmissionSettings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain.Repository
{
    public interface IAdmissionSessionRequestRepository : IGenericRepository<AdmissionSessionRequestDto>
    {
      
    }
}
