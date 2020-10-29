﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Model
{
    [Table("TaskUsers")]
    public class TaskUser
    {
        public int Id { get; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DateCreate { get; }
        public DateTime DateLastEdit { get; private set; }
        public TaskStatus Status { get; private set; }
        public int DirectorId { get; private set; }
        public int PerformerId { get; private set; }

        private TaskUser() { }
        public TaskUser(int id, string name, string description, DateTime dateCreate, DateTime dateLastEdit, TaskStatus status, int directorId, int performerId)
        {
            Id = id;
            Name = name;
            Description = description;
            DateCreate = dateCreate;
            DateLastEdit = dateLastEdit;
            Status = status;
            DirectorId = directorId;
            PerformerId = performerId;
        }

        public void SetStatus(TaskStatus status)
        {
            Status = status;
            DateLastEdit = DateTime.Now;
        }
        public void SetName(string name)
        {
            Name = name;
            DateLastEdit = DateTime.Now;
        }

        public void SetDesrciption(string description)
        {
            Description = description;
            DateLastEdit = DateTime.Now;
        }

        public void SetPerformer(int id)
        {
            PerformerId = id;
            DateLastEdit = DateTime.Now;
        }

        public void EditTask(string name, string description, int id)
        {
            Name = name;
            Description = description;
            PerformerId = id;
            DateLastEdit = DateTime.Now;
        }

        public void SetDirector(int id)
        {
            DirectorId = id;
            DateLastEdit = DateTime.Now;
        }
    }
}
