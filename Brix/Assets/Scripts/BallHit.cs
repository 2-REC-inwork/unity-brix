using UnityEngine;

public class BallHit : MonoBehaviour
{
    public int damagePerHit = 20;

    void OnCollisionEnter(Collision col)
    {
        BrixHealth brixHealth = col.collider.GetComponent<BrixHealth>();
        if (brixHealth != null)
        {
Debug.Log("contact");
            ContactPoint contact = col.contacts[0];
            brixHealth.TakeDamage(damagePerHit, contact.point);
        }
    }

}
