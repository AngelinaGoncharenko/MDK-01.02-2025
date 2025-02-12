using System.Collections.Generic;
using System;
using System.Linq;

namespace Project
{
    public class TaskManager
    {
        private readonly List<Task> tasks = [];

        public void AddTask(string description)
        {
            tasks.Add(new Task { Id = Guid.NewGuid(), Description = description, Status = "не начато" });
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        public bool UpdateTaskStatus(Guid id, string newStatus)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return false;
            }

            task.Status = newStatus;
            return true;
        }

        public bool RemoveTask(Guid id)
        {
            int initialCount = tasks.Count;
            tasks.RemoveAll(t => t.Id == id);

            return tasks.Count < initialCount;
        }
    }

    public class Task
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
    }
}
