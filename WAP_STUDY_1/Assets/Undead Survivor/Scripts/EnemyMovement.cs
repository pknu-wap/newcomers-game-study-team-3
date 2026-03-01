using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float Speed = 5f;
    private Transform _playerTransform;

    private void Awake()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // 방향 설정
        var direction = _playerTransform.position - transform.position;
        direction.Normalize();
        transform.Translate(Time.deltaTime * Speed * direction);
    }
}
