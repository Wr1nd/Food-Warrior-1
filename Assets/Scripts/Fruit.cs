using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float y = 12f;
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, y);
    }

    
}
