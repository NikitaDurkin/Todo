using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Interfaces;
using Todo.Domain.Models.Item;

namespace Todo.Controllers
{
    /// <summary>
    /// Контроллер для получения информации о задачах
    /// </summary>
    [Route("api/todo")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly IItemService _itemService;

        /// <summary/>
        public TodoController(IItemService itemService)
        {
            _itemService = itemService;
        }

        /// <summary>
        /// Получение всех задач
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<ItemModel>> GetAll()
        {
            return await _itemService.GetAll();
        }

        /// <summary>
        /// Получение одной задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор задачи</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        public async Task<ItemModel> Get([FromRoute] Guid guid)
        {
            return await _itemService.Get(guid);
        }

        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="itemModel">Модель задачи</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create([FromForm] ItemModel itemModel)
        {
            return await _itemService.Create(itemModel);
        }

        /// <summary>
        /// Изменение задачи
        /// </summary>
        /// <param name="itemModel">Модель задачи</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> Update([FromForm] ItemModel itemModel)
        {
            return await _itemService.Update(itemModel);
        }

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task Delete(Guid guid)
        {
            await _itemService.Delete(guid);
        }
    }
}