using System;
using Xunit;
using ToDoIt.Data;

namespace ToDoIt.Test
{
    public class PersonSequencerTests
    {
        [Fact]
        void Reset() {
            PersonSequencer.Reset();
            Assert.Equal(1, PersonSequencer.IncrementId());
        } 
    }
}
