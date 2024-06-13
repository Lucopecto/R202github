using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrefab;      // Le prefab de la bombe
    public float spawnInterval = 2f;   // Intervalle entre les spawns
    public int maxBombCount = 20;      // Nombre maximal de bombes autorisées
    public Vector3 spawnAreaSize;      // Taille de la zone de spawn des bombes

    private int currentBombCount;       // Nombre actuel de bombes dans la scène

    private void Start()
    {
        currentBombCount = 0;  // Initialisation du compteur de bombes

        // Appeler la méthode SpawnBomb à intervalles réguliers
        InvokeRepeating("SpawnBomb", spawnInterval, spawnInterval);
    }

    private void SpawnBomb()
    {
        if (currentBombCount < maxBombCount)
        {
            // Générer une position aléatoire dans la zone de spawn
            Vector3 randomPosition = GetRandomPosition();

            // Instancier la bombe à la position aléatoire
            Instantiate(bombPrefab, randomPosition, Quaternion.identity);

            // Incrémenter le compteur de bombes
            currentBombCount++;
        }
    }

    private Vector3 GetRandomPosition()
    {
        // Générer une position aléatoire dans la zone de spawn définie par spawnAreaSize
        float randomX = Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f);
        float randomY = Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f);
        float randomZ = Random.Range(-spawnAreaSize.z / 2f, spawnAreaSize.z / 2f);

        Vector3 randomPosition = transform.position + new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
}