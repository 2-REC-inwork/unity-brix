using UnityEngine;
using System.Collections;

public class PadMovement : MonoBehaviour
{
    public float speed = 30;

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector3(movement * speed, 0, 0);
	}

}
