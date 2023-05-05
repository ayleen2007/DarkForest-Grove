using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collected");
        if (other.gameObject.tag == "Player")
        {
            Pickup();


        }
    }

    void Pickup()
    {
        Destroy(gameObject);
        // Instantiate(pickupEffect, transform.position, transform.rotation);
        //Spawn a cool effect

        //apply effect to the player


    }

}
