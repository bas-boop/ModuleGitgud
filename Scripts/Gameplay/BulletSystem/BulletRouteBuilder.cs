using UnityEngine;
using UnityEngine.Splines;
using Unity.Mathematics;
using System.Collections.Generic;

using Framework.Extensions;

namespace Framework.Gameplay.BulletSystem
{
    public static class BulletRouteBuilder
    {
        public static Spline GenerateSpline(
            List<SplineSegment> segments,
            Vector3 startPosition,
            Vector2 initialDirection,
            float segmentsLength)
        {
            Spline spline = new Spline();
            Vector3 currentPosition = startPosition;

            foreach (SplineSegment segment in segments)
            {
                if (segment.useCustomSpline && segment.customSplineContainer != null)
                    AppendCustomSpline(spline, segment.customSplineContainer.Spline, ref currentPosition);
                else
                {
                    switch (segment.route)
                    {
                        case SplineRoute.LINE:
                            AddLineSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.CURVE:
                            AddCurveSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.MIRRORED_CURVE:
                            AddMirroredCurveSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.LOOP:
                            AddLoopSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.MIRRORED_LOOP:
                            AddMirroredLoopSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.U_SHAPE:
                            AddUShapeSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        case SplineRoute.MIRRORED_U_SHAPE:
                            AddMirroredUShapeSegment(spline, ref currentPosition, segmentsLength);
                            break;
                        default:
                            AddLineSegment(spline, ref currentPosition, segmentsLength);
                            Debug.LogError("BulletRouteBuilder has an error, a line has been created!");
                            break;
                    }
                }
            }

            AdjustSplineForDirection(spline, initialDirection, startPosition);
            return spline;
        }

        private static void AppendCustomSpline(
            Spline spline,
            Spline customSpline,
            ref Vector3 currentPosition)
        {
            for (int i = 0; i < customSpline.GetPointCount(); i++)
                spline.AddPoint(customSpline.GetPoint(i) + currentPosition);

            currentPosition += customSpline.GetPoint(customSpline.GetPointCount() - 1);
        }

        private static void AdjustSplineForDirection(
            Spline spline,
            Vector2 direction,
            Vector3 startPosition)
        {
            float angle = Vector2.SignedAngle(Vector2.up, direction);
            Quaternion rotation = Quaternion.Euler(0, 0, angle);

            for (int i = 0; i < spline.GetPointCount(); i++)
            {
                Vector3 point = spline.GetPoint(i) - startPosition;
                spline.SetPoint(i, rotation * point + startPosition);
            }
        }

        #region AddSegment

        private static void AddLineSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            spline.AddPoint(currentPointPosition);
            currentPointPosition += Vector3.up * length;
            spline.AddPoint(currentPointPosition);
        }

        private static void AddCurveSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition)
            {
                TangentIn = 0,
                TangentOut = length,
                Rotation = quaternion.identity
            };
            spline.AddKnot(startKnot);
            Vector3 endPoint = currentPointPosition + new Vector3(length, length, 0);
            BezierKnot endKnot = new BezierKnot(endPoint);
            spline.AddKnot(endKnot);
        }

        private static void AddMirroredCurveSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition);
            Vector3 controlPoint1 = currentPointPosition + new Vector3(-length * 0.5f, length * 0.5f, 0);
            Vector3 controlPoint2 = currentPointPosition + new Vector3(-length, length, 0);
            currentPointPosition += new Vector3(-length, length, 0);
            BezierKnot endKnot = new BezierKnot(currentPointPosition, controlPoint1, controlPoint2);
            spline.AddKnot(startKnot);
            spline.AddKnot(endKnot);
        }

        private static void AddLoopSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition);
            Vector3 controlPoint1 = currentPointPosition + new Vector3(length * 0.5f, length * 0.5f, 0);
            Vector3 controlPoint2 = currentPointPosition + new Vector3(length * 0.5f, -length * 0.5f, 0);
            currentPointPosition += new Vector3(length, 0, 0);
            BezierKnot midKnot = new BezierKnot(currentPointPosition, controlPoint1, controlPoint2);

            Vector3 loopControlPoint1 = currentPointPosition + new Vector3(-length * 0.5f, -length * 0.5f, 0);
            Vector3 loopControlPoint2 = currentPointPosition + new Vector3(-length * 0.5f, length * 0.5f, 0);
            currentPointPosition += new Vector3(-length, 0, 0);
            BezierKnot endKnot = new BezierKnot(currentPointPosition, loopControlPoint1, loopControlPoint2);

            spline.AddKnot(startKnot);
            spline.AddKnot(midKnot);
            spline.AddKnot(endKnot);
        }

        private static void AddMirroredLoopSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition);
            Vector3 controlPoint1 = currentPointPosition + new Vector3(-length * 0.5f, length * 0.5f, 0);
            Vector3 controlPoint2 = currentPointPosition + new Vector3(-length * 0.5f, -length * 0.5f, 0);
            currentPointPosition += new Vector3(-length, 0, 0);
            BezierKnot midKnot = new BezierKnot(currentPointPosition, controlPoint1, controlPoint2);

            Vector3 loopControlPoint1 = currentPointPosition + new Vector3(length * 0.5f, -length * 0.5f, 0);
            Vector3 loopControlPoint2 = currentPointPosition + new Vector3(length * 0.5f, length * 0.5f, 0);
            currentPointPosition += new Vector3(length, 0, 0);
            BezierKnot endKnot = new BezierKnot(currentPointPosition, loopControlPoint1, loopControlPoint2);

            spline.AddKnot(startKnot);
            spline.AddKnot(midKnot);
            spline.AddKnot(endKnot);
        }

        private static void AddUShapeSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition);
            Vector3 controlPoint1 = currentPointPosition + new Vector3(length * 0.5f, length * 0.5f, 0);
            Vector3 controlPoint2 = currentPointPosition + new Vector3(-length * 0.5f, length * 0.5f, 0);
            currentPointPosition += new Vector3(0, length, 0);
            BezierKnot endKnot = new BezierKnot(currentPointPosition, controlPoint1, controlPoint2);

            spline.AddKnot(startKnot);
            spline.AddKnot(endKnot);
        }

        private static void AddMirroredUShapeSegment(Spline spline, ref Vector3 currentPointPosition, float length)
        {
            BezierKnot startKnot = new BezierKnot(currentPointPosition);
            Vector3 controlPoint1 = currentPointPosition + new Vector3(-length * 0.5f, length * 0.5f, 0);
            Vector3 controlPoint2 = currentPointPosition + new Vector3(length * 0.5f, length * 0.5f, 0);
            currentPointPosition += new Vector3(0, length, 0);
            BezierKnot endKnot = new BezierKnot(currentPointPosition, controlPoint1, controlPoint2);

            spline.AddKnot(startKnot);
            spline.AddKnot(endKnot);
        }

        #endregion
    }
}
