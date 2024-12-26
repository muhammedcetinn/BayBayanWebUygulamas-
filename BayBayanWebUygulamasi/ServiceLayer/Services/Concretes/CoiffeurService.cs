using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.Entities;
using EntityLayer.ViewModels.Coiffeur;
using EntityLayer.ViewModels.CoiffeurService;
using EntityLayer.ViewModels.CoiffeurShift;
using Microsoft.AspNetCore.Http;
using ServiceLayer.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Concretes
{
    public class CoiffeurService : ICoiffeurService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CoiffeurService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<int> CreateCoiffeurAsync(AddCoiffeurViewModel addModel)
        {
            var map = mapper.Map<Coiffeur>(addModel);
            await unitOfWork.GetRepository<Coiffeur>().AddAsync(map);
            await unitOfWork.SaveAsync();
            return map.Id;
        }

        public async Task<List<GetCoiffeurViewModel>> GetAllCoiffeurAsync()
        {
            var coiffeurs = await unitOfWork.GetRepository<Coiffeur>().GetAllAsync();
            var map = mapper.Map<List<GetCoiffeurViewModel>>(coiffeurs);
            return map;
        }

        public async Task<GetCoiffeurViewModel> GetCoiffeurAsync(int id)
        {
            var coiffeur = await unitOfWork.GetRepository<Coiffeur>().GetAsync(x=>x.Id==id);
            var map = mapper.Map<GetCoiffeurViewModel>(coiffeur);
            return map;
        }

        public async Task UpdateCoiffeurAsync(GetCoiffeurViewModel updateModel)
        {
            var coiffeur = await unitOfWork.GetRepository<Coiffeur>().GetAsync(x=>x.Id==updateModel.Id);
            mapper.Map(updateModel,coiffeur);
            await unitOfWork.GetRepository<Coiffeur>().UpdateAsync(coiffeur);
            await unitOfWork.SaveAsync();   
        }

        public async Task UpdateCoiffeurShiftAsync(GetCoiffeurShiftViewModel updateModel)
        {
            var coiffeurShift = await unitOfWork.GetRepository<CoiffeurShift>().GetAsync(x=>x.Id==updateModel.Id);
            mapper.Map(updateModel,coiffeurShift);
            await unitOfWork.GetRepository<CoiffeurShift>().UpdateAsync(coiffeurShift);
            await unitOfWork.SaveAsync();
        }

        public async Task<GetCoiffeurShiftViewModel> GetCoiffeurShiftAsync(int coiffeurId)
        {
            var coiffeurShift = await unitOfWork.GetRepository<CoiffeurShift>().GetAsync(x => x.CoiffeurId == coiffeurId);
            var map = mapper.Map<GetCoiffeurShiftViewModel>(coiffeurShift);
            return map;
        }

        public async Task<int> CreateCoiffeurServiceAsync(AddCoiffeurServiceViewModel addModel) 
        {
            var map = mapper.Map<EntityLayer.Entities.CoiffeurService>(addModel);
            await unitOfWork.GetRepository<EntityLayer.Entities.CoiffeurService>().AddAsync(map);
            await unitOfWork.SaveAsync();
            return map.Id;
        }

        public async Task UpdateCoiffeurServiceAsync(GetCoiffeurServiceViewModel updateModel)
        {
            var coiffeurService = await unitOfWork.GetRepository<EntityLayer.Entities.CoiffeurService>().GetAsync(x => x.Id == updateModel.Id);
            mapper.Map(updateModel, coiffeurService);
            await unitOfWork.GetRepository<EntityLayer.Entities.CoiffeurService>().UpdateAsync(coiffeurService);
            await unitOfWork.SaveAsync();
        }

        public async Task<GetCoiffeurServiceViewModel> GetCoiffeurServiceAsync(int id)
        {
            var coiffeurService = await unitOfWork.GetRepository<EntityLayer.Entities.CoiffeurService>().GetAsync(x => x.Id == id);
            var map = mapper.Map<GetCoiffeurServiceViewModel>(coiffeurService);
            return map;
        }

        public async Task<List<GetCoiffeurServiceViewModel>> GetAllCoiffeurServiceAsync(int coiffeurId)
        {
            var coiffeurServices = await unitOfWork.GetRepository<EntityLayer.Entities.CoiffeurService>().GetAllAsync(x=>x.CoiffeurId==coiffeurId);
            var map = mapper.Map<List<GetCoiffeurServiceViewModel>>(coiffeurServices);
            return map;
        }

    }
}
