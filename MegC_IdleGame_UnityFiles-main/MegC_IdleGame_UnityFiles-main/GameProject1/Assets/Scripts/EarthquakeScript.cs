using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class EarthquakeScript : MonoBehaviour
{
    public float carbonCheck;
    public bool disasterActive = false;
    public int genChance;
    public int carbonLoss;
    public PlayerTesr playerBar;
    public HealthBar healthBar;
    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {

        carbonCheck = GlobalCarbon.CarbonCount / 35;
        if (disasterActive == false)
        {
            genChance = Random.Range(1, 50);
            if (carbonCheck >= genChance)
            {
                StartCoroutine(StartDisaster());
                
            }

        }

        if (playerBar.currentHealth <= 0)
        {
            playerBar.EndGame();
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
            carbonLoss = Mathf.RoundToInt(GlobalCarbon.CarbonCount * 0.10f);
            GlobalCarbon.CarbonCount -= carbonLoss;
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            playerBar.TakeDamage(5);
        yield return new WaitForSeconds(10);
        disasterActive = false;
        audioSource.PlayOneShot(clip);
    }


}
