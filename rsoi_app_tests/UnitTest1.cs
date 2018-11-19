using rsoi_app;
using System;
using Xunit;


namespace rsoi_app_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double x = BusinesLogic.Cube(3);
            Assert.Equal(x, 27);
            Console.Write(x.ToString());
            return;
        }
    }
}
