using UnityEngine;

[CreateAssetMenu(fileName = "PipeSettings", menuName = "Scriptable Objects/PipeSettings")]
public class PipeSettings : ScriptableObject
{
    public float moveSpeed = 3f;
    public float spawnInterval = 2f;
    public float minHeight = -2f;
    public float maxHeight = 2f;
}
