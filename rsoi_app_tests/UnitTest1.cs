using rsoi_app;
using System;
using Xunit;


namespace rsoi_app_tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNormal()
        {
            double x = BusinesLogic.Factorial(3);
            Assert.Equal(6, x);
            return;
        }

        [Fact]
        public void TestNegative()
        {
            try
            {
                double x = BusinesLogic.Factorial(-1);
            }
            catch (Exception e)
            {
                Assert.Equal("Отрицательное число", e.Message);
            }
            return;
        }

        [Fact]
        public void TestNull()
        {
            try
            {
                double x = BusinesLogic.Factorial(null);
            }
            catch (Exception e)
            {
                Assert.Equal("Получен null", e.Message);
            }
            return;
        }
    }
}
