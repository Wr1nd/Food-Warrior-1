using UnityEngine;

public class Sword : MonoBehaviour
{
    void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // move sword with mouse
            var pos = Input.mousePosition;
            var worldPos = Camera.main.ScreenToWorldPoint(pos);
            worldPos.z = 0;

            transform.position = worldPos;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var fruit = other.gameObject.GetComponent<Fruit>();
        fruit.Slice();
    }
}