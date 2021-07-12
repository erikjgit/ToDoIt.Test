using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;

namespace ToDoIt.Test
{
    public class PeopleTests
    {
        [Fact]
        public void AddPersonTest()
        {
            string testFirstName = "Erik";
            string testLastName = "Johannesen";
            Data.People testPeople = new Data.People();

            testPeople.AddPerson(testFirstName, testLastName);

            Assert.Equal(testPeople.FindById(1).GetFirstName(), testFirstName);
            Assert.Equal(testPeople.FindById(1).GetLastName(), testLastName);
        }
        
        [Fact]
        public void RemovePersonTest()
        {
            string testFirstName = "Erik";
            string testLastName = "Johannesen";
            Data.People testPeople = new Data.People();

            testPeople.AddPerson(testFirstName, testLastName);
            testPeople.RemovePerson(1);

            Assert.Empty(testPeople.FindAll());
        }
        
    }
}
