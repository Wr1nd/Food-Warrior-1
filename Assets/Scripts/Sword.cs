using UnityEngine;

public class Sword : MonoBehaviour
{

    public AudioClip splashSound;
    public AudioClip gameplayMusic;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        Audio.Play(gameplayMusic);
    }

    void Update()
    {
        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position=pos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Audio.Play(splashSound);
        Destroy(other.gameObject);
    }
}