using Aminimanesh.Core.DTOs.ServiceDTOs;
using Aminimanesh.Core.DTOs.SpeechDTOs;
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
    public class ServiceService : IServiceService
    {
        private readonly AminimaneshContext _context;
        private readonly IMapper _mapper;
        public ServiceService(AminimaneshContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<int> AddMessageAsync(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return message.MessageId;
        }

        public async Task<int> AddServiceAsync(CreateServiceDTO serviceDTO)
        {
            var service = _mapper.Map<Service>(serviceDTO);
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            return service.ServiceId;
        }

        public async Task<int> AddSpeechAsync(Speech speech)
        {
            await _context.Speechs.AddAsync(speech);
            await _context.SaveChangesAsync();
            return speech.SpeechId;
        }

        public async Task<List<Message>> GetAllMessages()
        {
            var messages = await _context.Messages.OrderByDescending(m => m.SendDate).ToListAsync();
            return messages;
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

        public async Task<List<Message>> GetNewMessages(int take)
        {
            var messages = await _context.Messages.OrderByDescending(m => m.SendDate).Take(take).ToListAsync();
            return messages;
        }

        public async Task<EditServiceDTO> GetServiceForEditAsync(int serviceId)
        {
            var service = await _context.Services.FindAsync(serviceId);
            return _mapper.Map<EditServiceDTO>(service);
        }

        public async Task<Speech> GetSpeechByIdAsync(int speechId)
        {
            var speech = await _context.Speechs.FindAsync(speechId);
            return speech;
        }

        public async Task RemoveServiceByIdAsync(int serviceId)
        {
            var service = await _context.Services.FindAsync(serviceId);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveSpeechbyIdAsync(int speechId)
        {
            var speech = await GetSpeechByIdAsync(speechId);
            _context.Speechs.Remove(speech);
            await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateServiceAsync(EditServiceDTO serviceDTO)
        {
            var service = _mapper.Map<Service>(serviceDTO);
            _context.Services.Update(service);
            await _context.SaveChangesAsync();
            return service.ServiceId;
        }

        public async Task<int> UpdateSpeechAsync(Speech speech)
        {
            _context.Speechs.Update(speech);
            await _context.SaveChangesAsync();
            return speech.SpeechId;
        }
    }
}
