using CalculatorLib;
using Xunit;
using System;

namespace MyTestProject
{
    public class UnitTest1
    {
        ICalculatorLib ICal = new ICalculatorLib();
        [Fact]
          
            public void Test_Addition()
            {
                var a = 10;
                var b = 20;
                var result = ICal.Add(a, b);
                Assert.Equal(30, result);
            }
        [Fact]
        public void Test_Substraction()
        {
            var a = 100;
            var b = 50;
            var result = ICal.Sub(a, b);
            Assert.Equal(50, result);
        }
        [Fact]
        public void Test_Multiply()
        {
            var a = 10;
            var b = 10;
            var result = ICal.Multiply(a, b);
            Assert.Equal(100, result);
        }
        [Fact]
        public void Test_Divide()
        {
            var a = 20;
            var b = 4;
            var result = ICal.Divide(a, b);
            Assert.Equal(5, result);
        }
    }
        
    
}