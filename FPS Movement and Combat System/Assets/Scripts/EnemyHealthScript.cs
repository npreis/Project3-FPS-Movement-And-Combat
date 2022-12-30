using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    public int health;
    public GameObject enemy;

    public void DecreaseHealth(int damage)
    {
        if(health - damage <= 0)
        {
            Destroy(enemy);
        }
        else
        {
            health -= damage;
        }
    }
}
