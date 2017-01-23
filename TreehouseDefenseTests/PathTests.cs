using System.Linq;
using Xunit;

namespace TreehouseDefense.Tests
{
    public class PathTests
    {
        private Map _map3x3;
        private MapLocation[] _pathLocations3;
        private Path _path3;

        public PathTests()
        {
            _map3x3 = new Map(3, 3);

            _pathLocations3 = new MapLocation[]
            {
                new MapLocation(0, 1, _map3x3),
                new MapLocation(1, 1, _map3x3),
                new MapLocation(2, 1, _map3x3)
            };

            _path3 = new Path(_pathLocations3);
        }

        [Fact]
        public void MapLocationIsOnPath()
        {
            var target = _path3;
            Assert.True(target.IsOnPath(new MapLocation(0, 1, _map3x3)));
        }

        [Fact]
        public void MapLocationIsNotOnPath()
        {
            var target = _path3;
            Assert.False(target.IsOnPath(new MapLocation(0, 0, _map3x3)));
        }

        [Fact]
        public void GetLocationAtBeginningOfPath()
        {
            var target = _path3;
            Assert.Equal(_pathLocations3.First(), target.GetLocationAt(0));
        }

        [Fact]
        public void GetLocationAtEndOfPath()
        {
            var target = _path3;
            Assert.Equal(_pathLocations3.Last(), target.GetLocationAt(_pathLocations3.Length - 1));
        }

        [Fact]
        public void GetLocationNotOnPath()
        {
            var target = _path3;
            Assert.Null(target.GetLocationAt(_pathLocations3.Length + 1));
        }

        [Fact]
        public void GetLocationAtOneStepAfterEndOfPath()
        {
            var target = _path3;
            Assert.Null(target.GetLocationAt(_pathLocations3.Length));
        }
    }
}
