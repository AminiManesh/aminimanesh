using Aminimanesh.Core.DTOs.ProjectDTOs;
using Aminimanesh.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;

namespace Aminimanesh.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("create-project")]
        public async Task<IActionResult> CreateProject()
        {
            var categories = (await _projectService.GetAllCategoriesAsync()).Select(c => new SelectListItem { Value = c.CategoryId.ToString(), Text = c.Title });
            var list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = "Select category..." }
            };
            list.AddRange(categories);
            ViewData["Categories"] = new SelectList(list, "Value", "Text", 0);

            return View();
        }

        [HttpPost]
        [Route("create-project")]
        public async Task<IActionResult> CreateProject(CreateProjectDTO project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }

            await _projectService.AddProjectAsync(project);

            return RedirectToAction("Index");
        }
    }
}
