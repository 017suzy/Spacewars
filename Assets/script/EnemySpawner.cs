using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyType1;
    public GameObject enemyType2;
    public GameObject enemyType3; // Terceiro tipo de inimigo

    public float minX, maxX, minY, maxY;
    public float spawnInterval = 2.0f;
    public int maxEnemies = 10;

    private int currentEnemyCount = 0;

    // Posição fixa para o terceiro inimigo
    public Vector2 fixedSpawnPosition = new Vector2(-8, 4);

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

        GameObject enemyToSpawn;
        Vector2 spawnPosition;

        // Escolhe aleatoriamente o tipo de inimigo
        float randomValue = Random.value;

        if (randomValue > 0.66f)
        {
            // Terceiro inimigo
            enemyToSpawn = enemyType3;
            spawnPosition = fixedSpawnPosition; // Posição fixa
        }
        else if (randomValue > 0.33f)
        {
            enemyToSpawn = enemyType2;
            spawnPosition = new Vector2(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY)
            );
        }
        else
        {
            enemyToSpawn = enemyType1;
            spawnPosition = new Vector2(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY)
            );
        }

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