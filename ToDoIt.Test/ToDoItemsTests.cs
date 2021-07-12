using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;

namespace ToDoIt.Test
{
    public class ToDoItemsTests
    {
        [Fact]
        public void AddToDoItemTest()
        {
            string description = "A test item";
            Data.ToDoItems testToDoItems = new Data.ToDoItems();

            testToDoItems.AddToDoItem(description);

            Assert.NotEmpty(testToDoItems.FindAll());
        }
        [Fact]
        public void SizeTest()
        {
            string description = "A test item";
            int size = 1;
            Data.ToDoItems testToDoItems = new Data.ToDoItems();

            testToDoItems.AddToDoItem(description);

            Assert.Equal(size, testToDoItems.Size());
        }

        [Fact]
        public void FindAllTest()
        {
            string description = "A test item";
            Data.ToDoItems testToDoItems = new Data.ToDoItems();

            testToDoItems.AddToDoItem(description);

            Assert.Equal(description, testToDoItems.FindAll()[0].GetDescription());
        }
        [Fact]
        public void FindByIdTest()
        {
            string description = "A test item";
            int id = 1;
            Data.ToDoItems testToDoItems = new Data.ToDoItems();

            testToDoItems.AddToDoItem(description);

            Assert.Equal(description, testToDoItems.FindById(id).GetDescription());
        }
        [Fact]
        public void FindByDoneStatusTest()
        {
            string description = "A test item";
            int id = 1;
            bool done = false;
            Data.ToDoItems testToDoItems = new Data.ToDoItems();

            testToDoItems.AddToDoItem(description);

            Assert.Equal(description, testToDoItems.FindByDoneStatus(done)[0].GetDescription());
        }
        [Fact]
        public void RemoveTodoTest()
        {
            string description = "A test item";
            Data.ToDoItems testTodoItems = new Data.ToDoItems();

            testTodoItems.AddToDoItem(description);
            testTodoItems.RemoveTodo(1);

            Assert.Empty(testTodoItems.FindAll());
        }
    }
}
