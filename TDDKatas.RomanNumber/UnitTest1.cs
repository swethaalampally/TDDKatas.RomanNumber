using System;
using System.Collections.Generic;
using Xunit;

namespace TDDKatas.RomanNumber
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        public void Test1(int number)
        {
            var actual = RomanConvertor.Convert(number);
            Assert.Equal("I",actual);
        }
    }

    public class RomanConvertor
    {
        public static string Convert(int number)
        {
            throw new NotImplementedException();
        }
    }
}
