using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Register;


namespace Todo.Controllers
{
    /// <summary>
    /// Контроллер регистрации
    /// </summary>
    [Route("api/account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IRegisterService _registerService;

        public AccountController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        /// <summary>
        /// Регистрация пользователей
        /// </summary>
        /// <param name="registerFullModel">Полная модель регистрации</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Register(RegisterFullModel registerFullModel)
        {
            return await _registerService.Register(registerFullModel);
        }
    }
}