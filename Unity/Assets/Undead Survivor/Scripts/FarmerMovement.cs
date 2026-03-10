using UnityEngine;
using UnityEngine.InputSystem;

public class FarmerMovement : MonoBehaviour
{
    private const float Speed = 10f;
    private Vector2 _moveDirection;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private void Awake()
    {
        // GetComponent는 여기서 한 번만
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Vector2 move = _moveDirection.normalized;
        transform.position += (Vector3)(move * Speed * Time.deltaTime);
        
        if (_moveDirection.x > 0)
        {
            _spriteRenderer.flipX = false;
        }
        else if (_moveDirection.x < 0)
        {
            _spriteRenderer.flipX = true;
        }

        bool isMoving = _moveDirection.sqrMagnitude > 0.01f;
        _animator.SetBool("isMoving", isMoving);

    }


    private void OnMove(InputValue value)
    {
        _moveDirection = value.Get<Vector2>();
    }
}