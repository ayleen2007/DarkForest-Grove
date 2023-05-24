using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdamages : MonoBehaviour
{
    public int damage;
    private PlayerHealth playerStats;

    private void Start() {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Boss hit");
        if (collision.gameObject.tag == "Player")
        {
            playerStats.TakeDamage(damage);
        }
    }
}
