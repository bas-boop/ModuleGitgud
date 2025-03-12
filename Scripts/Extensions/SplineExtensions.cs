using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace Framework.Extensions
{ 
	public static class SplineExtensions 
	{ 
		/// <summary>
		/// Adds a new point at the end of the specified spline.
		/// </summary>
		/// <param name="spline">The spline to which the point will be added.</param>
		/// <param name="point">The point to add to the spline.</param>
		public static void AddPoint(this Spline spline, Vector3 point) 
			=> spline.Insert(spline.GetPointCount(), 
				new BezierKnot(point, 0, 0, Quaternion.identity));
		
		/// <summary>
		/// Adds a new knot at the end of the specified spline.
		/// </summary>
		/// <param name="spline">The spline to which the knot will be added.</param>
		/// <param name="knot">The knot to add to the spline.</param>
		public static void AddKnot(this Spline spline, BezierKnot knot) => spline.Insert(spline.GetPointCount(), knot);

		/// <summary>
		/// Retrieves the number of points in the specified spline.
		/// </summary>
		/// <param name="spline">The spline from which to retrieve the point count.</param>
		/// <returns>The number of points in the spline.</returns>
		public static int GetPointCount(this Spline spline) => spline.Count;

		/// <summary>
		/// Retrieves the point at the specified index from the spline.
		/// </summary>
		/// <param name="spline">The spline from which to retrieve the point.</param>
		/// <param name="index">The index of the point to retrieve.</param>
		/// <returns>The point at the specified index.</returns>
		public static Vector3 GetPoint(this Spline spline, int index) => spline[index].Position;

		/// <summary>
		/// Sets the point at the specified index in the spline to the given point.
		/// </summary>
		/// <param name="spline">The spline in which to set the point.</param>
		/// <param name="index">The index of the point to set.</param>
		/// <param name="point">The new point value.</param>
		public static void SetPoint(
			this Spline spline,
			int index,
			Vector3 point)
		{
			List<BezierKnot> knots = new (spline);
			BezierKnot newKnot = new(point, 0, 0, Quaternion.identity);

			if (index < knots.Count)
				knots[index] = newKnot;
			else
				knots.Insert(index, newKnot);

			spline.Clear();

			foreach (BezierKnot bezierKnot in knots)
				spline.Insert(spline.GetPointCount(), bezierKnot);
		}
	}
}
