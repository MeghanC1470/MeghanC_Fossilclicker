using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCarbon : MonoBehaviour
{

    public bool CreatingCarbon = false;
    public static int CarbonIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        InternalIncrease = CarbonIncrease;
        if (CreatingCarbon == false)
        {
            CreatingCarbon = true;
            StartCoroutine(CreateTheCarbon());
        }
    }

    IEnumerator CreateTheCarbon()
    {
        GlobalCarbon.CarbonCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCarbon = false;
    }
}
