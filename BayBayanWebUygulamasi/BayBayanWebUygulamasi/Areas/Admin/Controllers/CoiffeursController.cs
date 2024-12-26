using EntityLayer.ViewModels.Coiffeur;
using EntityLayer.ViewModels.CoiffeurShift;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstracts;

namespace BayBayanWebUygulamasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoiffeursController : Controller
    {
        private readonly ICoiffeurService _coiffeurService;

        public CoiffeursController(ICoiffeurService coiffeurService)
        {
            _coiffeurService = coiffeurService;
        }

        public async Task<IActionResult> Index()
        {
            var coiffeursModel = await _coiffeurService.GetAllCoiffeurAsync();
            return View(coiffeursModel);
        }
        [HttpGet]
        public async Task<IActionResult> Profile(int id)
        {
            var coiffeurModel = await _coiffeurService.GetCoiffeurAsync(id);
            return View(coiffeurModel);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(GetCoiffeurViewModel updateModel)
        {
            if(!ModelState.IsValid) return View(updateModel);
            await _coiffeurService.UpdateCoiffeurAsync(updateModel);
            return RedirectToAction("Index", "Coiffeurs", new {area="Admin"});
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCoiffeurShift(GetCoiffeurShiftViewModel updateModel)
        {
            if (!ModelState.IsValid) TempData["CoiffeurShift"] = "Mesai saatleri güncellenemedi. Tüm alanları doldurduğunuzdan emin olun!";
            if (ModelState.IsValid)
            {
                await _coiffeurService.UpdateCoiffeurShiftAsync(updateModel);
                TempData["CoiffeurShift"] = "Mesai saatleri başarıyla güncellendi.";
            }
            return RedirectToAction("Profile", "Coiffeurs", new { area = "Admin" ,id =updateModel.CoiffeurId});
        }
    }
}
