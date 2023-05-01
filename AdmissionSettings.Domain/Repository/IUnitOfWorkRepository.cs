using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain.Repository
{
    public interface IUnitOfWorkRepository : IDisposable 
    {
        IAdmissionSessionRepository AdmissionSession { get; }
        IAdmissionSessionRequestRepository AdmissionSessionRequest { get; }

        int Save();
    }
}
