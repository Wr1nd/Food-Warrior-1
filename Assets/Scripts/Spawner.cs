using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject fruit;

	void Start()
	{
		InvokeRepeating(nameof(Spawn),1f,1f);
	}

	void Spawn()
	{
		var obj = Instantiate(fruit);
		obj.transform.position = new Vector3(0,-6,0);
	}
}