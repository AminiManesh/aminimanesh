using Aminimanesh.Core.DTOs.ServiceDTOs;
using Aminimanesh.Core.DTOs.SpeechDTOs;
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
    public class ServiceService : IServiceService
    {
        private readonly AminimaneshContext _context;
        private readonly IMapper _mapper;
        public ServiceService(AminimaneshContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<ServiceListItemDTO>> GetAllServicesAsync()
        {
            var services = await _context.Services.ToListAsync();
            return _mapper.Map<List<ServiceListItemDTO>>(services);
        }

        public async Task<List<SpeechListItemDTO>> GetAllSpeechsAsync()
        {
            var speech = await _context.Speechs.ToListAsync();
            return _mapper.Map<List<SpeechListItemDTO>>(speech);
        }
    }
}
