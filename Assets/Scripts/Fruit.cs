using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
<<<<<<< Updated upstream
    public float y = 12f;
    
=======
    public AudioClip splashSound;
    public ParticleSystem splashParticles;
    public Color splashColor;
    public bool isBomb;

>>>>>>> Stashed changes
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, y);
    }

<<<<<<< Updated upstream
    
}
=======
    public void Slice()
    {
        Audio.Play(splashSound);

        if (isBomb)
        {
            print(":(");
        }

        foreach (Transform child in GetComponentsInChildren<Transform>())
        {
            if(child == transform) continue;

            Rigidbody2D rb = child.gameObject.AddComponent<Rigidbody2D>();
            rb.velocity = GetComponent<Rigidbody2D>().velocity + Random.insideUnitCircle * 5f;
            rb.angularVelocity = Random.Range(-10f, 10f);
        }

        ParticleSystem particles = Instantiate( splashParticles, transform.position, Quaternion.identity );
        particles.startColor = splashColor;

        transform.DetachChildren();
        Destroy(gameObject);
    }
}
>>>>>>> Stashed changes
