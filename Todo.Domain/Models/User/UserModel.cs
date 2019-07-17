namespace Todo.Domain.Models.User
{
    public class UserModel
    {
        /// <summary>
        /// Унильный идентификатор пользователя
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }
    }
}