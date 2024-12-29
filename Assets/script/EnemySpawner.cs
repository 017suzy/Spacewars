using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyType1; // Prefab do inimigo tipo 1
    public GameObject enemyType2; // Prefab do inimigo tipo 2
    public GameObject enemyType3; // Prefab do inimigo tipo 3

    public float spawnInterval = 2f; // Intervalo entre os spawns
    public int maxEnemies = 10; // Limite de inimigos na cena

    private int currentEnemyCount = 0; // Contador de inimigos ativos

    private void Start()
    {
        // Inicia o spawn em loop
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    private void SpawnEnemy()
    {
        if (currentEnemyCount >= maxEnemies) return;

        // Decide qual tipo de inimigo criar
        int enemyType = Random.Range(1, 4);

        GameObject enemyToSpawn;
        Vector2 spawnPosition;

        if (enemyType == 1)
        {
            enemyToSpawn = enemyType1;
            spawnPosition = new Vector2(
                Random.Range(-9f, 9f), // Intervalo X
                Random.Range(4f, 10f) // Intervalo Y
            );
        }
        else if (enemyType == 2)
        {
            enemyToSpawn = enemyType2;
            spawnPosition = new Vector2(
                Random.Range(-9f, 9f), // Intervalo X
                Random.Range(4f, 10f) // Intervalo Y
            );
        }
        else // Tipo 3
        {
            enemyToSpawn = enemyType3;
            spawnPosition = new Vector2(
                Random.Range(-6f, 6f), // Intervalo X exclusivo
                Random.Range(4f, 10f) // Intervalo Y
            );
        }

        // Cria o inimigo na posição gerada
        Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
        currentEnemyCount++;
    }

    public void OnEnemyDestroyed()
    {
        currentEnemyCount--;
    }
}
