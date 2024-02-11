using UnityEngine;
using UnityEngine.Events;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject particlePrefab;
    public GameObject splashParticlePrefab;


    public AudioClip sliceSound;
    public AudioClip missSound;
    public AudioClip throwSound;

    public GameObject leftSlice;
    public GameObject rightSlice;

    public Color color;

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
        var splash = Instantiate(splashParticlePrefab,transform.position,Quaternion.Euler(0,0,0));
        splash.GetComponent<ParticleSystem>().startColor = color;

        var particle = Instantiate(particlePrefab);
        particle.GetComponent<ParticleSystem>().startColor = color;
        particle.transform.position = transform.position;
        Destroy(gameObject);

        // separate fruit slices
        var rb1 = leftSlice.AddComponent<Rigidbody2D>();
        var rb2 = rightSlice.AddComponent<Rigidbody2D>();
        rb1.velocity = rb.velocity + Vector2.left;
        rb2.velocity = rb.velocity + Vector2.right;
        rb1.angularVelocity = -10;
        rb2.angularVelocity = 10;
        transform.DetachChildren();

        AudioSystem.Play(sliceSound);

    }
}