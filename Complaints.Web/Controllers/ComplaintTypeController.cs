using Complaints.Core.Models;
using Complaints.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Complaints.Web.Controllers
{
    public class ComplaintTypeController : Controller
    {
        private readonly IComplaintTypeService complaintTypeService;
        public ComplaintTypeController(IComplaintTypeService complaintTypeService) => this.complaintTypeService = complaintTypeService;
        public async Task<IActionResult> List() => View(await complaintTypeService.GetAll());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ComplaintType complaintType)
        {
            if (ModelState.IsValid)
            {
                await complaintTypeService.Create(complaintType);
                return RedirectToAction("List");
            }

            return View(complaintType);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ComplaintType complaintType = await complaintTypeService.GetById(id);

            if (complaintType == null)
            {
                return NotFound();
            }

            return View(complaintType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ComplaintType complaintType)
        {
            if (ModelState.IsValid)
            {
                await complaintTypeService.Update(complaintType, complaintType.Id);
                return RedirectToAction("List");
            }

            return View(complaintType);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ComplaintType complaintType = await complaintTypeService.GetById(id);

            if (complaintType == null)
            {
                return NotFound();
            }

            return View(complaintType);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            ComplaintType complaintType = await complaintTypeService.GetById(id);

            if (complaintType == null)
            {
                return NotFound();
            }

            return View(complaintType);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ComplaintType complaintType)
        {
            await complaintTypeService.Delete(complaintType.Id);
            return RedirectToAction("List");
        }
    }
}
