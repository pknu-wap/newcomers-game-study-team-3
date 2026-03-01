using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    private const float MaxHp = 60f;
    private float _currentHp = MaxHp;

    public void TakeDamage(float damage)
    {
        Debug.Log(_currentHp);
        _currentHp -= damage;
        Debug.Log(_currentHp);
    }
}
