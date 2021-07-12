using System;
using Xunit;
using ToDoIt.Model;

namespace ToDoIt.Test
{
    public class TodoTests
    {
        [Fact]
        public void Constructor()
        {
            string description = "Test the Todo class";
            int todoId = 1;
            Todo testTodo;

            testTodo = new Todo(todoId, description);

            Assert.NotNull(testTodo);
        }
    }
}
