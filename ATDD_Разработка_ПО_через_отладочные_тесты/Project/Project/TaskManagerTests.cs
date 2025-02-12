using System.Linq;
using System;
using Xunit;

namespace Project
{
    [Collection("TaskManagerTestsCollection")]
    public class TaskManagerTests
    {
        private readonly TaskManager _manager = new();

        [Fact]
        public void UpdateTaskStatus_ShouldChangeTaskStatus()
        {
            _manager.AddTask("Первая задача");
            var taskId = _manager.GetTasks()[0].Id;

            bool result = _manager.UpdateTaskStatus(taskId, "в работе");

            Assert.True(result);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskById()
        {
            _manager.AddTask("Первая задача");
            var taskId = _manager.GetTasks()[0].Id;

            bool result = _manager.RemoveTask(taskId);

            Assert.True(result);
        }

        [Fact]
        public void RemoveTask_ShouldReturnFalseWhenTaskNotFound()
        {
            Guid nonExistentId = Guid.NewGuid();

            bool result = _manager.RemoveTask(nonExistentId);

            Assert.False(result);
        }

        [Fact]
        public void UpdateTaskStatus_ShouldReturnFalseWhenTaskNotFound()
        {
            Guid nonExistentId = Guid.NewGuid();

            bool result = _manager.UpdateTaskStatus(nonExistentId, "в работе");

            Assert.False(result);
        }

        [Fact]
        public void AddTask_ShouldAssignUniqueIdToEachTask()
        {
            _manager.AddTask("Первая задача");
            _manager.AddTask("Вторая задача");

            var tasks = _manager.GetTasks();
            Assert.NotEqual(tasks[0].Id, tasks[1].Id);
        }

        [Fact]
        public void RemoveTask_ShouldNotCrashWhenRemovingAlreadyRemovedTask()
        {
            _manager.AddTask("Первая задача");
            var taskId = _manager.GetTasks()[0].Id;
            _manager.RemoveTask(taskId);

            bool result = _manager.RemoveTask(taskId);

            Assert.False(result);
        }
    }
}
