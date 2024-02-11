using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject explodeParticles;
    Rigidbody2D rb;
    public GameObject leftSide;
    public GameObject rightSide;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 200;
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
           Miss();
        }
    }

    void Miss()
    {
        print(":(");
        Destroy(gameObject);
    }

    public void Slice()
    {
        var particles = Instantiate(explodeParticles);
        particles.transform.position = transform.position;

        // separate children
        transform.DetachChildren();
        var leftRb = leftSide.AddComponent<Rigidbody2D>();
        var rightRb = rightSide.AddComponent<Rigidbody2D>();
        leftRb.velocity = rb.velocity + new Vector2(-2,0);
        rightRb.velocity = rb.velocity + new Vector2(2,0);

        Destroy(gameObject);
    }
}