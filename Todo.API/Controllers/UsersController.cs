using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.User;

namespace Todo.Controllers
{
    /// <summary>
    /// Контроллер пользователей
    /// </summary>
    [Route("api/user")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        /// <summary/>
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Получение всех пользователей
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<UserModel>> GetAll()
        {
            return await _userService.GetAll();
        }

        /// <summary>
        /// Получение одного пользователя
        /// </summary>
        /// <param name="id">id задачи</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<UserModel> Get([FromRoute] string id)
        {
            return await _userService.Get(id);
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="userModel">Модель пользователя</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Create([FromBody] UserModel userModel)
        {
            return await _userService.Create(userModel);
        }

        /// <summary>
        /// Изменение пользователя
        /// </summary>
        /// <param name="userModel">Модель пользователь</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<string> Update([FromBody] UserModel userModel)
        {
            return await _userService.Update(userModel);
        }

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="id">Уникальный идентификатор пользователя</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] string id)
        {
            await _userService.Delete(id);
        }
    }
}