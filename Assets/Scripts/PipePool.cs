using UnityEngine;
using System.Collections.Generic;

public class PipePool : MonoBehaviour
{
    public static PipePool Instance;

    void Awake()
    {
        Instance = this;
    }
    public GameObject pipePrefab;
    public PipeSettings pipeSettings;
    public int poolSize = 5;

    private List<GameObject> pool = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject pipe = Instantiate(pipePrefab);
            pipe.SetActive(false);
            pool.Add(pipe);
        }
    }

    public GameObject GetPipe()
    {
        foreach (GameObject pipe in pool)
        {
            if (!pipe.activeInHierarchy)
            {
                float randomY = Random.Range(pipeSettings.minHeight, pipeSettings.maxHeight);
                pipe.transform.position = new Vector2(10f, randomY);
                pipe.SetActive(true);
                return pipe;
            }
        }
        return null;
    }

    public void ReturnPipe(GameObject pipe)
    {
        pipe.SetActive(false);
    }
}
