using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Domain.Models.Item;

namespace Todo.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с задачами 
    /// </summary>
    public interface IItemService
    {
        /// <summary>
        /// Получение всех задач
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ItemModel>> GetAll();

        /// <summary>
        /// Получение одной задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор задачи</param>
        /// <returns></returns>
        Task<ItemModel> Get(Guid guid);

        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="itemModel">Модель задачи</param>
        /// <returns></returns>
        Task<Guid> Create(ItemModel itemModel);

        /// <summary>
        /// Изменение задачи
        /// </summary>
        /// <param name="itemModel">Модель задачи</param>
        /// <returns></returns>
        Task<Guid> Update(ItemModel itemModel);

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор задачи</param>
        /// <returns></returns>
        Task Delete(Guid guid);
    }
}