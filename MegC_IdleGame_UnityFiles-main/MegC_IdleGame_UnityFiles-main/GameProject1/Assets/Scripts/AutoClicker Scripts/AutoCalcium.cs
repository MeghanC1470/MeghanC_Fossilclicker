using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCalcium : MonoBehaviour
{

    public bool CreatingCalcium = false;
    public static int CalciumIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        InternalIncrease = CalciumIncrease;
        if (CreatingCalcium == false)
        {
            CreatingCalcium = true;
            StartCoroutine(CreateTheCalcium());
        }
    }

    IEnumerator CreateTheCalcium()
    {
        GlobalCalcium.CalciumCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCalcium = false;
    }
}
