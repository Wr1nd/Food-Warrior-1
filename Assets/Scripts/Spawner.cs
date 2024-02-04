using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public GameObject fruitPrefab;

    void Start()
    {
        InvokeRepeating("Spawn",0f,spawnSpeed);
    }

    void Spawn()
    {
        var obj = Instantiate(fruitPrefab);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x,-5,0);
    }
}