using UnityEngine;

namespace Framework.Extensions
{
    /// <summary>
    /// Provides versatile extensions for Rigidbody, enhancing functionality for various operations.
    /// Ideal for integration into any Unity project.
    /// Extensions:
    /// - Set Axis (Velocity)
    /// - Divide Vector & Axis (Velocity)
    /// - Add Vector & Axis (Velocity)
    /// - Subtract Vector & Axis (Velocity)
    /// - Multiply Vector & Axis (Velocity)
    /// - Invert Vector & Axis (Velocity)
    /// </summary>
    public static class RigidbodyExtensions
    {
        #region Velocity

        #region SetAxis

        public static Rigidbody SetXVelocity(this Rigidbody rb, float x)
        {
            Vector3 target = rb.linearVelocity;
            target.SetX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SetYVelocity(this Rigidbody rb, float y)
        {
            Vector3 target = rb.linearVelocity;
            target.SetY(y);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SetZVelocity(this Rigidbody rb, float z)
        {
            Vector3 target = rb.linearVelocity;
            target.SetZ(z);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Add

        public static Rigidbody AddVelocity(this Rigidbody rb, Rigidbody other)
        {
            Vector3 target = rb.linearVelocity;
            target.Add(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody AddVelocity(this Rigidbody rb, Vector3 v)
        {
            Vector3 target = rb.linearVelocity;
            target.Add(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody AddXVelocity(this Rigidbody rb, float x)
        {
            Vector3 target = rb.linearVelocity;
            target.AddX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody AddYVelocity(this Rigidbody rb, float y)
        {
            Vector3 target = rb.linearVelocity;
            target.AddY(y);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody AddZVelocity(this Rigidbody rb, float z)
        {
            Vector3 target = rb.linearVelocity;
            target.AddZ(z);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Subtract

        public static Rigidbody SubtractVelocity(this Rigidbody rb, Rigidbody other)
        {
            Vector3 target = rb.linearVelocity;
            target.Subtract(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SubtractVelocity(this Rigidbody rb, Vector3 v)
        {
            Vector3 target = rb.linearVelocity;
            target.Subtract(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SubtractXVelocity(this Rigidbody rb, float x)
        {
            Vector3 target = rb.linearVelocity;
            target.SubtractX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SubtractYVelocity(this Rigidbody rb, float y)
        {
            Vector3 target = rb.linearVelocity;
            target.SubtractY(y);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody SubtractZVelocity(this Rigidbody rb, float z)
        {
            Vector3 target = rb.linearVelocity;
            target.SubtractZ(z);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Multiply

        public static Rigidbody MultiplyVelocity(this Rigidbody rb, Rigidbody other)
        {
            Vector3 target = rb.linearVelocity;
            target.Multiply(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody MultiplyVelocity(this Rigidbody rb, Vector3 v)
        {
            Vector3 target = rb.linearVelocity;
            target.Multiply(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody MultiplyXVelocity(this Rigidbody rb, float x)
        {
            Vector3 target = rb.linearVelocity;
            target.MultiplyX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody MultiplyYVelocity(this Rigidbody rb, float y)
        {
            Vector3 target = rb.linearVelocity;
            target.MultiplyY(y);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody MultiplyZVelocity(this Rigidbody rb, float z)
        {
            Vector3 target = rb.linearVelocity;
            target.MultiplyZ(z);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Divide

        public static Rigidbody DivideVelocity(this Rigidbody rb, Rigidbody other)
        {
            Vector3 target = rb.linearVelocity;
            target.Divide(other.linearVelocity);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody DivideVelocity(this Rigidbody rb, Vector3 v)
        {
            Vector3 target = rb.linearVelocity;
            target.Divide(v);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody DivideXVelocity(this Rigidbody rb, float x)
        {
            Vector3 target = rb.linearVelocity;
            target.DivideX(x);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody DivideYVelocity(this Rigidbody rb, float y)
        {
            Vector3 target = rb.linearVelocity;
            target.DivideY(y);
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody DivideZVelocity(this Rigidbody rb, float z)
        {
            Vector3 target = rb.linearVelocity;
            target.DivideZ(z);
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #region Invert

        public static Rigidbody InvertVelocity(this Rigidbody rb)
        {
            Vector3 target = rb.linearVelocity;
            target.Invert();
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody InvertXVelocity(this Rigidbody rb)
        {
            Vector3 target = rb.linearVelocity;
            target.InvertX();
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody InvertYVelocity(this Rigidbody rb)
        {
            Vector3 target = rb.linearVelocity;
            target.InvertY();
            rb.linearVelocity = target;
            return rb;
        }

        public static Rigidbody InvertZVelocity(this Rigidbody rb)
        {
            Vector3 target = rb.linearVelocity;
            target.InvertZ();
            rb.linearVelocity = target;
            return rb;
        }

        #endregion

        #endregion
    }
}
