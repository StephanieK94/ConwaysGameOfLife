using System;
using Xunit;

namespace ConwaysGameOfLife.Tests
{
    public class GridTests
    {
        [Fact]
        public void GivenWidthAndHeightOf3By3_WhenGridSet_ReturnsArrayOf3By3Boolean ()
        {
            int width = 3;
            int height = 3;

            Game game = new Game( width , height );

            var expected = new bool[3 , 3]
            {
                { false , false , false },
                { false , false , false },
                { false , false , false }
            };

            Assert.Equal( expected , game.Grid );
        }
    }
}
