using AutoMapper;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.ViewModels.CoiffeurService;

namespace ServiceLayer.AutoMapper.Coiffeur
{
    public class CoiffeurServiceProfile : Profile
    {
        public CoiffeurServiceProfile()
        {
            CreateMap<AddCoiffeurServiceViewModel, EntityLayer.Entities.CoiffeurService>().ReverseMap();
            CreateMap<GetCoiffeurServiceViewModel, EntityLayer.Entities.CoiffeurService>().ReverseMap();
        }
    }
}
