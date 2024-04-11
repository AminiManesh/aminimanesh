using Aminimanesh.Core.DTOs.HistoryDTOs;
using Aminimanesh.Core.DTOs.LanguageDTOs;
using Aminimanesh.Core.DTOs.OwnerDTOs;
using Aminimanesh.Core.DTOs.SkillDTOs;
using Aminimanesh.Core.DTOs.SocialDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Services.Interfaces
{
    public interface IOwnerService
    {
        Task<string> GetIncomeEmailAsync();

        Task<ProfileInfoDTO> GetProfileInfoAsync();

        Task<List<LanguageListItemDTO>> GetAllLanguagesAsync();

        Task<List<SkillListItemDTO>> GetAllMainSkillsAsync();

        Task<List<SkillListItemDTO>> GetAllSideSkillsAsync();

        Task<ContactInfoDTO> GetContactInfoAsync();

        Task<ExperienceInfoDTO> GetExperienceInfoAsync();

        Task<List<SocialListItemDTO>> GetAllSocialsAsync();

        Task<List<HistoryLineListItemDTO>> GetAllHistoryLinesAsync();

        Task<CommonInfoDTO> GetCommonInfoAsync();
    }
}
