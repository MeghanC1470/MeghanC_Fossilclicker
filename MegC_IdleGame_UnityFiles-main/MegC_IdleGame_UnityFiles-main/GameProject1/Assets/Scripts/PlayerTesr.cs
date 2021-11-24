using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerTesr : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public GlobalAutoClick2 autoCalcium;
    public int repair;
    public int damage;
    public GameObject AutoCarbon;
    public GameObject AutoCalcium;
    public GameObject RepairSkeleton;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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

    public void EndGame()
    {
        SceneManager.LoadScene("LoseScreen");
        AutoCarbon.SetActive(false);
        AutoCalcium.SetActive(false);
        RepairSkeleton.SetActive(false);
    }
}
