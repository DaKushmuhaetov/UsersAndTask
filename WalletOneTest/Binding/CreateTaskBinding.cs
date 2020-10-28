using BusinessLayer.Model;
using System;

namespace WalletOneTest.Binding
{
    public sealed class CreateTaskBinding
    {
        /// <summary>
        /// Номер задачи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }
        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public DateTime DateLastEdit { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status { get; set; }
        /// <summary>
        /// Номер исполнителя
        /// </summary>
        public int PerformerId { get; set; }
    }
}
