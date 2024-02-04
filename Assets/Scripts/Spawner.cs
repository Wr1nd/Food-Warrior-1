using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public List<GameObject> fruits;

	void Start()
	{
		InvokeRepeating(nameof(Spawn),1f,1f);
	}

	void Spawn()
	{
		var fruit = fruits[Random.Range(0,fruits.Count)];
		var obj = Instantiate(fruit);
		var x = Random.Range(-5f, 5f);
		obj.transform.position = new Vector3(x,-6,0);
	}
}