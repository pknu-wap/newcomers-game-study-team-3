using UnityEngine;
using UnityEngine.InputSystem;

public class FarmerMovement : MonoBehaviour
{
    private const float Speed = 10f;
    private Vector3 _moveDirection;

    private void Update()
    {
        
        // Time.deltaTime 프레임 속도와 관계 없이 일정한 프레임 당 실행 보장
        // transform은 씬 속 각 오브젝트의 포지션, 로테이션 및 스케일을 결정하는 객체.
        transform.Translate(Time.deltaTime * Speed * _moveDirection);
    }

    private void OnMove(InputValue value)
    {
        Debug.Log("OnMove");
        _moveDirection = value.Get<Vector2>();
        
        // 대각선 벡터 정규화
        _moveDirection.Normalize();
    }
}