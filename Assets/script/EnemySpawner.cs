using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyType1; // Prefab do inimigo tipo 1
    public GameObject enemyType2; // Prefab do inimigo tipo 2
    public GameObject enemyType3; // Prefab do inimigo tipo 3

    public float spawnInterval = 2f; // Intervalo entre os spawns
    public int maxEnemies = 12; // Limite de inimigos na cena

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
            spawnPosition = new Vector2(Random.Range(-4f, 6f), 6f); 
        }
        else if (enemyType == 2)
        {
            enemyToSpawn = enemyType2;
            spawnPosition = new Vector2(Random.Range(-4f, 6f), 10f);

            // X é -10 ou 10, Y é 2, 3 ou 4
            //float spawnX = Random.Range(0, 2) == 0 ? -4f : 6f; // Define X
            //float[] yOptions = { 2f, 3f, 4f }; // Opções fixas para Y
            //float spawnY = yOptions[Random.Range(0, yOptions.Length)];

            //spawnPosition = new Vector2(spawnX, spawnY);
        }
        else // Tipo 3
        {
            enemyToSpawn = enemyType3;
            spawnPosition = new Vector2(Random.Range(-4f, 6f), 6f);
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
