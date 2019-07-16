using System;

namespace Todo.Domain.Models.Item
{
    /// <summary>
    /// Класс задачи
    /// </summary>
    public class ItemModel
    {
        public Guid Guid { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Выполнено (true/false)
        /// </summary>
        public bool IsComplete { get; set; }
    }
}