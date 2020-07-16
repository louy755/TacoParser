using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            var tacoParser = new TacoParser();

            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            Assert.NotNull(actual);

        }

        //TODO: Create a test ShouldParseLongitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            TacoParser sut = new TacoParser();

            var actual = sut.Parse(line);

            Assert.Equal(expected, actual.Location.Longitude);
        }

        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            TacoParser sut = new TacoParser();

            var actual = sut.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude);
        }
        // ConvertToMiles Test
        [Theory]
        [InlineData(160.934, 0.1)]
        [InlineData(804.672, 0.5)]
        [InlineData(1609.34, 1)]
        [InlineData(3218.68, 2)]
        [InlineData(4023.36, 2.5)]
        public void ShouldConvertTest(double distance, double expected)
        {
            TacoParser sut = new TacoParser();

            var actual = TacoParser.ConvertToMiles(distance);

            Assert.Equal(expected, actual);
        }
    }
}
