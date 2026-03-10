using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float Speed = 2f;
    private const float KnockbackPower = 7f;
    private const float KnockbackTime = 0.05f;

    private Transform _playerTransform;

    private Vector2 _knockbackDirection;
    private float _knockbackTimer;

    private void Awake()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // 넉백
        if (_knockbackTimer > 0)
        {
            transform.Translate(_knockbackDirection * KnockbackPower * Time.deltaTime);
            _knockbackTimer -= Time.deltaTime;
            return;
        }


        var direction = _playerTransform.position - transform.position;
        direction.Normalize();
        transform.Translate(direction * Speed * Time.deltaTime);
    }

    public void Knockback()
    {
        Vector2 awayFromPlayer = (transform.position - _playerTransform.position).normalized;

        Vector2 random = Random.insideUnitCircle * 1.2f;

        _knockbackDirection = (awayFromPlayer + random).normalized;
        _knockbackTimer = KnockbackTime;
    }
}