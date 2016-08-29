using System;
using Xunit;
using HelloWorld;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public async void Test1()
        {
            var msg = await User.GetShit();
            Assert.True(msg.Length > 0);
        }
    }
}
