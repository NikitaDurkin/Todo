namespace Todo.Domain.Models.Register
{
    public class RegisterInfoModel
    {
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
        /// Возраст
        /// </summary>
        public int Year { get; set; }
    }
}