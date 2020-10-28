using BusinessLayer.Model;
using System;

namespace WalletOneTest.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateLastEdit { get; set; }
        public UserStatus Status { get; set; }
    }
}
