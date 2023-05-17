using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 1.4f;
    public float duration = 4f;
    public GameObject pickupEffect;
  
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Pickup (other));


        }
    }
    

    IEnumerator Pickup (Collider2D player)
    {
        Destroy(gameObject);
        // Instantiate(pickupEffect, transform.position, transform.rotation);
        //Spawn a cool effect

       PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.health *= multiplier;

     

        player.transform.localScale *= multiplier;
        //apply effect to the player
        //wait x amount of seconds
        yield return new WaitForSeconds(duration);
        //reverse the effect on our player
        stats.health /= multiplier;

    }

}
