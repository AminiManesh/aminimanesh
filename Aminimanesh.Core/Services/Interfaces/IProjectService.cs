using Aminimanesh.Core.DTOs.CategoryDTOs;
using Aminimanesh.Core.DTOs.ProjectDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Services.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectGeneralDTO> GetProjectByIdAsync(int projectId);
        Task<List<ProjectListItemDTO>> GetProjectsAsync(int categoryId);

        Task<List<CategoryListItemDTO>> GetAllCategoriesAsync();

        Task<int> AddProjectAsync(CreateProjectDTO projectDTO);
    }
}
