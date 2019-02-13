using System;
using System.Collections.Generic;
using Xunit;

namespace TDDKatas.RomanNumber
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        public void Test1(int number,string expectedRomanNumber)
        {
            var actual = RomanConvertor.Convert(number);
            Assert.Equal(expectedRomanNumber, actual);
        }
    }

    public class RomanConvertor
    {
        public static string Convert(int number)
        {
            return (number==1)?"I":"II";
        }
    }
}
