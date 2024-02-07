using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodEntry
{
    public bool isBomb;
    public float x;
    // delay, isRandomPosition
    // BONUS : velocity
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
    public GameObject fruitPrefab;
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

                var prefab = food.isBomb ? bombPrefab : fruitPrefab;
                var go = Instantiate(prefab);
                go.transform.position = new Vector3(food.x, -5, 0);
            }

            await new WaitForSeconds(3f);
            currentWave++;
        }
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