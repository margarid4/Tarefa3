using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public GameObject pickupParticlePrefab;

    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);



                GameObject pickupParticleObject = Instantiate(pickupParticlePrefab, transform.position, Quaternion.identity);
                // ParticleSystem particleSystem = pickupParticleObject.GetComponent<ParticleSystem>();
                // particleSystem.Play();

                controller.PlaySound(collectedClip);

            }
        }
    } 
}