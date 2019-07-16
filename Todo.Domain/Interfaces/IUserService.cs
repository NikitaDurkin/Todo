using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Domain.Models.User;

namespace Todo.Domain.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Получение всех пользователей
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserModel>> GetAll();

        /// <summary>
        /// Получение одного пользователя
        /// </summary>
        /// <param name="id">Уникальный идентификатор пользователя</param>
        /// <returns></returns>
        Task<UserModel> Get(string id);

        /// <summary>
        /// Добавление пользователя 
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        Task<string> Create(UserModel userModel);

        /// <summary>
        /// Изменение пользователя
        /// </summary>
        /// <param name="userModel">Модель пользователя</param>
        /// <returns></returns>
        Task<string> Update(UserModel userModel);

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="id">Уникальный идентификатор</param>
        /// <returns></returns>
        Task Delete(string id);
    }
}