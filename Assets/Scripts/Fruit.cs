using UnityEngine;
using UnityEngine.Events;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject particlePrefab;

    public AudioClip sliceSound;
    public AudioClip missSound;
    public AudioClip throwSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(0,Random.Range(8f,13f));
        rb.angularVelocity = 100;
        AudioSystem.Play(throwSound);
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
        AudioSystem.Play(missSound);
    }

    public void Slice()
    {
        var particle = Instantiate(particlePrefab);
        particle.transform.position = transform.position;
        Destroy(gameObject);

        AudioSystem.Play(sliceSound);
    }
}