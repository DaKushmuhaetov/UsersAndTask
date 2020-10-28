using BusinessLayer.Model;
using System.Collections.Generic;

namespace WalletOneTest.ViewModels
{
    public sealed class TasksView
    {
        public User User { get; set; }
        public List<TaskUser> Tasks { get; set; }
    }
}
