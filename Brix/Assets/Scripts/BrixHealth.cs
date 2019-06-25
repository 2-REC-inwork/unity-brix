using UnityEngine;
using System.Collections;

public class BrixHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public int scoreValue = 10;
//    public AudioClip deathClip;

    Animator anim;
//    AudioSource audioSource;
//    ParticleSystem hitParticles;
    BoxCollider boxCollider;
    bool isDead;


    void Awake()
    {
        anim = GetComponent<Animator>();
//        audioSource = GetComponent<AudioSource>();
//        hitParticles = GetComponentInChildren<ParticleSystem>();
        boxCollider = GetComponent<BoxCollider>();

        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount, Vector3 hitPoint)
    {
        if (isDead)
        {
Debug.Log("TakeDamage - dead");
            return;
        }

//        audioSource.Play();

        currentHealth -= amount;
Debug.Log("TakeDamage - health: " + currentHealth);

        //        hitParticles.transform.position = hitPoint;
        //        hitParticles.Play();

        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;

        boxCollider.isTrigger = true;

        anim.SetTrigger("Dead");

//        audioSource.clip = deathClip;
//        audioSource.Play();
    }

}
