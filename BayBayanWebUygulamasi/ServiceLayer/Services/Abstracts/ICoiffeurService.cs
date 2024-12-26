using EntityLayer.ViewModels.Coiffeur;
using EntityLayer.ViewModels.CoiffeurService;
using EntityLayer.ViewModels.CoiffeurShift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstracts
{
    public interface ICoiffeurService
    {
        Task<int> CreateCoiffeurAsync(AddCoiffeurViewModel addModel);
        Task UpdateCoiffeurAsync(GetCoiffeurViewModel updateModel);
        Task<GetCoiffeurViewModel> GetCoiffeurAsync(int id);
        Task<List<GetCoiffeurViewModel>> GetAllCoiffeurAsync();

        Task UpdateCoiffeurShiftAsync(GetCoiffeurShiftViewModel updateModel);
        Task<GetCoiffeurShiftViewModel> GetCoiffeurShiftAsync(int coiffeurId);

        Task<int> CreateCoiffeurServiceAsync(AddCoiffeurServiceViewModel addModel);
        Task UpdateCoiffeurServiceAsync(GetCoiffeurServiceViewModel updateModel);
        Task<GetCoiffeurServiceViewModel> GetCoiffeurServiceAsync(int id);
        Task<List<GetCoiffeurServiceViewModel>> GetAllCoiffeurServiceAsync(int coiffeurId);
    }
}
