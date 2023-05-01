using AdmissionSettings.DataAccess.Context;
using AdmissionSettings.Domain.Entities;
using AdmissionSettings.Domain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWorkRepository
    {
        private readonly AdmissionSettingsDbContext _context;
        private readonly IMapper _mapper;

        public UnitOfWork(AdmissionSettingsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            AdmissionSession = new AdmissionSessionRepository (_context, _mapper);
            AdmissionSessionRequest = new AdmissionSessionRequestRepository (_context, _mapper);
        }
        public IAdmissionSessionRepository AdmissionSession { get; private set; }    
        public IAdmissionSessionRequestRepository AdmissionSessionRequest { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
