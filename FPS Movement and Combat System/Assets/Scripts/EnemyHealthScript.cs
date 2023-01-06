using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthScript : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public GameObject enemy;
    public Slider healthBar;

    private void Start()
    {
        health = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = health;
    }

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

        healthBar.value = health;
    }
}
