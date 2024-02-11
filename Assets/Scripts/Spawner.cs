using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodEntry
{
    public bool isBomb;
    public float x;
    public float delay;
    public bool isRandomPosition;
    public Vector2 velocity = new Vector2(0,10);
}

[System.Serializable]
public class Wave
{
    public List<FoodEntry> foods;
}

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public int bombChance = 20;
    public List<GameObject> fruitPrefabs;
    public GameObject bombPrefab;

    public int currentWave;
    public List<Wave> waves;

    async void Start()
    {
        while (currentWave < waves.Count)
        {
            var wave = waves[currentWave];

            for (int i = 0; i < wave.foods.Count; i++)
            {
                var food = wave.foods[i];
                await new WaitForSeconds(food.delay);

                var randomFoodPrefab = fruitPrefabs[Random.Range(0, fruitPrefabs.Count)];
                var prefab = food.isBomb ? bombPrefab : randomFoodPrefab;
                var go = Instantiate(prefab);
                var x = food.isRandomPosition ? Random.Range(-5f, 5f) : food.x;
                go.transform.position = new Vector3(x, -5, 0);
                go.GetComponent<Rigidbody2D>().velocity = food.velocity;
            }

            await new WaitForSeconds(3f);
            currentWave++;
        }
    }
}