using UnityEngine;

namespace Framework.Extensions
{
    /// <summary>
    /// Provides versatile extensions for Transform, enhancing functionality for various operations.
    /// Ideal for integration into any Unity project.
    /// Extensions:
    /// - Set Axis (Position and Scale)
    /// - Divide Vector & Axis (Position and Scale)
    /// - Add Vector & Axis (Position and Scale)
    /// - Subtract Vector & Axis (Position and Scale)
    /// - Multiply Vector & Axis (Position and Scale)
    /// - Invert Vector & Axis (Position and Scale)
    /// </summary>
    public static class TransformExtensions
    {
        #region Position
        
        #region SetAxis

        public static Transform SetXPosition(this Transform t, float x)
        {
            Vector3 target = t.position;
            target.SetX(x);
            t.position = target;
            return t;
        }
        
        public static Transform SetYPosition(this Transform t, float y)
        {
            Vector3 target = t.position;
            target.SetY(y);
            t.position = target;
            return t;
        }
        
        public static Transform SetZPosition(this Transform t, float z)
        {
            Vector3 target = t.position;
            target.SetZ(z);
            t.position = target;
            return t;
        }

        #endregion

        #region Add
        
        public static Transform AddPosition(this Transform t, Transform other)
        {
            Vector3 target = t.position;
            target.Add(other.position);
            t.position = target;
            return t;
        }
        
        public static Transform AddPosition(this Transform t, Vector3 v)
        {
            Vector3 target = t.position;
            target.Add(v);
            t.position = target;
            return t;
        }
        
        public static Transform AddXPosition(this Transform t, float x)
        {
            Vector3 target = t.position;
            target.AddX(x);
            t.position = target;
            return t;
        }
        
        public static Transform AddYPosition(this Transform t, float y)
        {
            Vector3 target = t.position;
            target.AddY(y);
            t.position = target;
            return t;
        }
        
        public static Transform AddZPosition(this Transform t, float z)
        {
            Vector3 target = t.position;
            target.AddZ(z);
            t.position = target;
            return t;
        }
        
        #endregion

        #region Subtract

        public static Transform SubtractPosition(this Transform t, Transform other)
        {
            Vector3 target = t.position;
            target.Subtract(other.position);
            t.position = target;
            return t;
        }
        
        public static Transform SubtractPosition(this Transform t, Vector3 v)
        {
            Vector3 target = t.position;
            target.Subtract(v);
            t.position = target;
            return t;
        }
        
        public static Transform SubtractXPosition(this Transform t, float x)
        {
            Vector3 target = t.position;
            target.SubtractX(x);
            t.position = target;
            return t;
        }
        
        public static Transform SubtractYPosition(this Transform t, float y)
        {
            Vector3 target = t.position;
            target.SubtractY(y);
            t.position = target;
            return t;
        }
        
        public static Transform SubtractZPosition(this Transform t, float z)
        {
            Vector3 target = t.position;
            target.SubtractZ(z);
            t.position = target;
            return t;
        }

        #endregion

        #region Multiply

        public static Transform MultiplyPosition(this Transform t, Transform other)
        {
            Vector3 target = t.position;
            target.Multiply(other.position);
            t.position = target;
            return t;
        }
        
        public static Transform MultiplyPosition(this Transform t, Vector3 v)
        {
            Vector3 target = t.position;
            target.Multiply(v);
            t.position = target;
            return t;
        }
        
        public static Transform MultiplyXPosition(this Transform t, float x)
        {
            Vector3 target = t.position;
            target.MultiplyX(x);
            t.position = target;
            return t;
        }
        
        public static Transform MultiplyYPosition(this Transform t, float y)
        {
            Vector3 target = t.position;
            target.MultiplyY(y);
            t.position = target;
            return t;
        }
        
        public static Transform MultiplyZPosition(this Transform t, float z)
        {
            Vector3 target = t.position;
            target.MultiplyZ(z);
            t.position = target;
            return t;
        }

        #endregion

        #region Divide

        public static Transform DividePosition(this Transform t, Transform other)
        {
            Vector3 target = t.position;
            target.Divide(other.position);
            t.position = target;
            return t;
        }
        
        public static Transform DividePosition(this Transform t, Vector3 v)
        {
            Vector3 target = t.position;
            target.Divide(v);
            t.position = target;
            return t;
        }
        
        public static Transform DivideXPosition(this Transform t, float x)
        {
            Vector3 target = t.position;
            target.DivideX(x);
            t.position = target;
            return t;
        }
        
        public static Transform DivideYPosition(this Transform t, float y)
        {
            Vector3 target = t.position;
            target.DivideY(y);
            t.position = target;
            return t;
        }
        
        public static Transform DivideZPosition(this Transform t, float z)
        {
            Vector3 target = t.position;
            target.DivideZ(z);
            t.position = target;
            return t;
        }

        #endregion

        #region Invert

        public static Transform InvertPosition(this Transform t)
        {
            Vector3 target = t.position;
            target.Invert();
            t.position = target;
            return t;
        }
        
        public static Transform DivideXPosition(this Transform t)
        {
            Vector3 target = t.position;
            target.InvertX();
            t.position = target;
            return t;
        }
        
        public static Transform DivideYPosition(this Transform t)
        {
            Vector3 target = t.position;
            target.InvertY();
            t.position = target;
            return t;
        }
        
