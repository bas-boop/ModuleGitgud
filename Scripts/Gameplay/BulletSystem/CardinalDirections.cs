using Framework.Extensions.Attributes;

namespace Framework.Gameplay.BulletSystem
{
    public enum CardinalDirections
    {
        [Vector2Value(0,1)] NORTH,
        [Vector2Value(1,1)] NORTHEAST,
        [Vector2Value(1,0)] EAST,
        [Vector2Value(1,-1)] SOUTHEAST,
        [Vector2Value(0,-1)] SOUTH,
        [Vector2Value(-1,-1)] SOUTHWEST,
        [Vector2Value(-1,0)]  WEST,
        [Vector2Value(-1,1)] NORTHWEST
    }
}