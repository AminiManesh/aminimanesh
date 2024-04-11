using Aminimanesh.Core.DTOs.HistoryDTOs;
using Aminimanesh.Core.DTOs.LanguageDTOs;
using Aminimanesh.Core.DTOs.OwnerDTOs;
using Aminimanesh.Core.DTOs.SkillDTOs;
using Aminimanesh.Core.DTOs.SocialDTOs;
using Aminimanesh.Core.Services.Interfaces;
using Aminimanesh.DataLayer.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly AminimaneshContext _context;
        private readonly IMapper _mapper;
        public OwnerService(AminimaneshContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<HistoryLineListItemDTO>> GetAllHistoryLinesAsync()
        {
            var lines = await _context.HistoryLines.Include(hl => hl.Histories).ToListAsync();
            return _mapper.Map<List<HistoryLineListItemDTO>>(lines);
        }

        public async Task<List<LanguageListItemDTO>> GetAllLanguagesAsync()
        {
            var languages = await _context.Languages.ToListAsync();
            return _mapper.Map<List<LanguageListItemDTO>>(languages);
        }

        public async Task<List<SkillListItemDTO>> GetAllMainSkillsAsync()
        {
            var skills = await _context.Skills.Where(s => !s.IsSideSkill).ToListAsync();
            return _mapper.Map<List<SkillListItemDTO>>(skills);
        }

        public async Task<List<SkillListItemDTO>> GetAllSideSkillsAsync()
        {
            var skills = await _context.Skills.Where(s => s.IsSideSkill).ToListAsync();
            return _mapper.Map<List<SkillListItemDTO>>(skills);
        }

        public async Task<List<SocialListItemDTO>> GetAllSocialsAsync()
        {
            var socials = await _context.Socials.ToListAsync();
            return _mapper.Map<List<SocialListItemDTO>>(socials);
        }

        public async Task<CommonInfoDTO> GetCommonInfoAsync()
        {
            var info = await _context.Owner.FirstOrDefaultAsync();
            return _mapper.Map<CommonInfoDTO>(info);
        }

        public async Task<ContactInfoDTO> GetContactInfoAsync()
        {
            var owner = (await _context.Owner.FirstOrDefaultAsync());
            return _mapper.Map<ContactInfoDTO>(owner);
        }

        public async Task<ExperienceInfoDTO> GetExperienceInfoAsync()
        {
            var owner = await _context.Owner.FirstOrDefaultAsync();
            return _mapper.Map<ExperienceInfoDTO>(owner);
        }

        public async Task<string> GetIncomeEmailAsync()
        {
            var res = (await _context.Owner.FirstOrDefaultAsync()).IncomeEmail;
            return res;
        }

        public async Task<ProfileInfoDTO> GetProfileInfoAsync()
        {
            var owner = await _context.Owner.FirstOrDefaultAsync();
            return _mapper.Map<ProfileInfoDTO>(owner);
        }
    }
}
