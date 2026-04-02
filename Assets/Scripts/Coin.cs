using UnityEngine;

public class Coin : MonoBehaviour
{
    public PipeSettings pipeSettings;
    public int coinValue = 3;

    void Update()
    {
        transform.position += Vector3.left * pipeSettings.moveSpeed * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(coinValue);
            gameObject.SetActive(false);
        }
    }
}