using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreehouseDefense;
using Xunit;

namespace TreehouseDefenseTests
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
    }
}
