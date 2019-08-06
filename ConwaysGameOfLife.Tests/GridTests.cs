using System;
using Xunit;

namespace ConwaysGameOfLife.Tests
{
    public class GridTests
    {
        [Fact]
        public void GivenNewGame_WhenCallsGridOf1By1_ReturnsArrayOfSingleBoolean ()
        {
            Game game = new Game();

            var actual = game.Grid(1,1);

            var expected = new bool[1 , 1] { { false } };

            Assert.Equal( expected, actual );
        }
    }
}
