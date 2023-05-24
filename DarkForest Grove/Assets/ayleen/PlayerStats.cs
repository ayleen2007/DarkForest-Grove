using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(int damageCount)
    {
        Debug.Log("Taking damage!");
        if (damageCount >= health)
        {
            health = 80;
        }
        else {
            health -= damageCount;
        }
    }
   
}
