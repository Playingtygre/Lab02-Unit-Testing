using System;
using Xunit;
using ConsoleApp1;
using static ;

namespace Atm_testing
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnAnumber()
        {
            Assert.Equal("1" );
        }
    }
}
