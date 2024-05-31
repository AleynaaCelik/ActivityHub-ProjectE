using ActivityHub.Application.DTOs;
using ActivityHub.Application.Interfaces;
using ActivityHub.Presantaion.Models;
using Microsoft.AspNetCore.Mvc;
//using OpenAI_API;  // OpenAI API kütüphanesini ekleyin
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            return View(new CreateActivityViewModel());
        }
        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }
        //// POST: /Activity/GetRecommendations
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> GetRecommendations(CreateActivityViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // OpenAI API çağrısı için gerekli kodlar
        //        var apiKey = "YOUR_OPENAI_API_KEY";  // OpenAI API anahtarınızı burada belirtin
        //        var openai = new OpenAIAPI(apiKey);

        //        // Kullanıcı tercihlerini OpenAI'ye uygun bir şekilde formatlayın
        //        var prompt = $"User prefers {model.OutdoorOrIndoor} activities, is interested in {string.Join(", ", model.Interests)}, and prefers {model.CrowdPreference} places. Suggest suitable activities.";

        //        var completionRequest = new OpenAI_API.Completions.CompletionRequest()
        //        {
        //            Prompt = prompt,
        //            Model = "text-davinci-003",
        //            MaxTokens = 150
        //        };

        //        var completionResult = await openai.Completions.CreateCompletionAsync(completionRequest);

        //        var recommendations = new List<string>();
        //        if (completionResult.Completions != null && completionResult.Completions.Count > 0)
        //        {
        //            recommendations.Add(completionResult.Completions[0].Text.Trim());
        //        }

        //        return View("Recommendations", recommendations);
        //    }

        //    return View("Index", model);
        //}

        // Diğer işlemler için gerekli action metotlarını da ekleyebilirsiniz.
    }
}
