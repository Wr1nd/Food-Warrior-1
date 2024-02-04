using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject fruitPrefab;
	public GameObject bombPrefab;
	public float spawnRate = 1;
	public float bombChance = 20;

	void Start()
	{
		InvokeRepeating("Spawn",0f,spawnRate);
	}


	public void Spawn()
	{
		var prefab = Random.Range(0, 100) < (100-bombChance) ? fruitPrefab : bombPrefab;

		var obj = Instantiate(prefab);
		var x = Random.Range(-5f, 5f);
		obj.transform.position = new Vector3(x, -5, 0);
	}
}