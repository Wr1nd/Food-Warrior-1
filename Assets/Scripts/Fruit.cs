using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,10);
        rb.angularVelocity = 100;
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
            Die();
        }
    }

    void Die()
    {
        print(":(");
        Destroy(gameObject);
    }
}