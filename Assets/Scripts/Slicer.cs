using UnityEngine;

public class Slicer : MonoBehaviour
{
	Rigidbody2D rb;
	public int comboCount;
	public float comboTimeLeft;
	public AudioClip comboSound;

	void Start()
	{
		Application.targetFrameRate = 60;
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		worldPos.z = 0;
		rb.MovePosition(worldPos);


		// COMBO
		comboTimeLeft -= Time.deltaTime;
		if (comboTimeLeft <= 0)
		{
			if (comboCount > 2)
			{
				AudioSystem.Play(comboSound);
			}
			comboCount = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		print(":)");
		var food = other.gameObject.GetComponent<Food>();
		food.Slice();
		comboCount++;
		comboTimeLeft = 0.3f;
	}
}