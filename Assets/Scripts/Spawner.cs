using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1;
    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("Spawn",0f,spawnSpeed);
    }

    public void Spawn()
    {
        var obj = Instantiate(prefab);
        var pos = new Vector3(Random.Range(-5f,5f), -5, 0);
        obj.transform.position = pos;
    }
}