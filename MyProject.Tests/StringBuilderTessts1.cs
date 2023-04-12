using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Exercise;
using FluentAssertions;

namespace MyProject.Tests
{
    public class StringBuilderTessts1
    {
        [Theory]
        [InlineData("Ala ma kota", "kota ma Ala")]
        [InlineData("Kot Kasi", "Kasi Kot")]
        [InlineData("Samolot lata", "lata Samolot")]
        public void ReverseWords_ForTwoGivenStrings_ReturnsAppendedString(string napis, string excepted)
        {   
            //act
            napis = StringHelper.ReverseWords(napis);
            //assert
            //Assert.Equal(napis, result);
            napis.Should().Be(excepted);
        }
        [Fact]
        public void IsPalindrome_ForAWord_REturnsBoolValue()
        {
            //arange
            var napis = "kajak";

            //act
            var result = StringHelper.IsPalindrome(napis);

            //assert
            //Assert.True(result);
            result.Should().BeTrue();
        }

    }
}
