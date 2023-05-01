using AdmissionSettings.DataAccess.Context;
using AdmissionSettings.Domain.DTOs;
using AdmissionSettings.Domain.Entities;
using AdmissionSettings.Domain.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdmissionSettings.DataAccess.Implementation
{
    public class AdmissionSessionRepository : IAdmissionSessionRepository 
    {
        private readonly AdmissionSettingsDbContext _context;
        private readonly IMapper _mapper;
        public AdmissionSessionRepository(AdmissionSettingsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(AdmissionSessionDto dto )
        {
            var entity = _mapper.Map<AdmissionSession>(dto);
            _context.AdmissionSessions.Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<AdmissionSessionDto> dto)
        {
            var entities = _mapper.Map<IEnumerable<AdmissionSession>>(dto);
            _context.AdmissionSessions.AddRange(entities);
        }

        

        public IEnumerable<AdmissionSessionDto> GetAll()
        {
           var entities= _context.AdmissionSessions.ToList();
            var Dtos = _mapper.Map<IEnumerable<AdmissionSessionDto>>(entities);
            return Dtos;

        }

        public AdmissionSessionDto GetById(int id)
        {
            var entity = _context.AdmissionSessions.Where(x => x.Id == id).FirstOrDefault();

            var dto = _mapper.Map<AdmissionSessionDto>(entity);
            return dto;

        }

        public void Remove(int id)
        {
            var admissionSessiondel = _context.AdmissionSessions.Where(admissionSession => admissionSession.Id == id).FirstOrDefault();
            
            _context.AdmissionSessions.Remove(admissionSessiondel);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<AdmissionSessionDto> entities)
        {
            var entitties = _context.AdmissionSessions.ToList();
            var Dtos = _mapper.Map<IEnumerable<AdmissionSessionDto>>(entities);
            
           
        }

        public void Update(AdmissionSessionDto dto)
        {
            var admissionSessionupt =  _context.AdmissionSessions.Where(admissionSession  => admissionSession.Id == dto.Id ).FirstOrDefault();
        
            if (admissionSessionupt != null)
            {
                admissionSessionupt.Year = dto.Year;
                admissionSessionupt.IsPublished = dto.IsPublished;
                admissionSessionupt.EndDate = dto.EndDate;
                admissionSessionupt.StartDate = dto.StartDate;
                admissionSessionupt.Name = dto.Name;
            }
     

            _context.SaveChanges();
        }
    }
}
