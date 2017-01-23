namespace TreehouseDefense
{
    public class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    invader.DecreaseHealth(Power);
                }
            }
        }
    }
}
