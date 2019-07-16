using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Todo.Database.Models;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Register;

namespace Todo.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IRegisterService _registerService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IRegisterService registerService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _registerService = registerService;
        }
        
        [HttpPost]
        public async Task<string> Register(RegisterFullModel registerFullModel)
        {
            return await _registerService.Register(registerFullModel);
        }
    }
}