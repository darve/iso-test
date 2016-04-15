using UnityEngine;
using System.Collections;

public class LadMovement : MonoBehaviour
{

    public float speed = 6f;

    Vector3 movement;
    Rigidbody body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
    }

    void Move(float h, float v)
    {
        movement = new Vector3(h * speed, 0f, v * speed);
        body.AddForce(movement);
    }
}
