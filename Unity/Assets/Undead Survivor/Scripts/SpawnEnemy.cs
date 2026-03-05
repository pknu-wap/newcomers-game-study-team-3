using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform player;

    [SerializeField] private float spawnRadius = 15f;
    [SerializeField] private float minDistance = 8f;
    [SerializeField] private float spawnInterval = 2f;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= spawnInterval)
        {
            SpawnEnemy();
            _timer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector2 spawnPos;

        do
        {
            Vector2 randomCircle = Random.insideUnitCircle * spawnRadius;
            spawnPos = (Vector2)player.position + randomCircle;

        } while (Vector2.Distance(spawnPos, player.position) < minDistance);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}