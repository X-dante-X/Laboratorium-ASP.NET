using Laboratorium_3.Models.ReservationModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    [Authorize(Roles = "admin")]

    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [AllowAnonymous]

        public async Task<IActionResult> Index()
        {
            return View(await _reservationService.FindAllAsync());
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> PagedIndex(int page = 1, int size = 5)
        {
            if (size < 1)
            {
                return BadRequest();
            }
            return View(await _reservationService.FindPageAsync(page, size));
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation model)
        {
            if (ModelState.IsValid)
            {
                await _reservationService.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(await _reservationService.FindByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Reservation model)
        {
            if (ModelState.IsValid)
            {
                await _reservationService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _reservationService.FindByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Reservation model)
        {
            await _reservationService.DeleteByIdAsync(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _reservationService.FindByIdAsync(id));
        }
    }
}
