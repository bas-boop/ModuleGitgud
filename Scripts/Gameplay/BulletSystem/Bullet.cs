using UnityEngine;

using Framework.Extensions;

namespace Framework.Gameplay.BulletSystem
{
    public sealed class Bullet : ShootAble
    {
        private const float DEGREE_CORRECTION = 90;
        
        [Header("Stats")]
        [SerializeField] private float speed;
        [SerializeField] private float despawnDistance = 10;
        [SerializeField] private CardinalDirections shootDirection;
        
        private Vector2 _currentDirection;
        private Vector2 _spawnPosition;

        private void Awake() => GetRequirements();

        private void OnEnable() => Move();

        private void Update()
        {
            Vector3 traveledPosition = transform.position - (Vector3)_spawnPosition;
            
            if (traveledPosition.magnitude > despawnDistance)
                Destroy(gameObject);
        }

        private void Move()
        {
            _currentDirection = shootDirection.GetVector2().normalized * speed;
            p_rigidbody2D.linearVelocity = _currentDirection;
            float angle = Mathf.Atan2(_currentDirection.y, _currentDirection.x) * Mathf.Rad2Deg - DEGREE_CORRECTION;
            Transform t;
            (t = transform).rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            _spawnPosition = t.position;
        }
    }
}