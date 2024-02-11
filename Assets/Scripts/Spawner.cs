using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FruitEntry
{
    public bool isFruit = true;
    public float delay;
    public float x;
    public Vector2 velocity;
    public bool isRandomPosition;
}


[System.Serializable]
public class Wave
{
    public List<FruitEntry> fruits;
}

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1;
    public GameObject fruitPrefab;
    public GameObject bombPrefab;

    public List<Wave> waves = new();
    public List<GameObject> fruitPrefabs;
    public int currentWave;

    async void Start()
    {
        while (currentWave < waves.Count)
        {
            var wave = waves[currentWave];
            print(currentWave);
            for (int i = 0; i < wave.fruits.Count; i++)
            {

                var fruit = wave.fruits[i];
                await new WaitForSeconds(fruit.delay);

                var currentFruitPrefab = fruitPrefabs[Random.Range(0, fruitPrefabs.Count)];
                var prefab = fruit.isFruit ? currentFruitPrefab : bombPrefab;
                var obj = Instantiate(prefab);
                var x = fruit.isRandomPosition ? Random.Range(-3f,3f): fruit.x;
                obj.transform.position = new Vector3(x, -5, 0);
                obj.GetComponent<Rigidbody2D>().velocity = fruit.velocity;

            }

            await new WaitForSeconds(3f);
            currentWave++;
        }
    }
}