using BusinessLayer.Model;
using System;

namespace WalletOneTest.ViewModels
{
    public class TaskView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateLastEdit { get; set; }
        public TaskStatus Status { get; set; }
        public int DirectorId { get; set; }
        public int PerformerId { get; set; }
    }
}
