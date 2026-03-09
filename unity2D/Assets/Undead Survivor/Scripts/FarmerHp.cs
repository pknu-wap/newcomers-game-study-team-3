using UnityEngine;

public class FarmerHp:MonoBehaviour
{
    private const float MaxHp=100f;
    private const float Damage=0.5f;
    private float _currentHp=MaxHp;

    private void OnTriggerStay2D(Collider2D other)
    {
        _currentHp-=Damage;
        Debug.Log(_currentHp);
    }
}
