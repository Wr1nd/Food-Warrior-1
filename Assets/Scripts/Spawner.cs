using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject fruitPrefab;
	public float spawnRate = 1;

	void Start()
	{
		InvokeRepeating("Spawn",0f,spawnRate);
	}


	public void Spawn()
	{
		var obj = Instantiate(fruitPrefab);
		var x = Random.Range(-5f, 5f);
		obj.transform.position = new Vector3(x, -5, 0);
	}
}