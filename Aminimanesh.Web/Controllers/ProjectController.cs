using Aminimanesh.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aminimanesh.Web.Controllers
{
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

        [Route("Project/{id}/{name}")]
        public IActionResult Project(int id, string name)
        {
            var project = _projectService.GetProjectByIdAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        public async Task<IActionResult> GetProjects(int categoryId)
        {
            var project = await _projectService.GetProjectsAsync(categoryId);

            return PartialView(project);
        }
    }
}
