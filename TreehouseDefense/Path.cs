﻿using System;
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
    }
}