using UnityEngine;
using UnityEngine.Events;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject particlePrefab;
    public UnityEvent onShit;
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
        var particle = Instantiate(particlePrefab);
        particle.transform.position = transform.position;
        Destroy(gameObject);
    }
}