using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTesr : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public int repair;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetMouseButtonDown(0))
       // {
      //      TakeDamage(10);
      //  }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RepairDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void RepairDamage(int repair)
    {
        currentHealth += repair;
        healthBar.SetHealth(currentHealth);
    }
}
