using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemytype1;
    public GameObject Enemytype2;
    public float minX, maxX, minY, maxY;
    public float spawnInterval = 2.0f;
    public int maxEnemies = 10;

    private int currentEnemyCount = 0;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    private void SpawnEnemy()
    {
        if (currentEnemyCount >= maxEnemies)
        {
            CancelInvoke(nameof(SpawnEnemy));
            return;
        }

        GameObject enemyToSpawn = Random.value > 0.5f ? Enemytype1 : Enemytype2;
        Vector2 spawnPosition = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );

        GameObject spawnedEnemy = Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
        currentEnemyCount++;
        spawnedEnemy.GetComponent<Enemy>().OnDestroyed += HandleEnemyDestroyed;
    }

    private void HandleEnemyDestroyed()
    {
        currentEnemyCount--;
        if (!IsInvoking(nameof(SpawnEnemy)))
        {
            InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
        }
    }
}