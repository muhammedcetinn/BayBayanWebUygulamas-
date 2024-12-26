using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstracts;

namespace BayBayanWebUygulamasi.Areas.Admin.ViewComponents.Coiffeurs
{
    public class CoiffeurShiftArea : ViewComponent
    {
        private readonly ICoiffeurService _coiffeurService;

        public CoiffeurShiftArea(ICoiffeurService coiffeurService)
        {
            _coiffeurService = coiffeurService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int coiffeurId)
        {
            var coiffeurShiftModel = await _coiffeurService.GetCoiffeurShiftAsync(coiffeurId);
            return View(coiffeurShiftModel);
        }
    }
}
