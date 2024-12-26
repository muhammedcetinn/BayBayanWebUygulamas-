using AutoMapper;
using EntityLayer.ViewModels.Coiffeur;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper.Coiffeur
{
    public class CoiffeurProfile : Profile
    {
        public CoiffeurProfile()
        {
            CreateMap<AddCoiffeurViewModel, EntityLayer.Entities.Coiffeur>().ReverseMap();
            CreateMap<GetCoiffeurViewModel, EntityLayer.Entities.Coiffeur>().ReverseMap();
        }
    }
}
