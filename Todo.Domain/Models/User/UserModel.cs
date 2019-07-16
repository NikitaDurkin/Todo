namespace Todo.Domain.Models.User
{
    public class UserModel
    {
//        public UserModel()
//        {
//        }
//
//        public UserModel(string id, string userName, string email, string phoneNumber, int year)
//        {
//            Id = id;
//            UserName = userName;
//            Email = email;
//            PhoneNumber = phoneNumber;
//            Year = year;
//        }

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