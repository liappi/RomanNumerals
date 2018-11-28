using System;
using RomanNumerals;
using Xunit;

namespace RomanNumeralTests {
    public class UnitTest1 {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(9, "IX")]
        public void GivenSingleDigitIntegerReturnsCorrespondingRomanNumeral(int number, string expected) {
            var romanNumeralConvertor = new RomanNumeralConvertor();
            var actual = romanNumeralConvertor.ConvertNumberToRomanNumeral(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, "X")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(51, "LI")]
        [InlineData(54, "LIV")]
        [InlineData(59, "LIX")]
        [InlineData(60, "LX")]
        [InlineData(90, "XC")]
        public void GivenDoubleDigitIntegerReturnsCorrespondingRomanNumeral(int number, string expected) {
            var romanNumeralConvertor = new RomanNumeralConvertor();
            var actual = romanNumeralConvertor.ConvertNumberToRomanNumeral(number);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(100, "C")]
        [InlineData(200, "CC")]
        [InlineData(300, "CCC")]
        [InlineData(400, "CD")]
        [InlineData(410, "CDX")]
        [InlineData(430, "CDXXX")]
        [InlineData(439, "CDXXXIX")]
        [InlineData(438, "CDXXXVIII")]
        [InlineData(910, "CMX")]
        public void GivenTripleDigitIntegerReturnsCorrespondingRomanNumeral(int number, string expected) {
            var romanNumeralConvertor = new RomanNumeralConvertor();
            var actual = romanNumeralConvertor.ConvertNumberToRomanNumeral(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VII", 7)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("X", 10)]
        [InlineData("XX", 20)]
        [InlineData("XXX", 30)]
        [InlineData("XL", 40)]
        [InlineData("L", 50)]
        [InlineData("LI", 51)]
        [InlineData("LIV", 54)]
        [InlineData("LIX", 59)]
        [InlineData("LX", 60)]
        [InlineData("XC", 90)]
        public void GivenRomanNumeralReturnCorrespondingInteger(string romanNumeral, int expected) {
            var romanNumeralConvertor = new RomanNumeralConvertor();
            var actual = romanNumeralConvertor.ConvertRomanNumeralToNumber(romanNumeral);
            Assert.Equal(expected, actual);
        }
    }
}