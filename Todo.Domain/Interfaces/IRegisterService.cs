using System.Threading.Tasks;
using Todo.Domain.Models.Register;

namespace Todo.Domain.Interfaces
{
    /// <summary>
    /// Сервис для регистрации
    /// </summary>
    public interface IRegisterService
    {
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="registerFullModel">Полная модель регистрации</param>
        /// <returns></returns>
        Task<string> Register(RegisterFullModel registerFullModel);
    }
}