using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Database.Models
{
    /// <summary>
    /// Класс задачи 
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Key]
        public Guid Guid { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Выполнено
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Коснтруктор для добавления задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <param name="name">Имя</param>
        /// <param name="isComplete">Выполнено</param>
        public Item(string name, bool isComplete)
        {
            Guid = Guid.NewGuid();
            Name = name;
            IsComplete = isComplete;
        }

        /// <summary>
        /// Конструктор для редактирования задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <param name="name">Имя</param>
        /// <param name="isComplete">Выполнено</param>
        public Item(Guid guid, string name, bool isComplete)
        {
            Guid = guid;
            Name = name;
            IsComplete = isComplete;
        }
    }
}