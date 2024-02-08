using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
	public GameObject fruitPrefab;
	public GameObject bombPrefab;
	public float spawnRate = 1;
	public float bombChance = 20;

	public List<Wave> waves = new();

	async void Start()
	{
		foreach (var wave in waves)
		{
			foreach (var item in wave.items)
			{
				await new WaitForSeconds(item.delay);

				var prefab = item.isBomb ? bombPrefab : fruitPrefab;
				if (item.bombChance > Random.Range(1f, 100f)) prefab = bombPrefab;

				var go = Instantiate(prefab);

				var offset = Random.Range(-item.xOffset, item.xOffset);
				go.transform.position = new Vector3(item.x + offset, -5, 0);

				go.GetComponent<Rigidbody2D>().velocity = item.velocity;
				if (item.rV)
				{
					go.GetComponent<Rigidbody2D>().velocity += new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 4f));
				}

			}

			await new WaitForSeconds(3);
		}
	}


	public void Spawn()
	{
		var prefab = Random.Range(0, 100) < (100-bombChance) ? fruitPrefab : bombPrefab;

		var obj = Instantiate(prefab);
		var x = Random.Range(-5f, 5f);
		obj.transform.position = new Vector3(x, -5, 0);
	}
}