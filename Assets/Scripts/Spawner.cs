using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1;
    public GameObject fruitPrefab;
    public GameObject bombPrefab;

    void Start()
    {
        InvokeRepeating("Spawn",0f,spawnSpeed);
    }

    public void Spawn()
    {
        GameObject prefab;
        prefab = Random.Range(0, 100) < 80 ? fruitPrefab : bombPrefab;

        var obj = Instantiate(prefab);
        var pos = new Vector3(Random.Range(-5f,5f), -5, 0);
        obj.transform.position = pos;
    }
}