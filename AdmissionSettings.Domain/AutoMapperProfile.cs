using AdmissionSettings.Domain.DTOs;
using AdmissionSettings.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<AdmissionSessionDto, AdmissionSession>();
            CreateMap<AdmissionSession, AdmissionSessionDto>();

            CreateMap<AdmissionSessionRequestDto, AdmissionSessionRequest>();
            CreateMap<AdmissionSessionRequest, AdmissionSessionRequestDto>();
        }
    }
}
