using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject bombPrefab;
	public GameObject fruitPrefab;
	public List<Wave> waves;

	async void Start()
	{
		foreach (var wave in waves)
		{
			foreach (var fruit in wave.items)
			{
				await new WaitForSeconds(fruit.delay);

				var prefab = fruit.isBomb ? bombPrefab : fruitPrefab;
				var go = Instantiate(prefab);
				go.transform.position = new Vector3(fruit.x, -5f, 0);

				var rigidbody2D = go.GetComponent<Rigidbody2D>();
				rigidbody2D.velocity = fruit.velocity;
			}

			await new WaitForSeconds(3f);
		}
	}
}