using UnityEngine;

public class Food : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,Random.Range(7f,13f));
        rb.angularVelocity = Random.Range(-360f, 360f);
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
            print(":(");
            Destroy(gameObject);
        }
    }
}