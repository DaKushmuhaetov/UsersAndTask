using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Model
{
    [Table("Users")]
    public class User
    {
        public int Id { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public DateTime DateCreate { get; }
        public DateTime DateLastEdit { get; }
        public UserStatus Status { get; private set; }

        private User() { }
        public User(int id, string firstName, string middleName, DateTime dateCreate, DateTime dateLastEdit, UserStatus status)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            DateCreate = dateCreate;
            DateLastEdit = dateLastEdit;
            Status = status;
        }
    }
}
