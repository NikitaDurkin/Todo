using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Todo.Database.Models;
using Todo.Database.Resources;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Register;

namespace Todo.Domain.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegisterService(IMapper mapper, DatabaseContext context, SignInManager<User> signInManager,
            UserManager<User> userManager)
        {
            _mapper = mapper;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        /// <inheritdoc/>
        public async Task<string> Register(RegisterFullModel registerFullModel)
        {
            var userModel = _mapper.Map<User>(registerFullModel);
            var result = await _userManager.CreateAsync(userModel);
            return userModel.Id;
        }
    }
}