using UnityEngine;
using UnityEngine.InputSystem;

public class FarmerMovement : MonoBehaviour
{
    private const float Speed = 10f;
    private Vector2 _moveDirection;

    private void Update()
    {
        Vector2 move = _moveDirection.normalized;
        transform.position += (Vector3)(move * Speed * Time.deltaTime);
    }

    private void OnMove(InputValue value)
    {
        _moveDirection = value.Get<Vector2>();
    }
}