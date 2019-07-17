using System;
using Microsoft.AspNetCore.Identity;

namespace Todo.Database.Models
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User : IdentityUser
    {
        public int Year { get; set; }

        /// <summary>
        /// Пустой конструктор пользователя
        /// </summary>
        public User()
        {
        }
    }
}