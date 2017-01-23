namespace TreehouseDefense
{
    public interface IInvader
    {
        MapLocation Location { get; }
        bool HasScored { get; }
        int Health { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }

        void DecreaseHealth(int factor);
        void Move();
    }
}
