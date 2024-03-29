using System;
using Xunit;

namespace ConwaysGameOfLife.Tests
{
    public class GridTests
    {
        [Fact]
        public void GivenWidthAndHeightOf1By1_WhenGridSet_ReturnsArrayOf1Boolean ()
        {
            int width = 1;
            int height = 1;

            Game game = new Game( width , height );

            var expected = new bool[1,1] { { false } };

            Assert.Equal( expected , game.Grid );
            Assert.Equal( 1 , game.Height );
            Assert.Equal( 1 , game.Width );
        }

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
            Assert.Equal( 3 , game.Height );
            Assert.Equal( 3 , game.Width );
        }

        [Fact]
        public void GivenGameGridCurrentCellHasNoNeighbours_WhenGetsNeighbours_Returns0()
        {
            int width = 3;
            int height = 3;

            Game game = new Game( width , height );
            var row = 0;
            var column = 0;

            var aliveCells = game.GetNeighbouringCells(row,column );

            Assert.Equal( 0 ,  aliveCells);
        }

        [Fact]
        public void GivenGameGridCurrentCellHasOneNeighbour_WhenGetsNeighbours_Returns1 ()
        {
            int width = 3;
            int height = 3;

            Game game = new Game( width , height );
            game.Grid[0 , 1] = true;

            var row = 0;
            var column = 0;
            var aliveCells = game.GetNeighbouringCells( row , column );

            Assert.Equal( 1 , aliveCells );
        }

        [Fact]
        public void GivenGameGridCurrentCellAndOneNeighbourAreTrue_WhenGetsNeighbours_Returns1 ()
        {
            int width = 3;
            int height = 3;

            Game game = new Game( width , height );
            game.Grid[0 , 0] = true;
            game.Grid[0 , 1] = true;

            var row = 0;
            var column = 0;
            var aliveCells = game.GetNeighbouringCells( row , column );

            Assert.Equal( 1 , aliveCells );
        }
    }
}
