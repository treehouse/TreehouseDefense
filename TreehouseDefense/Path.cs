using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] _pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            _pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) => _pathLocations.Contains(mapLocation);

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _pathLocations.Length) ? _pathLocations[pathStep] : null;
        }
    }
}