using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public PadBounce padBounce;
    public float speed = 30;

    Rigidbody rigidBody;

    void Start()
    {
// !!!! TODO: change initial direction !!!!
// => give as parameter
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.down * speed;
    }
    /*
        void OnCollisionEnter( Collision col )
        {
            if (col.gameObject.name == "Pad")
            {
                // Calculate hit Factor
                float x = hitFactor( transform.position,
                                     col.transform.position,
                                     col.collider.bounds.size.x );

                Vector3 dir = new Vector3( x, 1, 0 ).normalized;

                rigidBody.velocity = dir * speed;
            }
        }
    */
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pad")
        {
            Vector3 dir = padBounce.bounceDirection(transform.position);
            rigidBody.velocity = dir * speed;
        }
    }
    /*
        float hitFactor( Vector3 ballPos, Vector3 otherPos, float otherWidth)
        {
            // ascii art:
            // ||  1 <- at the top of the racket
            // ||
            // ||  0 <- at the middle of the racket
            // ||
            // || -1 <- at the bottom of the racket
            return (ballPos.x - otherPos.x) / otherWidth;
        }
    */
}
