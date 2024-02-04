using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public int bombChance = 20;
    public GameObject fruitPrefab;
    public GameObject bombPrefab;

    void Start()
    {
        InvokeRepeating("Spawn",0f,spawnSpeed);
    }

    void Spawn()
    {
        // choose bomb or food
        var chance = Random.Range(0, 100);
        var prefab = chance > bombChance ? fruitPrefab : bombPrefab;

        // spawn with random x
        var obj = Instantiate(prefab);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x,-5,0);
    }
}