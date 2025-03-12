using UnityEngine;

namespace Framework.Extensions
{
    /// <summary>
    /// Provides versatile extensions for Rigidbody2D, enhancing functionality for various operations.
    /// Ideal for integration into any Unity project.
    /// Extensions:
    /// - Set Axis (Velocity)
    /// - Divide Vector & Axis (Velocity)
    /// - Add Vector & Axis (Velocity)
    /// - Subtract Vector & Axis (Velocity)
    /// - Multiply Vector & Axis (Velocity)
    /// - Invert Vector & Axis (Velocity)
    /// </summary>
    public static class Rigidbody2DExtensions
    {
        #region Velocity

        #region SetAxis

        public static Rigidbody2D SetXVelocity(this Rigidbody2D rb, float x)
        {
            Vector2 target = rb.linearVelocity;
            target.SetX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D SetYVelocity(this Rigidbody2D rb, float y)
        {
            Vector2 target = rb.linearVelocity;
            target.SetY(y);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Add

        public static Rigidbody2D AddVelocity(this Rigidbody2D rb, Rigidbody2D other)
        {
            Vector2 target = rb.linearVelocity;
            target.Add(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D AddVelocity(this Rigidbody2D rb, Vector2 v)
        {
            Vector2 target = rb.linearVelocity;
            target.Add(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D AddXVelocity(this Rigidbody2D rb, float x)
        {
            Vector2 target = rb.linearVelocity;
            target.AddX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D AddYVelocity(this Rigidbody2D rb, float y)
        {
            Vector2 target = rb.linearVelocity;
            target.AddY(y);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Subtract

        public static Rigidbody2D SubtractVelocity(this Rigidbody2D rb, Rigidbody2D other)
        {
            Vector2 target = rb.linearVelocity;
            target.Subtract(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D SubtractVelocity(this Rigidbody2D rb, Vector2 v)
        {
            Vector2 target = rb.linearVelocity;
            target.Subtract(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D SubtractXVelocity(this Rigidbody2D rb, float x)
        {
            Vector2 target = rb.linearVelocity;
            target.SubtractX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D SubtractYVelocity(this Rigidbody2D rb, float y)
        {
            Vector2 target = rb.linearVelocity;
            target.SubtractY(y);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Multiply

        public static Rigidbody2D MultiplyVelocity(this Rigidbody2D rb, Rigidbody2D other)
        {
            Vector2 target = rb.linearVelocity;
            target.Multiply(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D MultiplyVelocity(this Rigidbody2D rb, Vector2 v)
        {
            Vector2 target = rb.linearVelocity;
            target.Multiply(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D MultiplyXVelocity(this Rigidbody2D rb, float x)
        {
            Vector2 target = rb.linearVelocity;
            target.MultiplyX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D MultiplyYVelocity(this Rigidbody2D rb, float y)
        {
            Vector2 target = rb.linearVelocity;
            target.MultiplyY(y);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Divide

        public static Rigidbody2D DivideVelocity(this Rigidbody2D rb, Rigidbody2D other)
        {
            Vector2 target = rb.linearVelocity;
            target.Divide(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D DivideVelocity(this Rigidbody2D rb, Vector2 v)
        {
            Vector2 target = rb.linearVelocity;
            target.Divide(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D DivideXVelocity(this Rigidbody2D rb, float x)
        {
            Vector2 target = rb.linearVelocity;
            target.DivideX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D DivideYVelocity(this Rigidbody2D rb, float y)
        {
            Vector2 target = rb.linearVelocity;
            target.DivideY(y);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Invert

        public static Rigidbody2D InvertVelocity(this Rigidbody2D rb)
        {
            Vector2 target = rb.linearVelocity;
            target.Invert();
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D InvertXVelocity(this Rigidbody2D rb)
        {
            Vector2 target = rb.linearVelocity;
            target.InvertX();
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody2D InvertYVelocity(this Rigidbody2D rb)
        {
            Vector2 target = rb.linearVelocity;
            target.InvertY();
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #endregion
    }
}