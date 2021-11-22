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
    public PlayerTesr healthBar;

    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {

        carbonCheck = GlobalCarbon.CarbonCount / 10;
        if (disasterActive == false)
        {
            genChance = Random.Range(1, 20);
            if (carbonCheck >= genChance)
            {
                StartCoroutine(StartDisaster());
            }

        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
            carbonLoss = Mathf.RoundToInt(GlobalCarbon.CarbonCount * 0.25f);
            GlobalCarbon.CarbonCount -= carbonLoss;
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            healthBar.TakeDamage(10);
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
