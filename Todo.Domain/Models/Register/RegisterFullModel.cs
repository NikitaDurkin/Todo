namespace Todo.Domain.Models.Register
{
    public class RegisterFullModel : RegisterInfoModel
    {
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        public string Id { get; set; }
    }
}