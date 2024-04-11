using Aminimanesh.Core.DTOs.ServiceDTOs;
using Aminimanesh.Core.DTOs.SpeechDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.Services.Interfaces
{
    public interface IServiceService
    {
        Task<List<ServiceListItemDTO>> GetAllServicesAsync();
        Task<List<SpeechListItemDTO>> GetAllSpeechsAsync();
    }
}
