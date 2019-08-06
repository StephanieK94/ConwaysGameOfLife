using System;
using Xunit;

namespace ConwaysGameOfLife.Tests
{
    public class GridTests
    {
        private readonly Game game;
        public GridTests()
        {
            game = new Game();
        }

        [Fact]
        public void GivenNewGame_WhenCallsGridOf1By1_ReturnsArrayOfSingleBoolean ()
        {
            var actual = game.Grid(1,1);
            var expected = new bool[1 , 1] { { false } };

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void GivenNewGame_WhenCallsGridOf3By3_ReturnsArrayOf3By3Boolean ()
        {
            var actual = game.Grid( 3,3 );
            var expected = new bool[3,3] 
            { 
                { false,false,false },
                { false , false , false }, 
                { false , false , false }
            };

            Assert.Equal( expected , actual );
        }
    }
}
