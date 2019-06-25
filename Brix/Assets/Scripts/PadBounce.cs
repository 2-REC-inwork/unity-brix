using UnityEngine;
using System.Collections;

public class PadBounce : MonoBehaviour
{
    Transform pad;
    float width;

    void Start()
    {
        pad = GetComponent<Transform>();
        width = GetComponent<Collider>().bounds.size.x;
    }

    public Vector3 bounceDirection(Vector3 ballPos)
    {
// !!!! TODO: change that !!!!
// => use a limited set of angles/directions (5)
        float x = (ballPos.x - pad.position.x) / width;

        return new Vector3(x, 1, 0).normalized;
    }

}
