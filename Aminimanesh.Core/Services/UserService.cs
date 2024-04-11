using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aminimanesh.Core.Security;
using Aminimanesh.Core.Services.Interfaces;
using Aminimanesh.DataLayer.Context;
using Aminimanesh.DataLayer.Entities.User;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Aminimanesh.Core.Services
{
    public class UserService : IUserService
    {
        private readonly AminimaneshContext _context;
        private readonly IMapper _mapper;
        public UserService(AminimaneshContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<User> CheckUserCredentialsAsync(string userName, string password)
        {
            var user = await _context.User.SingleOrDefaultAsync();

            if (user != null && PasswordHelper.VerifyPasswordBcrypt(password, user.Pasword))
            {
                return user;
            }

            return null;
        }
    }
}
