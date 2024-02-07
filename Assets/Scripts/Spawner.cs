using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FruitEntry
{
    public bool isFruit = true;
    public float delay;
    public float x;
    public Vector2 velocity;
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


                var prefab = fruit.isFruit ? fruitPrefab : bombPrefab;
                var obj = Instantiate(prefab);
                obj.transform.position = new Vector3(fruit.x, -5, 0);

            }

            await new WaitForSeconds(3f);
            currentWave++;
        }
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