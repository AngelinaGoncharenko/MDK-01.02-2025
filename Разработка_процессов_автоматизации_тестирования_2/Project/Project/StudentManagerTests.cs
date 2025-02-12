using System.Collections.Generic;
using Xunit;

namespace Project
{
    [Collection("StudentManagerTestsCollection")]
    public class StudentManagerTests
    {
        private readonly StudentManager _manager = new();

        [Fact]
        public void RemoveStudent_ShouldRemoveExistingStudent()
        {
            _manager.AddStudent("Alice", [4, 5, 3]);
            Assert.True(_manager.RemoveStudent("Alice"));
        }

        [Fact]
        public void RemoveStudent_ShouldNotRemoveNonExistingStudent()
        {
            Assert.False(_manager.RemoveStudent("Bob"));
        }

        [Fact]
        public void UpdateStudent_ShouldUpdateGradesForExistingStudent()
        {
            _manager.AddStudent("Alice", [4, 5, 3]);
            Assert.True(_manager.UpdateStudent("Alice", [5, 5, 5]));
        }

        [Fact]
        public void UpdateStudent_ShouldNotUpdateNonExistingStudent()
        {
            Assert.False(_manager.UpdateStudent("Bob", [5, 5, 5]));
        }
    }
}
