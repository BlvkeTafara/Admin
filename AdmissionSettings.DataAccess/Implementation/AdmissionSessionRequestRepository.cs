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


namespace AdmissionSettings.DataAccess.Implementation
{
    public class AdmissionSessionRequestRepository :  IAdmissionSessionRequestRepository 
    {
        private readonly AdmissionSettingsDbContext _context;
        private readonly IMapper _mapper;

        public AdmissionSessionRequestRepository(AdmissionSettingsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(AdmissionSessionRequestDto dto)
        {
            var entity = _mapper.Map<AdmissionSessionRequest>(dto);
            _context.AdmissionSessionRequestz.Add(entity);
            _context.SaveChanges();
            
        }

        public void AddRange(IEnumerable<AdmissionSessionRequestDto> dto)
        {
            var entities = _mapper.Map<IEnumerable<AdmissionSessionRequest>>(dto);
            _context.AdmissionSessionRequestz.AddRange(entities);
            
        }

      

        public IEnumerable<AdmissionSessionRequestDto> GetAll()
        {
            var entities = _context.AdmissionSessionRequestz.ToList();
            var Dtos = _mapper.Map<IEnumerable<AdmissionSessionRequestDto>>(entities);
            return Dtos;
            
        }

        public AdmissionSessionRequestDto GetById(int id)
        {
            var entity = _context.AdmissionSessionRequestz.Where(x => x.Id == id).FirstOrDefault();

            var dto = _mapper.Map<AdmissionSessionRequestDto>(entity);
            return dto;

            
        }

        public void Remove(int id)
        {
            var admissionSessionRequestdel = _context.AdmissionSessionRequestz.Where(admissionSessionRequest => admissionSessionRequest.Id == id).FirstOrDefault();

            _context.AdmissionSessionRequestz.Remove(admissionSessionRequestdel);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<AdmissionSessionRequestDto> entities)
        {
            var entitties = _context.AdmissionSessionRequestz.ToList();
            var Dtos = _mapper.Map<IEnumerable<AdmissionSessionRequestDto>>(entities);

            
        }

        public void Update(AdmissionSessionRequestDto dto)
        {
            var admissionSessionRequestupt = _context.AdmissionSessionRequestz.Where(admissionSessionRequest => admissionSessionRequest.Id == dto.Id).FirstOrDefault();

            if (admissionSessionRequestupt != null)
            {
                admissionSessionRequestupt.Year = dto.Year;
                admissionSessionRequestupt.IsPublished = dto.IsPublished;
                admissionSessionRequestupt.EndDate = dto.EndDate;
                admissionSessionRequestupt.StartDate = dto.StartDate;
                admissionSessionRequestupt.Name = dto.Name;
            }


            _context.SaveChanges();
        }
    }
}
