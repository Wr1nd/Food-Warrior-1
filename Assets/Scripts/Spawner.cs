<<<<<<< Updated upstream
using System.Collections;
=======
using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[Serializable]
public class FruitInfo
{
    public float x;
    public Vector2 velocity = new Vector2(0, 10);
    public bool isBomb;
}

[Serializable]
public class Wave
{
    public List<FruitInfo> fruits;
    public bool isSequence;

}

public class Spawner : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public GameObject[] prefabs;
    public GameObject Bomb;
    public List<Wave> waves;
    public float delay = 2f;
    public int currentWave;
>>>>>>> Stashed changes

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        InvokeRepeating("Spawn", 1f, 1f);
=======
        print(waves[1].fruits[0].isBomb);
        Spawn();
>>>>>>> Stashed changes
    }

    
    void Spawn()
    {
<<<<<<< Updated upstream
        Instantiate(prefab, transform.position, Quaternion.identity);
=======
        while (true)
        {
            /*await new WaitForSeconds(Random.Range(0.5f,2f));
            GameObject obj = prefabs[Random.Range(0, prefabs.Length)];
            Vector3 pos = transform.position + Vector3.right * Random.Range(-5f, 5f);
            Instantiate(obj, pos, Quaternion.identity);*/
            
            for(currentWave = 0; currentWave < waves.Count; currentWave++)
            {
                await new WaitForSeconds(Random.Range(0.5f,2f));
                Wave wave = waves[currentWave];
                for(int i = 0; i < wave.fruits.Count; i++)
                {
                    FruitInfo fruitInfo = wave.fruits[i];

                    Vector3 pos = transform.position + Vector3.right * Random.Range(-5f, 5f);
                    GameObject obj = fruitInfo.isBomb ? Bomb: prefabs[Random.Range(0, prefabs.Length)];
                    Instantiate(obj, pos, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = fruitInfo.velocity;


                    if (wave.isSequence == false) await new WaitForSeconds(0.5f);


                }
            }
        }
>>>>>>> Stashed changes
    }
}
