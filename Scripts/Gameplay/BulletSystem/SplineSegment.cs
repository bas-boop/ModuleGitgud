using UnityEngine.Splines;

namespace Framework.Gameplay.BulletSystem
{
    [System.Serializable]
    public struct SplineSegment
    {
        public bool useCustomSpline;
        public SplineContainer customSplineContainer;
        public SplineRoute route;
    }
}