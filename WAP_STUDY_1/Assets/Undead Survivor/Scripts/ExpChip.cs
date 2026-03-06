using UnityEngine;

public class ExpChip : MonoBehaviour
{
    private const int Exp = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("충돌됨");
        other.GetComponent<FarmerLevel>().AddExp(Exp);
        Destroy(gameObject);
    }
}
