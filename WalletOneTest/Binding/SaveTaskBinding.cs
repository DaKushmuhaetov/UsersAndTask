using System;

namespace WalletOneTest.Binding
{
    public sealed class SaveTaskBinding
    {
        /// <summary>
        /// Имя задачи
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Номер исполнителя
        /// </summary>
        public int PerformerId { get; set; }
    }
}
