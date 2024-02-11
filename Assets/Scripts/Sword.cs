using UnityEngine;

public class Sword : MonoBehaviour
{
    public int comboScore;
    public float comboTimeLeft;

    public AudioClip comboSound;
    public GameObject comboText;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // move sword with mouse
            var pos = Input.mousePosition;
            var worldPos = Camera.main.ScreenToWorldPoint(pos);
            worldPos.z = 0;

            transform.position = worldPos;
        }

        comboTimeLeft -= Time.deltaTime;
        if (comboTimeLeft <= 0)
        {
            if (comboScore > 2)
            {
                print("Combo!");
                var obj = Instantiate(comboText);
                Destroy(obj,1.5f);
                AudioSystem.Play(comboSound);
            }
            comboScore = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var fruit = other.gameObject.GetComponent<Fruit>();
        fruit.Slice();

        comboScore++;
        comboTimeLeft = 0.3f;
    }
}