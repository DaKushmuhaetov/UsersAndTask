using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer.Model
{
    [Table("Users")]
    public class User
    {
        public int Id { get; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public DateTime DateCreate { get; }
        public DateTime DateLastEdit { get; private set; }
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

        public void EditUser(string firstName, string middleName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            DateLastEdit = DateTime.Now;
        }
    }
}
