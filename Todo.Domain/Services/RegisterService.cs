using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Todo.Database.Models;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Register;

namespace Todo.Domain.Services
{
    /// <inheritdoc/>
    public class RegisterService : IRegisterService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public RegisterService(IMapper mapper,
            UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        /// <inheritdoc/>
        public async Task<string> Register(RegisterFullModel registerFullModel)
        {
            var userModel = _mapper.Map<User>(registerFullModel);
            await _userManager.CreateAsync(userModel);
            return userModel.Id;
        }
    }
}