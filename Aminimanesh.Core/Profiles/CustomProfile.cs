using Aminimanesh.Core.DTOs.CategoryDTOs;
using Aminimanesh.Core.DTOs.HistoryDTOs;
using Aminimanesh.Core.DTOs.LanguageDTOs;
using Aminimanesh.Core.DTOs.OwnerDTOs;
using Aminimanesh.Core.DTOs.ProjectDTOs;
using Aminimanesh.Core.DTOs.ServiceDTOs;
using Aminimanesh.Core.DTOs.SkillDTOs;
using Aminimanesh.Core.DTOs.SocialDTOs;
using Aminimanesh.Core.DTOs.SpeechDTOs;
using Aminimanesh.DataLayer.Entities.Owner;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Owner, ProfileInfoDTO>();

            CreateMap<Language, LanguageListItemDTO>();

            CreateMap<Skill, SkillListItemDTO>();

            CreateMap<Owner, ContactInfoDTO>();

            CreateMap<Service, ServiceListItemDTO>();

            CreateMap<Project, ProjectListItemDTO>();

            CreateMap<Project, ProjectGeneralDTO>();

            CreateMap<CreateProjectDTO, Project>()
                .ForMember(dest => dest.Thumbnail, i => i.MapFrom(src => src.Thumbnail.FileName));

            CreateMap<Owner, ExperienceInfoDTO>();

            CreateMap<Category, CategoryListItemDTO>()
                .ForMember(dest => dest.ProjectsCount, i => i.MapFrom(src => src.Projects.Count));

            CreateMap<History, HistoryListItemDTO>();
            CreateMap<HistoryLine, HistoryLineListItemDTO>();

            CreateMap<Speech, SpeechListItemDTO>();

            CreateMap<Owner, CommonInfoDTO>();

            CreateMap<Social, SocialListItemDTO>();
        }
    }
}
