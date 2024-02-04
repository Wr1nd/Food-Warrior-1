using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject explodeParticles;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(7f,13f));
        rb.angularVelocity = Random.Range(-360,360);
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

        Destroy(gameObject);
    }
}