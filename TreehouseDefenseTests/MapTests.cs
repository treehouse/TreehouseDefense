using Xunit;

namespace TreehouseDefense.Tests
{
    public class MapTests
    {
        private Map _map3 = new Map(3, 3);

        [Fact()]
        public void MapSizeTooSmall()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => new Map(0, 0));
        }

        [Fact()]
        public void PointIsOnMap()
        {
            var target = _map3;
            Assert.True(target.OnMap(new Point(1, 2)));
        }

        [Fact()]
        public void PointIsNotOnMap()
        {
            var target = _map3;
            Assert.False(target.OnMap(new Point(3, 3)));
        }
    }
}