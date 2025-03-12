using UnityEngine;

using Framework.Extensions.Attributes;

namespace Framework.Gameplay.BulletSystem
{
    [RequireComponent(typeof(Rigidbody2D), 
        typeof(Collider2D))]
    public abstract class ShootAble : MonoBehaviour
    {
        [Header("Behavior to target")]
        [SerializeField, Tag] private string targetTag;
        [SerializeField] private int damage = 1;
		
        protected Rigidbody2D p_rigidbody2D;
        protected Collider2D p_collider2D;
        
        private GameObject _lastHitTarget;
        private Health _otherHealth;
        private Vector2 _currentDirection;
		
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag(targetTag))
                return;

            if (_lastHitTarget != other.gameObject)
                _otherHealth = other.GetComponent<Health>();

            _otherHealth.TakeDamage(damage);
        }
		
        /// <summary>
        /// Get components the Rigidbody2D and Collider2D for easy to use inherent class.
        /// </summary>>
        protected void GetRequirements()
        {
            p_rigidbody2D = GetComponent<Rigidbody2D>();
            p_collider2D = GetComponent<Collider2D>();
        }
    }
}