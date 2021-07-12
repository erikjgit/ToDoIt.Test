using System;
using Xunit;
using ToDoIt.Model;

namespace ToDoIt.Test
{
    public class PersonTests
    {
        [Fact]
        public void Constructor()
        {
            string firstName = "Erik";
            string lastName = "Johannesen";
            int personId = 1;
            Person testPerson;

            testPerson = new Person(personId, firstName, lastName);

            Assert.Equal(personId, testPerson.GetId());
            Assert.Equal(firstName, testPerson.GetFirstName());
            Assert.Equal(lastName, testPerson.GetLastName());
        }
    }
}
