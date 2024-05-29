using ActivityHub.Application.DTOs;
using ActivityHub.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ActivityHub.Presantaion.Models;

namespace ActivityHub.Presantaion.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // GET: /Activity
        public async Task<IActionResult> Index()
        {
            IEnumerable<ActivityDto> activities = await _activityService.GetAllActivitiesAsync();
            return View(activities);
        }

        // GET: /Activity/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            ActivityDto activity = await _activityService.GetActivityByIdAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            return View(activity);
        }

        // GET: /Activity/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Activity/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateActivityViewModel createActivityViewModel)
        {
            if (ModelState.IsValid)
            {
                var createActivityDto = new CreateActivityDto
                {
                    Name = createActivityViewModel.Name,
                    Type = createActivityViewModel.Type,
                    Date = createActivityViewModel.Date,
                    Description = createActivityViewModel.Description,
                    UserId = createActivityViewModel.UserId
                };

                await _activityService.AddActivityAsync(createActivityDto);
                return RedirectToAction(nameof(Index));
            }
            return View(createActivityViewModel);
        }

        // Diğer işlemler için gerekli action metotlarını da ekleyebilirsiniz.
    }
}
