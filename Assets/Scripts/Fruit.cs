using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject particlePrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,Random.Range(8f,13f));
        rb.angularVelocity = 100;
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
        Instantiate(particlePrefab, transform.position, Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
}