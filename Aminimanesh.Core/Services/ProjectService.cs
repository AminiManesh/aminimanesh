using Aminimanesh.Core.DTOs.CategoryDTOs;
using Aminimanesh.Core.DTOs.ProjectDTOs;
using Aminimanesh.Core.Services.Interfaces;
using Aminimanesh.DataLayer.Context;
using Aminimanesh.DataLayer.Entities.Owner;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly AminimaneshContext _context;
        private readonly IMapper _mapper;
        public ProjectService(AminimaneshContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<int> AddProjectAsync(CreateProjectDTO projectDTO)
        {
            var project = _mapper.Map<Project>(projectDTO);
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
            return project.ProjectId;
        }

        public async Task<List<CategoryListItemDTO>> GetAllCategoriesAsync()
        {
            var categories = await _context.Categories.Include(c => c.Projects).ToListAsync();
            return _mapper.Map<List<CategoryListItemDTO>>(categories);
        }

        public async Task<ProjectGeneralDTO> GetProjectByIdAsync(int projectId)
        {
            var project = await _context.Projects.Include(p => p.Category).SingleAsync(p => p.ProjectId == projectId);
            return _mapper.Map<ProjectGeneralDTO>(project);
        }

        public async Task<List<ProjectListItemDTO>> GetProjectsAsync(int categoryId)
        {
            IQueryable<Project> result = _context.Projects;

            if (categoryId > 0)
            {
                result = result.Where(p => p.CategoryId == categoryId);
            }

            return _mapper.Map<List<ProjectListItemDTO>>(await result.ToListAsync());
        }
    }
}
