using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    private const float MaxHp = 60f;
    [SerializeField] private GameObject expChip;
    private float _currentHp = MaxHp;

    public void TakeDamage(float damage)
    {
        _currentHp -= damage;
        Debug.Log("적 체력: "+_currentHp);
        if (_currentHp <= 0f)
        {
            OnEnemyDeath();
        }
    }

    public void OnEnemyDeath()
    {
        // Instantiate 함수란, 게임 오브젝트를 다이나믹(객체가 필요한 순간에 생성)으로 생성할 때 사용. 주로 프리팹을 생성할 때 자주 사용.
        Instantiate(expChip, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
