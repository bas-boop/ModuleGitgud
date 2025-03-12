using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

using Framework.Extensions;

namespace Framework.Gameplay.BulletSystem
{
    public sealed class SplineBullet : ShootAble
    {
        [Header("Stats")]
        [SerializeField] private float speed;
        [SerializeField] private CardinalDirections shootDirection;

        [Header("Spline settings")]
        [SerializeField] private float segmentsLenght = 1;
        [SerializeField] private List<SplineSegment> shootPath;

        private float _splineT;
        private Spline _spline;

        private void OnEnable()
        {
            if (shootPath is not {Count: > 0})
                return;
            
            _spline = BulletRouteBuilder.GenerateSpline(shootPath, transform.position,
                shootDirection.GetVector2().normalized, segmentsLenght);
            
            StartCoroutine(MoveAlongSpline());
        }
        
        private IEnumerator MoveAlongSpline()
        {
            while (_splineT < 1f)
            {
                _splineT += Time.deltaTime * speed / _spline.Count;
                transform.position = _spline.EvaluatePosition(_splineT);
                yield return null;
            }
            Destroy(gameObject);
        }
    }
}
