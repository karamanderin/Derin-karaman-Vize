using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public PipeSettings pipeSettings;
    
    void Update()
    {
        transform.position += Vector3.left * pipeSettings.moveSpeed * Time.deltaTime;
        
        if (transform.position.x < -10f)
        {
            PipePool.Instance.ReturnPipe(gameObject);
        }
    }
}