        public static Transform DivideZPosition(this Transform t)
        {
            Vector3 target = t.position;
            target.InvertZ();
            t.position = target;
            return t;
        }

        #endregion
        
        #endregion

        #region Scale

        #region SetAxis

        public static Transform SetXScale(this Transform t, float x)
        {
            Vector3 target = t.localScale;
            target.SetX(x);
            t.localScale = target;
            return t;
        }

        public static Transform SetYScale(this Transform t, float y)
        {
            Vector3 target = t.localScale;
            target.SetY(y);
            t.localScale = target;
            return t;
        }

        public static Transform SetZScale(this Transform t, float z)
        {
            Vector3 target = t.localScale;
            target.SetZ(z);
            t.localScale = target;
            return t;
        }

        #endregion

        #region Add

        public static Transform AddScale(this Transform t, Transform other)
        {
            Vector3 target = t.localScale;
            target.Add(other.localScale);
            t.localScale = target;
            return t;
        }

        public static Transform AddScale(this Transform t, Vector3 v)
        {
            Vector3 target = t.localScale;
            target.Add(v);
            t.localScale = target;
            return t;
        }
        
        public static Transform AddXScale(this Transform t, float x)
        {
            Vector3 target = t.localScale;
            target.AddX(x);
            t.localScale = target;
            return t;
        }

        public static Transform AddYScale(this Transform t, float y)
        {
            Vector3 target = t.localScale;
            target.AddY(y);
            t.localScale = target;
            return t;
        }

        public static Transform AddZScale(this Transform t, float z)
        {
            Vector3 target = t.localScale;
            target.AddZ(z);
            t.localScale = target;
            return t;
        }

        #endregion

        #region Subtract

        public static Transform SubtractScale(this Transform t, Transform other)
        {
            Vector3 target = t.localScale;
            target.Subtract(other.localScale);
            t.localScale = target;
            return t;
        }
        
        public static Transform SubtractScale(this Transform t, Vector3 v)
        {
            Vector3 target = t.localScale;
            target.Subtract(v);
            t.localScale = target;
            return t;
        }

        public static Transform SubtractXScale(this Transform t, float x)
        {
            Vector3 target = t.localScale;
            target.SubtractX(x);
            t.localScale = target;
            return t;
        }

        public static Transform SubtractYScale(this Transform t, float y)
        {
            Vector3 target = t.localScale;
            target.SubtractY(y);
            t.localScale = target;
            return t;
        }

        public static Transform SubtractZScale(this Transform t, float z)
        {
            Vector3 target = t.localScale;
            target.SubtractZ(z);
            t.localScale = target;
            return t;
        }

        #endregion

        #region Multiply

        public static Transform MultiplyScale(this Transform t, Transform other)
        {
            Vector3 target = t.localScale;
            target.Multiply(other.localScale);
            t.localScale = target;
            return t;
        }

        public static Transform MultiplyScale(this Transform t, Vector3 v)
        {
            Vector3 target = t.localScale;
            target.Multiply(v);
            t.localScale = target;
            return t;
        }
        
        public static Transform MultiplyXScale(this Transform t, float x)
        {
            Vector3 target = t.localScale;
            target.MultiplyX(x);
            t.localScale = target;
            return t;
        }

        public static Transform MultiplyYScale(this Transform t, float y)
        {
            Vector3 target = t.localScale;
            target.MultiplyY(y);
            t.localScale = target;
            return t;
        }

        public static Transform MultiplyZScale(this Transform t, float z)
        {
            Vector3 target = t.localScale;
            target.MultiplyZ(z);
            t.localScale = target;
            return t;
        }

        #endregion

        #region Divide

        public static Transform DivideScale(this Transform t, Transform other)
        {
            Vector3 target = t.localScale;
            target.Divide(other.localScale);
            t.localScale = target;
            return t;
        }
        
        public static Transform DivideScale(this Transform t, Vector3 v)
        {
            Vector3 target = t.localScale;
            target.Divide(v);
            t.localScale = target;
            return t;
        }

        public static Transform DivideXScale(this Transform t, float x)
        {
            Vector3 target = t.localScale;
            target.DivideX(x);
            t.localScale = target;
            return t;
        }

        public static Transform DivideYScale(this Transform t, float y)
        {
            Vector3 target = t.localScale;
            target.DivideY(y);
            t.localScale = target;
            return t;
        }

        public static Transform DivideZScale(this Transform t, float z)
        {
            Vector3 target = t.localScale;
            target.DivideZ(z);
            t.localScale = target;
            return t;
        }

        #endregion

        #region Invert

        public static Transform InvertScale(this Transform t)
        {
            Vector3 target = t.localScale;
            target.Invert();
            t.localScale = target;
            return t;
        }

        public static Transform InvertXScale(this Transform t)
        {
            Vector3 target = t.localScale;
            target.InvertX();
            t.localScale = target;
            return t;
        }

        public static Transform InvertYScale(this Transform t)
        {
            Vector3 target = t.localScale;
            target.InvertY();
            t.localScale = target;
            return t;
        }

        public static Transform InvertZScale(this Transform t)
        {
            Vector3 target = t.localScale;
            target.InvertZ();
            t.localScale = target;
            return t;
        }

        #endregion

        #endregion
    }
}
