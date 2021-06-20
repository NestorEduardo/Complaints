using Complaints.Core.Models;
using Complaints.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Complaints.Web.Controllers
{
    public class ClaimTypeController : Controller
    {
        private readonly IClaimTypeService claimTypeService;
        public ClaimTypeController(IClaimTypeService claimTypeService) => this.claimTypeService = claimTypeService;
        public async Task<IActionResult> List() => View(await claimTypeService.GetAll());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ClaimType claimType)
        {
            if (ModelState.IsValid)
            {
                await claimTypeService.Create(claimType);
                return RedirectToAction("List");
            }

            return View(claimType);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ClaimType claimType = await claimTypeService.GetById(id);

            if (claimType == null)
            {
                return NotFound();
            }

            return View(claimType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ClaimType claimType)
        {
            if (ModelState.IsValid)
            {
                await claimTypeService.Update(claimType, claimType.Id);
                return RedirectToAction("List");
            }

            return View(claimType);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ClaimType claimType = await claimTypeService.GetById(id);

            if (claimType == null)
            {
                return NotFound();
            }

            return View(claimType);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            ClaimType claimType = await claimTypeService.GetById(id);

            if (claimType == null)
            {
                return NotFound();
            }

            return View(claimType);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ClaimType claimType)
        {
            await claimTypeService.Delete(claimType.Id);
            return RedirectToAction("List");
        }
    }
}
