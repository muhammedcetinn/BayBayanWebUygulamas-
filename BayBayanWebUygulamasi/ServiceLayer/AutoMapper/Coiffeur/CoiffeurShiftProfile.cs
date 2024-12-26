using AutoMapper;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.ViewModels.CoiffeurShift;

namespace ServiceLayer.AutoMapper.Coiffeur
{
    public class CoiffeurShiftProfile : Profile
    {
        public CoiffeurShiftProfile()
        {
            CreateMap<GetCoiffeurShiftViewModel, EntityLayer.Entities.CoiffeurShift>().ReverseMap();
        }
    }
}
