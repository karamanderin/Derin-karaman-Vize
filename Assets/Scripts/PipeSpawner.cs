using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    public PipeSettings pipeSettings;
    public GameObject coinPrefab;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            PipePool.Instance.GetPipe();

            if (Random.Range(0, 3) == 0)
            {
                SpawnCoin();
            }

            yield return new WaitForSeconds(pipeSettings.spawnInterval);
        }
    }

    void SpawnCoin()
    {
        float randomY = Random.Range(pipeSettings.minHeight, pipeSettings.maxHeight);
        float randomX = Random.Range(5f, 8f);
        Instantiate(coinPrefab, new Vector2(randomX, randomY), Quaternion.identity);
    }
}